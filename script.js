// DATA VISI MISI
const dummyMissions = [
    { icon: "fa-seedling", text: "Menyediakan produk sambal berkualitas tinggi dengan cita rasa yang konsisten." },
    { icon: "fa-lightbulb", text: "Memberikan solusi praktis bagi masyarakat untuk menikmati sambal tanpa harus membuatnya sendiri." },
    { icon: "fa-scale-balanced", text: "Menyediakan produk dengan harga yang stabil dan terjangkau bagi konsumen." },
    { icon: "fa-pepper-hot", text: "Mengembangkan produk sambal inovatif yang sesuai dengan selera konsumen." },
    { icon: "fa-people-carry-box", text: "Mendukung pertumbuhan UMKM lokal melalui produk berkualitas." }
];

// DATA PRODUK (DENGAN LINK SHOPEE & TOKPED)
const dummyProducts = [
    { 
        name: "Sambel Botol Kita - Ukuran 135 ml", 
        image: "images/sambal-135ml.png", 
        desc: "Kemasan praktis yang mudah dibawa bepergian, cocok untuk makan di kantor, saat traveling, atau aktivitas sehari-hari.",
        linkShopee: "https://id.shp.ee/vRQX5EhV",
        linkTokopedia: "https://tk.tokopedia.com/ZSXGg4kXL/"
    },
    { 
        name: "Sambel Botol Kita - Ukuran 250 ml", 
        image: "images/sambal-250ml.png", 
        desc: "Kemasan lebih besar yang sangat cocok untuk stok sambal di rumah agar seluruh keluarga dapat menikmati kelezatannya kapan saja.",
        linkShopee: "https://id.shp.ee/vRQX5EhV",
        linkTokopedia: "https://tk.tokopedia.com/ZSXGg4kXL/"
    }
];

// DATA OUTLET
const dummyOutlets = [
    "Planet Swalayan City Centrum", "Planet Swalayan Gatsu", "Meli Mart", "Joy Mart Pelita",
    "Joy Mart Bung Tomo", "Auto Swalayan", "Mega Swalayan", "Hayyu Mart", "Hokki Swalayan",
    "Arjuna Baru", "Xs Mart M Said", "Xs Mart Lambung", "Xs Mart Pmi", "Coop Korem",
    "Family Mart", "Swalayan 88 Imam Bonjol", "Swalayan 88 Juanda", "Pusat Oleh Oleh Najwa",
    "Galery Etham Samarinda", "Mm Mulawarman", "Gbe Swalayan", "Pandan Harum Mart",
    "Bulek Nurul L 1", "Koperasi Tms Ta 1", "Koperasi Tms Ta 2", "Yugo Mart",
    "Foodmart Lembuswana", "Hypermart Big Mall", "Daging Keluarga", "Era Mart Citowns",
    "Era Fresh Revolusi", "Era Mart Loa Janan", "Era Fresh Siradj Salman", "Era Fresh Di Panjaitan",
    "Era Mart Tenggiri", "Era Fresh Sentosa", "Era 5000 Sebrang", "Era Fresh Gatsu",
    "Era Fresh Pm Noor 2", "Era M2 Mart", "Era Mart Pramuka", "Era Mart Ring Road 1",
    "Era Mart Jakarta 2", "Era Mart Harum Nafsi", "Era Mart Palaran", "Era Mart Kebaktian",
    "Era Mart L 3", "Era Mart L 2", "Era Mart Suryanata 1", "Era Amin Mart",
    "Era Dc Mart Ks Tubun", "Era Fresh Bontang", "Era Fresh Sangatta"
];

// NAV MENU TOGGLE (MOBILE)
const mobileMenu = document.getElementById('mobile-menu');
const navMenu = document.querySelector('.nav-menu');

mobileMenu.addEventListener('click', () => {
    navMenu.classList.toggle('active');
    mobileMenu.classList.toggle('is-active');
});

// MENUTUP MENU OTOMATIS SAAT DIKLIK DI HP
const navLinks = document.querySelectorAll('.nav-menu li a');
navLinks.forEach(link => {
    link.addEventListener('click', () => {
        navMenu.classList.remove('active');
        mobileMenu.classList.remove('is-active');
    });
});

// LOAD DATA SETELAH DOM SIAP
document.addEventListener('DOMContentLoaded', () => {
    loadMissions();
    loadProducts();
    loadOutlets();
});

