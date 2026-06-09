const messages=[
  "Seperti reaksi kimia yang sempurna, kamu punya semua unsur untuk berhasil — kecerdasan, keberanian, dan hati yang baik. Teruslah bersinar! ✨",
  "Kamu adalah katalis terbaik — membuat semua orang di sekitarmu berkembang tanpa kamu ikut berkurang! 💜",
  "Hidupmu bagaikan tabel periodik: penuh potensi, terstruktur, dan selalu ada tempat untuk hal-hal baru! 🌟",
  "Setiap mol usahamu akan menghasilkan reaksi yang luar biasa. Hukum Avogadro berlaku untukmu! 6,022×10²³ semangat! 🔥"
];
let msgIdx=0;

const flowerData=[
  {petals:["H","e","Li","Be","B"],pColors:["#f472b6","#e879f9","#c084fc","#a78bfa","#f9a8d4"],center:{sym:"O",num:"8"},cColor:"#ef4444",stemH:100,label:"Rosa Oksigenia"},
  {petals:["N","Si","P","S","Ar"],pColors:["#60a5fa","#34d399","#fbbf24","#f87171","#818cf8"],center:{sym:"C",num:"6"},cColor:"#374151",stemH:130,label:"Bunga Karbona"},
  {petals:["Ca","Mg","Fe","Cu","Zn"],pColors:["#fb923c","#4ade80","#f87171","#c084fc","#38bdf8"],center:{sym:"Au",num:"79"},cColor:"#d97706",stemH:110,label:"Chrysanthe-Mum"},
  {petals:["Na","K","Cl","Br","I"],pColors:["#a78bfa","#34d399","#fbbf24","#fb923c","#f472b6"],center:{sym:"Ag",num:"47"},cColor:"#64748b",stemH:90,label:"Halogenia"},
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
    center.innerHTML=`<span style="font-size:9px;line-height:1;text-align:center">${d.center.sym}<br><span style="font-size:7px">${d.center.num}</span></span>`;
    petalsDiv.appendChild(center);

    const sw=document.createElement('div');
    sw.className='stem-wrap';
    sw.style.height=d.stemH+'px';
    sw.innerHTML=`<div class="stem" style="height:${d.stemH}px"></div><div class="leaf leaf-l" style="--lr:-30deg"></div><div class="leaf leaf-r" style="--lr:30deg"></div>`;

    const lbl=document.createElement('div');
    lbl.style.cssText='font-family:Caveat,cursive;font-size:13px;color:#6d28d9;margin-top:4px;text-align:center';
    lbl.textContent=d.label;

    wrap.appendChild(petalsDiv);
    wrap.appendChild(sw);
    wrap.appendChild(lbl);
    row.appendChild(wrap);
  });
}

function buildStars(){
  const s=document.getElementById('stars');
  for(let i=0;i<20;i++){
    const el=document.createElement('div');
    el.className='star';
    el.style.left=Math.random()*100+'%';
    el.style.top=Math.random()*40+'%';
    el.style.animationDelay=Math.random()*3+'s';
    el.style.animationDuration=(2+Math.random()*3)+'s';
    el.style.background=['#f9a8d4','#c4b5fd','#bfdbfe','#a7f3d0'][Math.floor(Math.random()*4)];
    s.appendChild(el);
  }
}

function buildBubbles(){
  const b=document.getElementById('bubbles');
  for(let i=0;i<12;i++){
    const el=document.createElement('div');
    el.className='bubble';
    const sz=10+Math.random()*20;
    el.style.width=sz+'px';
    el.style.height=sz+'px';
    el.style.left=Math.random()*100+'%';
    el.style.animationDelay=Math.random()*6+'s';
    el.style.animationDuration=(4+Math.random()*4)+'s';
    b.appendChild(el);
  }
}

const periodicElements=[
  {sym:'H',num:1,name:'Keberanian',col:'#3b82f6'},
  {sym:'O',num:8,name:'Semangat',col:'#ef4444'},
  {sym:'C',num:6,name:'Kecerdasan',col:'#374151'},
  {sym:'N',num:7,name:'Kreativitas',col:'#8b5cf6'},
  {sym:'Fe',num:26,name:'Kekuatan',col:'#dc2626'},
  {sym:'Au',num:79,name:'Kemuliaan',col:'#d97706'},
  {sym:'Ag',num:47,name:'Kejujuran',col:'#64748b'},
  {sym:'Ca',num:20,name:'Keteguhan',col:'#f97316'},
  {sym:'K',num:19,name:'Kehangatan',col:'#7c3aed'},
  {sym:'Mg',num:12,name:'Kerendahan Hati',col:'#059669'},
  {sym:'P',num:15,name:'Kesabaran',col:'#ca8a04'},
  {sym:'S',num:16,name:'Bakat',col:'#eab308'},
];

function buildPeriodic(){
  const band=document.getElementById('periodicBand');
  periodicElements.forEach(e=>{
    const el=document.createElement('div');
    el.className='el';
    el.style.background=e.col;
    el.innerHTML=`<div class="el-tooltip">${e.name}</div><div class="el-sym">${e.sym}</div><div class="el-num">${e.num}</div>`;
    band.appendChild(el);
  });
}

function mixFlask(el,name,msg){
  document.getElementById('reactionMsg').textContent=msg;
  const sparkles=['✨','💜','⚡','🌸','💫','🎊'];
  for(let i=0;i<6;i++){
    const s=document.createElement('div');
    s.className='sparkle';
    s.style.cssText=`left:${el.getBoundingClientRect().left+Math.random()*40}px;top:${el.getBoundingClientRect().top-20+Math.random()*20}px;font-size:${16+Math.random()*14}px;animation-delay:${Math.random()*0.3}s;position:fixed`;
    s.textContent=sparkles[Math.floor(Math.random()*sparkles.length)];
    document.body.appendChild(s);
    setTimeout(()=>s.remove(),1200);
  }
  msgIdx=(msgIdx+1)%messages.length;
  setTimeout(()=>{
    document.getElementById('cardText').textContent=messages[msgIdx];
  },300);
}

buildStars();
buildBubbles();
buildFlowers();
buildPeriodic();