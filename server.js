const express = require('express');
const mysql = require('mysql2');
const cors = require('cors');

const app = express();
app.use(cors());
app.use(express.json());

// Koneksi ke Database
const db = mysql.createConnection({
    host: 'localhost',
    user: 'root',
    password: 'password_kamu',
    database: 'sambel_botol_kita_db'
});

db.connect(err => {
    if (err) throw err;
    console.log('Database terhubung!');
});

// Endpoint Mengambil Data Produk
app.get('/api/products', (req, res) => {
    db.query('SELECT * FROM products', (err, results) => {
        if (err) return res.status(500).json(err);
        res.json(results);
    });
});

// Endpoint Mengambil Data Outlet
app.get('/api/outlets', (req, res) => {
    db.query('SELECT * FROM outlets', (err, results) => {
        if (err) return res.status(500).json(err);
        res.json(results);
    });
});

app.listen(3000, () => {
    console.log('Server berjalan di port 3000');
});