function loadMissions() {
    const list = document.getElementById('mission-list');
    list.innerHTML = dummyMissions.map(m => `
        <div class="mission-card">
            <i class="fa-solid ${m.icon}"></i>
            <p>${m.text}</p>
        </div>
    `).join('');
}

function loadProducts() {
    const list = document.getElementById('products-list');
    list.innerHTML = dummyProducts.map(p => `
        <div class="product-card">
            <div class="product-image-area" style="background: none; height: auto; padding: 20px;">
                <img src="${p.image}" alt="${p.name}">
            </div>
            <div class="product-info">
                <h3>${p.name}</h3>
                <p>${p.desc}</p>
                
                <div class="marketplace-links">
                    <a href="${p.linkShopee}" target="_blank" class="btn-mp btn-shopee">
                        <i class="fa-solid fa-bag-shopping"></i> Shopee
                    </a>
                    <a href="${p.linkTokopedia}" target="_blank" class="btn-mp btn-tokopedia">
                        <i class="fa-solid fa-store"></i> Tokopedia
                    </a>
                </div>
            </div>
        </div>
    `).join('');
}

// FUNGSI LOAD OUTLET (HANYA MENAMPILKAN 12 AWAL)
function loadOutlets() {
    const list = document.getElementById('outlets-list');
    list.innerHTML = dummyOutlets.map((o, index) => {
        // Menyembunyikan outlet urutan ke-13 dan seterusnya
        const hiddenClass = index >= 12 ? 'outlet-hidden' : '';
        return `<div class="outlet-card ${hiddenClass}">${o}</div>`;
    }).join('');
}

// FUNGSI TOMBOL "LIHAT SEMUA OUTLET"
const btnLoadMore = document.getElementById('btnLoadMoreOutlets');
if (btnLoadMore) {
    btnLoadMore.addEventListener('click', () => {
        // Hapus class hidden dari semua outlet
        const hiddenCards = document.querySelectorAll('.outlet-hidden');
        hiddenCards.forEach(card => card.classList.remove('outlet-hidden'));
        
        // Sembunyikan tombol setelah semua outlet terbuka
        btnLoadMore.style.display = 'none';
    });
}

// FITUR PENCARIAN OUTLET (DIPERBARUI)
const searchInput = document.getElementById('outletSearch');
searchInput.addEventListener('input', (e) => {
    const text = e.target.value.toLowerCase();
    const cards = document.querySelectorAll('.outlet-card');
    
    if (text.length > 0) {
        // Jika sedang mengetik: Hilangkan batasan 12 awal, tampilkan yang cocok saja
        if(btnLoadMore) btnLoadMore.style.display = 'none';
        cards.forEach(card => {
            card.classList.remove('outlet-hidden'); 
            if (card.textContent.toLowerCase().includes(text)) {
                card.style.display = "block";
            } else {
                card.style.display = "none";
            }
        });
    } else {
        // Jika kotak pencarian kosong kembali: Kembalikan ke mode 12 awal
        if(btnLoadMore) btnLoadMore.style.display = 'block';
        cards.forEach((card, index) => {
            card.style.display = ""; // Reset inline style
            if (index >= 12) {
                card.classList.add('outlet-hidden');
            }
        });
    }
});

// FITUR PENCARIAN OUTLET
const searchInput = document.getElementById('outletSearch');
searchInput.addEventListener('input', (e) => {
    const text = e.target.value.toLowerCase();
    const cards = document.querySelectorAll('.outlet-card');
    cards.forEach(card => {
        if (card.textContent.toLowerCase().includes(text)) {
            card.style.display = "block";
        } else {
            card.style.display = "none";
        }
    });
});

// FITUR KIRIM FORM KE WHATSAPP
const msgForm = document.getElementById('msgForm');
if(msgForm) {
    msgForm.addEventListener('submit', (e) => {
        e.preventDefault();
        const nama = document.getElementById('formNama').value;
        const email = document.getElementById('formEmail').value;
        const pesan = document.getElementById('formPesan').value;
        const nomorWA = "6281346560045"; 
        const teksPesan = `Halo Sambel Botol Kita, saya ingin bertanya.%0A%0A` +
                          `*Nama:* ${encodeURIComponent(nama)}%0A` +
                          `*Email:* ${encodeURIComponent(email)}%0A` +
                          `*Pesan:* ${encodeURIComponent(pesan)}`;
        window.open(`https://api.whatsapp.com/send?phone=${nomorWA}&text=${teksPesan}`, '_blank');
        msgForm.reset();
    });
}