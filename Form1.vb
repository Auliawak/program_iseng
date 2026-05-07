Imports System.IO
Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class Form1
    ' --- 1. DEKLARASI VARIABEL GLOBAL ---
    Dim connString As String = "server=localhost;user id=root;password=;database=dbml;"
    Dim conn As New MySqlConnection(connString)
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader

    Dim pathGambar As String = ""
    Dim idHeroTerpilih As Integer = 0
    Dim imageListHero As New ImageList()

    ' --- 2. FORM LOAD ---
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imageListHero.ImageSize = New Size(80, 80)
        Dim pathLingkaran As New System.Drawing.Drawing2D.GraphicsPath()
        pathLingkaran.AddEllipse(0, 0, gambar.Width, gambar.Height)
        gambar.Region = New Region(pathLingkaran)
        ' ---------------------------------------------------

        ' Atur View ListView ke LargeIcon
        ListJung.View = View.LargeIcon

        ' Atur View ListView ke LargeIcon
        ListJung.View = View.LargeIcon
        ListRoam.View = View.LargeIcon
        ListExp.View = View.LargeIcon
        ListGold.View = View.LargeIcon
        ListMid.View = View.LargeIcon

        ' Isi ComboBox (Jika belum diisi lewat Properties)
        If cbLane.Items.Count = 0 Then
            cbLane.Items.AddRange(New String() {"Jungle", "Roam", "ExpLane", "GoldLane", "MidLane"})
        End If
        If cbTier.Items.Count = 0 Then
            cbTier.Items.AddRange(New String() {"S", "A", "B", "C"})
        End If

        LoadSemuaData()
    End Sub

    ' --- 3. FUNGSI MENAMPILKAN DATA KE LISTVIEW ---
    Private Sub LoadSemuaData()
        ' Fungsi ini memuat data ke masing-masing ListView berdasarkan Lane-nya
        LoadDataSatuLane("Jungle", ListJung)
        LoadDataSatuLane("Roam", ListRoam)
        LoadDataSatuLane("ExpLane", ListExp)
        LoadDataSatuLane("GoldLane", ListGold)
        LoadDataSatuLane("MidLane", ListMid)
    End Sub

    Private Sub LoadDataSatuLane(namaLane As String, lv As ListView)
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            lv.Items.Clear()
            lv.LargeImageList = imageListHero

            Dim query As String = "SELECT h.id_hero, h.nama_hero, h.gambar, t.grade_tier 
                                   FROM tb_hero h JOIN tb_tierlist t ON h.id_hero = t.id_hero 
                                   WHERE t.lane = @lane"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@lane", namaLane)

            ' Gunakan variabel reader lokal agar tidak bentrok saat dipanggil berurutan
            Dim localReader As MySqlDataReader = cmd.ExecuteReader()

            While localReader.Read()
                Dim id As Integer = localReader("id_hero")
                Dim nama As String = localReader("nama_hero").ToString()
                Dim path As String = localReader("gambar").ToString()
                Dim tier As String = localReader("grade_tier").ToString()

                ' Cek apakah gambar sudah ada di ImageList agar tidak dobel
                If Not imageListHero.Images.ContainsKey(id.ToString()) Then
                    If File.Exists(path) Then
                        imageListHero.Images.Add(id.ToString(), Image.FromFile(path))
                    Else
                        imageListHero.Images.Add(id.ToString(), New Bitmap(80, 80))
                    End If
                End If

                Dim item As New ListViewItem(nama)
                item.ImageKey = id.ToString()
                item.Tag = id

                ' Masukkan ke Grup berdasarkan Tier (Pastikan Group Name di Properties sesuai: grpTierS, dll)
                If tier = "S" Then item.Group = lv.Groups("grpS")
                If tier = "A" Then item.Group = lv.Groups("grpA")
                If tier = "B" Then item.Group = lv.Groups("grpB")
                If tier = "C" Then item.Group = lv.Groups("grpC")

                lv.Items.Add(item)
            End While
            localReader.Close()
        Catch ex As Exception
            MsgBox("Gagal memuat data " & namaLane & ": " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' --- 4. KLIK HERO DI LISTVIEW (Semua ListView memanggil fungsi yang sama) ---
    Private Sub ListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListJung.SelectedIndexChanged, ListRoam.SelectedIndexChanged, ListExp.SelectedIndexChanged, ListGold.SelectedIndexChanged, ListMid.SelectedIndexChanged
        Dim lv As ListView = CType(sender, ListView)
        If lv.SelectedItems.Count > 0 Then
            idHeroTerpilih = Convert.ToInt32(lv.SelectedItems(0).Tag)
            TampilkanDetailHero(idHeroTerpilih)
        End If
    End Sub

    Private Sub TampilkanDetailHero(id As Integer)
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "SELECT h.*, t.lane, t.grade_tier FROM tb_hero h 
                                   JOIN tb_tierlist t ON h.id_hero = t.id_hero WHERE h.id_hero = @id"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", id)
            reader = cmd.ExecuteReader()

            If reader.Read() Then
                txtNama.Text = reader("nama_hero").ToString()
                cbLane.Text = reader("lane").ToString()
                cbTier.Text = reader("grade_tier").ToString()

                ' Set Gambar
                pathGambar = reader("gambar").ToString()
                If File.Exists(pathGambar) Then
                    gambar.ImageLocation = pathGambar
                    gambar.SizeMode = PictureBoxSizeMode.Zoom
                Else
                    gambar.Image = Nothing
                End If

                ' Set CheckBox Role
                Dim roleStr As String = reader("role").ToString()
                cbAssasin.Checked = roleStr.Contains("Assasin")
                cbFighter.Checked = roleStr.Contains("Fighter")
                cbMarksman.Checked = roleStr.Contains("Marksman")
                cbTank.Checked = roleStr.Contains("Tank")
                cbSupport.Checked = roleStr.Contains("Support")
                cbMage.Checked = roleStr.Contains("Mage")

                ' Set CheckedListBox Counter & Sinergi
                Dim dbCounter As String = reader("counter").ToString()
                Dim dbSinergi As String = reader("sinergi").ToString()

                For i As Integer = 0 To clbCounter.Items.Count - 1
                    clbCounter.SetItemChecked(i, dbCounter.Contains(clbCounter.Items(i).ToString()))
                Next
                For i As Integer = 0 To clbSinergis.Items.Count - 1
                    clbSinergis.SetItemChecked(i, dbSinergi.Contains(clbSinergis.Items(i).ToString()))
                Next
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox("Gagal mengambil detail: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' --- 5. LOGIKA PEMBATASAN CHECKBOX (MAX 2 ROLE, MAX 3 COUNTER/SINERGI) ---
    Private Sub Role_CheckedChanged(sender As Object, e As EventArgs) Handles cbAssasin.CheckedChanged, cbFighter.CheckedChanged, cbMarksman.CheckedChanged, cbTank.CheckedChanged, cbSupport.CheckedChanged, cbMage.CheckedChanged
        Dim chk As CheckBox = CType(sender, CheckBox)
        If chk.Checked Then
            Dim hitungRole As Integer = 0
            If cbAssasin.Checked Then hitungRole += 1
            If cbFighter.Checked Then hitungRole += 1
            If cbMarksman.Checked Then hitungRole += 1
            If cbTank.Checked Then hitungRole += 1
            If cbSupport.Checked Then hitungRole += 1
            If cbMage.Checked Then hitungRole += 1

            If hitungRole > 2 Then
                MsgBox("Maksimal 2 Role yang bisa dipilih!", MsgBoxStyle.Exclamation)
                chk.Checked = False ' Batalkan centang
            End If
        End If
    End Sub

    Private Sub clbCounter_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbCounter.ItemCheck
        If e.NewValue = CheckState.Checked AndAlso clbCounter.CheckedItems.Count >= 3 Then
            MsgBox("Maksimal 3 Hero Counter!", MsgBoxStyle.Exclamation)
            e.NewValue = CheckState.Unchecked
        End If
    End Sub

    Private Sub clbSinergis_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbSinergis.ItemCheck
        If e.NewValue = CheckState.Checked AndAlso clbSinergis.CheckedItems.Count >= 3 Then
            MsgBox("Maksimal 3 Hero Sinergi!", MsgBoxStyle.Exclamation)
            e.NewValue = CheckState.Unchecked
        End If
    End Sub

    ' --- 6. LOGIKA PENCARIAN (SEARCH BUKAN FILTER, TAPI SCROLL) ---
    Private Sub txtCariCounter_TextChanged(sender As Object, e As EventArgs) Handles txtCariCounter.TextChanged
        If txtCariCounter.Text <> "" Then
            For i As Integer = 0 To clbCounter.Items.Count - 1
                If clbCounter.Items(i).ToString().ToLower().Contains(txtCariCounter.Text.ToLower()) Then
                    clbCounter.SelectedIndex = i
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub txtCariSinergis_TextChanged(sender As Object, e As EventArgs) Handles txtCariSinergis.TextChanged
        If txtCariSinergis.Text <> "" Then
            For i As Integer = 0 To clbSinergis.Items.Count - 1
                If clbSinergis.Items(i).ToString().ToLower().Contains(txtCariSinergis.Text.ToLower()) Then
                    clbSinergis.SelectedIndex = i
                    Exit For
                End If
            Next
        End If
    End Sub

    ' --- 7. FUNGSI HELPER UNTUK MENGGABUNGKAN DATA CHECKBOX ---
    Private Function GetRoleString() As String
        Dim roles As New List(Of String)
        If cbAssasin.Checked Then roles.Add("Assasin")
        If cbFighter.Checked Then roles.Add("Fighter")
        If cbMarksman.Checked Then roles.Add("Marksman")
        If cbTank.Checked Then roles.Add("Tank")
        If cbSupport.Checked Then roles.Add("Support")
        If cbMage.Checked Then roles.Add("Mage")
        Return String.Join(", ", roles)
    End Function

    Private Function GetCLBString(clb As CheckedListBox) As String
        Dim listStr As New List(Of String)
        For Each item In clb.CheckedItems
            listStr.Add(item.ToString())
        Next
        Return String.Join(", ", listStr)
    End Function

    ' --- 8. CRUD BUTTONS ---
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFile As New OpenFileDialog()
        openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.webp"
        If openFile.ShowDialog() = DialogResult.OK Then
            pathGambar = openFile.FileName
            gambar.ImageLocation = pathGambar
            gambar.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtNama.Text = "" Or cbLane.Text = "" Or pathGambar = "" Then
            MsgBox("Nama, Lane, dan Gambar wajib diisi!")
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim strRole As String = GetRoleString()
            Dim strCounter As String = GetCLBString(clbCounter)
            Dim strSinergi As String = GetCLBString(clbSinergis)

            Dim qHero As String = "INSERT INTO tb_hero (nama_hero, role, counter, sinergi, gambar) VALUES (@nama, @role, @counter, @sinergi, @gambar)"
            cmd = New MySqlCommand(qHero, conn)
            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@role", strRole)
            cmd.Parameters.AddWithValue("@counter", strCounter)
            cmd.Parameters.AddWithValue("@sinergi", strSinergi)
            cmd.Parameters.AddWithValue("@gambar", Replace(pathGambar, "\", "\\"))
            cmd.ExecuteNonQuery()

            Dim idBaru As Integer = CInt(cmd.LastInsertedId)

            Dim qTier As String = "INSERT INTO tb_tierlist (id_hero, lane, grade_tier) VALUES (@id_hero, @lane, @tier)"
            cmd = New MySqlCommand(qTier, conn)
            cmd.Parameters.AddWithValue("@id_hero", idBaru)
            cmd.Parameters.AddWithValue("@lane", cbLane.Text)
            cmd.Parameters.AddWithValue("@tier", cbTier.Text)
            cmd.ExecuteNonQuery()

            MsgBox("Data Hero berhasil ditambahkan!")
            BersihkanForm()
            LoadSemuaData()
        Catch ex As Exception
            MsgBox("Gagal menambah data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If idHeroTerpilih = 0 Then
            MsgBox("Pilih hero di daftar terlebih dahulu!")
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim strRole As String = GetRoleString()
            Dim strCounter As String = GetCLBString(clbCounter)
            Dim strSinergi As String = GetCLBString(clbSinergis)

            Dim qHero As String = "UPDATE tb_hero SET nama_hero=@nama, role=@role, counter=@counter, sinergi=@sinergi, gambar=@gambar WHERE id_hero=@id"
            cmd = New MySqlCommand(qHero, conn)
            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@role", strRole)
            cmd.Parameters.AddWithValue("@counter", strCounter)
            cmd.Parameters.AddWithValue("@sinergi", strSinergi)
            cmd.Parameters.AddWithValue("@gambar", Replace(pathGambar, "\", "\\"))
            cmd.Parameters.AddWithValue("@id", idHeroTerpilih)
            cmd.ExecuteNonQuery()

            Dim qTier As String = "UPDATE tb_tierlist SET lane=@lane, grade_tier=@tier WHERE id_hero=@id"
            cmd = New MySqlCommand(qTier, conn)
            cmd.Parameters.AddWithValue("@lane", cbLane.Text)
            cmd.Parameters.AddWithValue("@tier", cbTier.Text)
            cmd.Parameters.AddWithValue("@id", idHeroTerpilih)
            cmd.ExecuteNonQuery()

            MsgBox("Data berhasil diperbarui!")
            LoadSemuaData()
        Catch ex As Exception
            MsgBox("Gagal mengupdate data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If idHeroTerpilih = 0 Then Return

        If MessageBox.Show("Yakin ingin menghapus hero ini?", "Hapus", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()
                cmd = New MySqlCommand("DELETE FROM tb_tierlist WHERE id_hero=@id", conn)
                cmd.Parameters.AddWithValue("@id", idHeroTerpilih)
                cmd.ExecuteNonQuery()

                cmd = New MySqlCommand("DELETE FROM tb_hero WHERE id_hero=@id", conn)
                cmd.Parameters.AddWithValue("@id", idHeroTerpilih)
                cmd.ExecuteNonQuery()

                MsgBox("Data dihapus!")
                BersihkanForm()
                LoadSemuaData()
            Catch ex As Exception
                MsgBox("Gagal hapus: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub BersihkanForm()
        txtNama.Clear()
        cbLane.SelectedIndex = -1
        cbTier.SelectedIndex = -1
        gambar.Image = Nothing
        pathGambar = ""
        idHeroTerpilih = 0

        ' Hapus centang role
        cbAssasin.Checked = False : cbFighter.Checked = False : cbMarksman.Checked = False
        cbTank.Checked = False : cbSupport.Checked = False : cbMage.Checked = False

        ' Hapus centang CLB
        For i As Integer = 0 To clbCounter.Items.Count - 1
            clbCounter.SetItemChecked(i, False)
        Next
        For i As Integer = 0 To clbSinergis.Items.Count - 1
            clbSinergis.SetItemChecked(i, False)
        Next
    End Sub
End Class