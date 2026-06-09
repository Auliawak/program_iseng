// Variabel pesan acak yang menyala di kartu utama
const messages=[
  "Seperti reaksi kimia yang sempurna, kamu punya semua unsur untuk berhasil — kecerdasan, keberanian, dan hati yang baik. Teruslah bersinar! ✨",
  "Kamu adalah katalis terbaik — membuat semua orang di sekitarmu berkembang tanpa kamu ikut berkurang! 💜",
  "Hidupmu bagaikan tabel periodik: penuh potensi, terstruktur, dan selalu ada tempat untuk hal-hal baru! 🌟",
  "Setiap mol usahamu akan menghasilkan reaksi yang luar biasa. Hukum Avogadro berlaku untukmu! 6,022×10²³ semangat! 🔥"
];
let msgIdx=0;

// Data Bunga Kimia yang warnanya disesuaikan agar menyala neon terang
const flowerData=[
  {petals:["H","e","Li","Be","B"],pColors:["#ff79c6","#ff5555","#bd93f9","#ff79c6","#ffb86c"],center:{sym:"O",num:"8"},cColor:"#ff5555",stemH:100,label:"Rosa Oksigenia"},
  {petals:["N","Si","P","S","Ar"],pColors:["#8be9fd","#50fa7b","#f1fa8c","#ff5555","#bd93f9"],center:{sym:"C",num:"6"},cColor:"#f8f8f2",centerGlow:"#fff",stemH:130,label:"Bunga Karbona"},
  {petals:["Ca","Mg","Fe","Cu","Zn"],pColors:["#ffb86c","#50fa7b","#ff5555","#bd93f9","#8be9fd"],center:{sym:"Au",num:"79"},cColor:"#ffb86c",stemH:110,label:"Chrysanthe-Mum"},
  {petals:["Na","K","Cl","Br","I"],pColors:["#bd93f9","#50fa7b","#f1fa8c","#ffb86c","#ff79c6"],center:{sym:"Ag",num:"47"},cColor:"#8be9fd",stemH:90,label:"Halogenia"},
];

function buildFlowers(){
  const row=document.getElementById('flowersRow');
  flowerData.forEach((d,fi)=>{
    const wrap=document.createElement('div');
    wrap.className='flower-wrap';
    wrap.style.animationDelay=(fi*0.2)+'s';

    const petalsDiv=document.createElement('div');
    petalsDiv.className='petals';
    const angles=[0,72,144,216,288];
    d.petals.forEach((sym,i)=>{
      const p=document.createElement('div');
      p.className='petal';
      const ang=angles[i]*(Math.PI/180);
      const dist=24;
      p.style.left=(40-14+Math.sin(ang)*dist)+'px';
      p.style.top=(40-19-Math.cos(ang)*dist)+'px';
      p.style.color=d.pColors[i]; // Digunakan oleh box-shadow currentColor di CSS
      p.style.background=d.pColors[i];
      p.style.setProperty('--r',angles[i]+'deg');
      p.style.transform='rotate('+angles[i]+'deg)';
      p.style.animationDelay=(i*0.1)+'s';
      p.textContent=sym;
      petalsDiv.appendChild(p);
    });
    const center=document.createElement('div');
    center.className='center';
    center.style.background=d.cColor;
    center.style.boxShadow=`0 0 15px ${d.centerGlow || d.cColor}`;
    center.innerHTML=`<span style="font-size:9px;line-height:1;text-align:center;color:#0a0714">${d.center.sym}<br><span style="font-size:7px">${d.center.num}</span></span>`;
    petalsDiv.appendChild(center);

    const sw=document.createElement('div');
    sw.className='stem-wrap';
    sw.style.height=d.stemH+'px';
    sw.innerHTML=`<div class="stem" style="height:${d.stemH}px"></div><div class="leaf leaf-l" style="--lr:-30deg"></div><div class="leaf leaf-r" style="--lr:30deg"></div>`;

    const lbl=document.createElement('div');
    lbl.style.cssText='font-family:Caveat,cursive;font-size:15px;color:#bd93f9;text-shadow:0 0 6px #bd93f9;margin-top:6px;text-align:center';
    lbl.textContent=d.label;

    wrap.appendChild(petalsDiv);
    wrap.appendChild(sw);
    wrap.appendChild(lbl);
    row.appendChild(wrap);
  });
}

