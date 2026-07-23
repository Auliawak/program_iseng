// ==========================================================
// 1. DATA BASE
// ==========================================================
const dummyMissions = [
    { icon: "fa-seedling", text: "Menyediakan produk sambal berkualitas tinggi dengan cita rasa yang konsisten." },
    { icon: "fa-lightbulb", text: "Memberikan solusi praktis bagi masyarakat untuk menikmati sambal tanpa harus membuatnya sendiri." },
    { icon: "fa-scale-balanced", text: "Menyediakan produk dengan harga yang stabil dan terjangkau bagi konsumen." },
    { icon: "fa-pepper-hot", text: "Mengembangkan produk sambal inovatif yang sesuai dengan selera konsumen." },
    { icon: "fa-people-carry-box", text: "Mendukung pertumbuhan UMKM lokal melalui produk berkualitas." }
];

const dummyProducts = [
    { 
        name: "Sambel Botol Kita - Ukuran 135 ml", image: "images/sambal-135ml.png", 
        desc: "Kemasan praktis yang mudah dibawa bepergian, cocok untuk makan di kantor, saat traveling, atau aktivitas sehari-hari.",
        linkShopee: "https://id.shp.ee/vRQX5EhV", linkTokopedia: "https://tk.tokopedia.com/ZSXGg4kXL/"
    },
    { 
        name: "Sambel Botol Kita - Ukuran 250 ml", image: "images/sambal-250ml.png", 
        desc: "Kemasan lebih besar yang sangat cocok untuk stok sambal di rumah agar seluruh keluarga dapat menikmati kelezatannya kapan saja.",
        linkShopee: "https://id.shp.ee/vRQX5EhV", linkTokopedia: "https://tk.tokopedia.com/ZSXGg4kXL/"
    }
];

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

// ==========================================================
// 2. NAVIGASI MOBILE
// ==========================================================
const mobileMenu = document.getElementById('mobile-menu');
const navMenu = document.querySelector('.nav-menu');

if (mobileMenu && navMenu) {
    mobileMenu.addEventListener('click', () => {
        navMenu.classList.toggle('active');
        mobileMenu.classList.toggle('is-active');
    });
}

// ==========================================================
// 3. RENDER DATA (AMAN UNTUK MULTI-PAGE)
// ==========================================================
document.addEventListener('DOMContentLoaded', () => {
    if(document.getElementById('mission-list')) loadMissions();
    if(document.getElementById('products-list')) loadProducts();
    if(document.getElementById('outlets-list')) loadOutlets();
});

function loadMissions() {
    document.getElementById('mission-list').innerHTML = dummyMissions.map(m => `
        <div class="mission-card">
            <i class="fa-solid ${m.icon}"></i>
            <p>${m.text}</p>
        </div>
    `).join('');
}

function loadProducts() {
    document.getElementById('products-list').innerHTML = dummyProducts.map(p => `
        <div class="product-card">
            <div class="product-image-area">
                <img src="${p.image}" alt="${p.name}">
            </div>
            <div class="product-info">
                <h3>${p.name}</h3>
                <p>${p.desc}</p>
                <div class="marketplace-links">
                    <a href="${p.linkShopee}" target="_blank" class="btn-mp btn-shopee"><i class="fa-solid fa-bag-shopping"></i> Shopee</a>
                    <a href="${p.linkTokopedia}" target="_blank" class="btn-mp btn-tokopedia"><i class="fa-solid fa-store"></i> Tokopedia</a>
                </div>
            </div>
        </div>
    `).join('');
}

function loadOutlets() {
    document.getElementById('outlets-list').innerHTML = dummyOutlets.map((o, index) => {
        const hiddenClass = index >= 12 ? 'outlet-hidden' : '';
        return `<div class="outlet-card ${hiddenClass}">${o}</div>`;
    }).join('');
}

// ==========================================================
// 4. LOGIKA TOMBOL OUTLET & PENCARIAN
// ==========================================================
const btnLoadMore = document.getElementById('btnLoadMoreOutlets');
const btnShowLess = document.getElementById('btnShowLessOutlets');

if (btnLoadMore && btnShowLess) {
    btnLoadMore.addEventListener('click', () => {
        document.querySelectorAll('.outlet-hidden').forEach(card => card.classList.remove('outlet-hidden'));
        btnLoadMore.style.display = 'none'; 
        btnShowLess.style.display = 'block'; 
    });

    btnShowLess.addEventListener('click', () => {
        document.querySelectorAll('.outlet-card').forEach((card, index) => {
            if (index >= 12) card.classList.add('outlet-hidden'); 
        });
        btnShowLess.style.display = 'none'; 
        btnLoadMore.style.display = 'block'; 
        document.getElementById('outlets').scrollIntoView({ behavior: 'smooth' });
    });
}

const searchInput = document.getElementById('outletSearch');
if (searchInput) {
    searchInput.addEventListener('input', (e) => {
        const text = e.target.value.toLowerCase();
        const cards = document.querySelectorAll('.outlet-card');
        
        if (text.length > 0) {
            if (btnLoadMore) btnLoadMore.style.display = 'none';
            if (btnShowLess) btnShowLess.style.display = 'none';
            cards.forEach(card => {
                card.classList.remove('outlet-hidden'); 
                card.style.display = card.textContent.toLowerCase().includes(text) ? "block" : "none";
            });
        } else {
            if (btnLoadMore) btnLoadMore.style.display = 'block';
            if (btnShowLess) btnShowLess.style.display = 'none';
            cards.forEach((card, index) => {
                card.style.display = ""; 
                if (index >= 12) card.classList.add('outlet-hidden');
                else card.classList.remove('outlet-hidden');
            });
        }
    });
}

// ==========================================================
// 5. FORM WHATSAPP
// ==========================================================
const msgForm = document.getElementById('msgForm');
if (msgForm) {
    msgForm.addEventListener('submit', (e) => {
        e.preventDefault();
        const nama = document.getElementById('formNama').value;
        const pesan = document.getElementById('formPesan').value;
        const teks = `Halo Sambel Botol Kita, saya ingin bertanya.%0A%0A*Nama:* ${encodeURIComponent(nama)}%0A*Pesan:* ${encodeURIComponent(pesan)}`;
        window.open(`https://api.whatsapp.com/send?phone=6281346560045&text=${teks}`, '_blank');
        msgForm.reset();
    });
}