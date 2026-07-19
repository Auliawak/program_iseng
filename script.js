// DUMMY DATABASE (Visi & Misi, Produk, dan Outlet)
const dummyMissions = [
    { icon: "fa-seedling", text: "Menyediakan produk sambal berkualitas tinggi dengan cita rasa yang konsisten." },
    { icon: "fa-lightbulb", text: "Memberikan solusi praktis bagi masyarakat untuk menikmati sambal tanpa harus membuatnya sendiri." },
    { icon: "fa-scale-balanced", text: "Menyediakan produk dengan harga yang stabil dan terjangkau bagi konsumen." },
    { icon: "fa-pepper-hot", text: "Mengembangkan produk sambal inovatif yang sesuai dengan selera konsumen." },
    { icon: "fa-people-carry-box", text: "Mendukung pertumbuhan UMKM lokal melalui produk berkualitas." }
];

const dummyProducts = [
    { 
        name: "Sambel Botol Kita - Ukuran 135 ml", 
        price: "Rp 12.000,00", 
        image: "images/sambal-135ml.png", 
        desc: "Kemasan praktis yang mudah dibawa bepergian, cocok untuk makan di kantor, saat traveling, atau aktivitas sehari-hari." 
    },
    { 
        name: "Sambel Botol Kita - Ukuran 250 ml", 
        price: "Rp 22.000,00", 
        image: "images/sambal-250ml.png", 
        desc: "Kemasan lebih besar yang sangat cocok untuk stok sambal di rumah agar seluruh keluarga dapat menikmati kelezatannya kapan saja." 
    }
];

const dummyOutlets = [
    "Hypermart Big Mall", "Foodmart Lembuswana", "Planet Swalayan City Centrum", "Planet Swalayan Gatsu",
    "Era Mart Citowns", "Era Fresh Revolusi", "Era Mart Loa Janan", "Era Fresh Siradj Salman",
    "Meli Mart", "Joy Mart Pelita", "Joy Mart Bung Tomo", "Auto Swalayan", "Mega Swalayan",
    "Hayyu Mart", "Hokki Swalayan", "Arjuna Baru", "Xs Mart M Said"
];

// NAV MENU TOGGLE (MOBILE)
const mobileMenu = document.getElementById('mobile-menu');
const navMenu = document.querySelector('.nav-menu');

mobileMenu.addEventListener('click', () => {
    navMenu.classList.toggle('active');
    mobileMenu.classList.toggle('is-active');
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
                <p class="price">${p.price}</p>
                <p>${p.desc}</p>
            </div>
        </div>
    `).join('');
}

function loadOutlets() {
    const list = document.getElementById('outlets-list');
    list.innerHTML = dummyOutlets.map(o => `
        <div class="outlet-card">${o}</div>
    `).join('');
}

// FITUR PENCARIAN OUTLET (REAL-TIME FILTER)
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

msgForm.addEventListener('submit', (e) => {
    e.preventDefault(); // Mencegah halaman reload saat form dikirim

    // 1. Ambil data dari input form
    const nama = document.getElementById('formNama').value;
    const email = document.getElementById('formEmail').value;
    const pesan = document.getElementById('formPesan').value;

    // 2. Ganti nomor ini dengan nomor WhatsApp tokomu (Gunakan kode negara, tanpa tanda + atau spasi)
    // Contoh nomor dari PDF: 081346560045 menjadi 6281346560045
    const nomorWA = "6281346560045"; 

    // 3. Susun format teks pesan yang akan dikirim
    const teksPesan = `Halo Sambel Botol Kita, saya ingin bertanya.%0A%0A` +
                      `*Nama:* ${encodeURIComponent(nama)}%0A` +
                      `*Email:* ${encodeURIComponent(email)}%0A` +
                      `*Pesan:* ${encodeURIComponent(pesan)}`;

    // 4. Buka tautan WhatsApp API di tab baru
    window.open(`https://api.whatsapp.com/send?phone=${nomorWA}&text=${teksPesan}`, '_blank');
    
    // Opsi tambahan: reset form setelah dikirim
    msgForm.reset();
});