function buildStars(){
  const s=document.getElementById('stars');
  for(let i=0;i<25;i++){
    const el=document.createElement('div');
    el.className='star';
    el.style.left=Math.random()*100+'%';
    el.style.top=Math.random()*45+'%';
    el.style.animationDelay=Math.random()*3+'s';
    el.style.animationDuration=(1.5+Math.random()*2.5)+'s';
    
    const neonColors=['#ff79c6','#bd93f9','#8be9fd','#50fa7b','#f1fa8c'];
    const selectedColor=neonColors[Math.floor(Math.random()*neonColors.length)];
    el.style.background=selectedColor;
    el.style.boxShadow=`0 0 10px ${selectedColor}`;
    s.appendChild(el);
  }
}

function buildBubbles(){
  const b=document.getElementById('bubbles');
  for(let i=0;i<12;i++){
    const el=document.createElement('div');
    el.className='bubble';
    const sz=8+Math.random()*18;
    el.style.width=sz+'px';
    el.style.height=sz+'px';
    el.style.left=Math.random()*100+'%';
    el.style.animationDelay=Math.random()*6+'s';
    el.style.animationDuration=(4+Math.random()*4)+'s';
    b.appendChild(el);
  }
}

// Unsur periodik mini dengan warna neon yang menyala terang
const periodicElements=[
  {sym:'H',num:1,name:'Keberanian 💙',col:'#8be9fd'},
  {sym:'O',num:8,name:'Semangat ❤️',col:'#ff5555'},
  {sym:'C',num:6,name:'Kecerdasan 🤍',col:'#f8f8f2'},
  {sym:'N',num:7,name:'Kreativitas 💜',col:'#bd93f9'},
  {sym:'Fe',num:26,name:'Kekuatan 🔥',col:'#ff5555'},
  {sym:'Au',num:79,name:'Kemuliaan ✨',col:'#ffb86c'},
  {sym:'Ag',num:47,name:'Kejujuran 🌟',col:'#8be9fd'},
  {sym:'Ca',num:20,name:'Keteguhan 💥',col:'#ffb86c'},
  {sym:'K',num:19,name:'Kehangatan 🥰',col:'#bd93f9'},
  {sym:'Mg',num:12,name:'Kerendahan Hati 🌱',col:'#50fa7b'},
  {sym:'P',num:15,name:'Kesabaran ⏳',col:'#f1fa8c'},
  {sym:'S',num:16,name:'Bakat ⭐',col:'#f1fa8c'},
];

function buildPeriodic(){
  const band=document.getElementById('periodicBand');
  periodicElements.forEach(e=>{
    const el=document.createElement('div');
    el.className='el';
    el.style.background=e.col;
    el.style.color='#0a0714';
    el.innerHTML=`<div class="el-tooltip" style="background:${e.col}; color:#0a0714; font-weight:bold; box-shadow:0 0 10px ${e.col};">${e.name}</div><div class="el-sym">${e.sym}</div><div class="el-num">${e.num}</div>`;
    band.appendChild(el);
  });
}

function mixFlask(el,name,msg){
  document.getElementById('reactionMsg').textContent=msg;
  const sparkles=['✨','💜','⚡','🌸','💫','🎉'];
  const colors=['#ff79c6','#bd93f9','#8be9fd','#50fa7b','#f1fa8c'];
  
  for(let i=0;i<8;i++){
    const s=document.createElement('div');
    s.className='sparkle';
    const randomColor=colors[Math.floor(Math.random()*colors.length)];
    s.style.cssText=`
      left:${el.getBoundingClientRect().left+Math.random()*40}px;
      top:${el.getBoundingClientRect().top-20+Math.random()*20}px;
      font-size:${16+Math.random()*14}px;
      animation-delay:${Math.random()*0.2}s;
      position:fixed;
      color:${randomColor};
    `;
    s.textContent=sparkles[Math.floor(Math.random()*sparkles.length)];
    document.body.appendChild(s);
    setTimeout(()=>s.remove(),1200);
  }
  
  msgIdx=(msgIdx+1)%messages.length;
  setTimeout(()=>{
    document.getElementById('cardText').textContent=messages[msgIdx];
  },300);
}

// Menjalankan semua fungsi pembentuk elemen halaman
buildStars();
buildBubbles();
buildFlowers();
buildPeriodic();