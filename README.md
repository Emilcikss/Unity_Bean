<div align="center">

<h1>UNITY_BEAN MR. BĪNS + TV PROJEKTS</h1>
<p><b>Unity projekts, kas demonstrē UI sistēmas, interaktīvu TV ainu ar kanāliem, statiku, skaņām un mini-notikumiem, kā arī 2D “BeanRun” skrējiena ainu ar animācijām un fiziku.</b></p>

<p>
  <a href="#-quick-links">Quick Links</a> 
  <a href="#-preview">Preview</a> 
  <a href="#-features">Features</a> 
  <a href="#-tasks">Tasks</a> 
  <a href="#-setup--run">Setup</a>
  <a href="#-structure">Structure</a> 
  <a href="#-roadmap">Roadmap</a>
</p>

<br/>

<a href="https://github.com/Emilcikss/Unity_Bean/releases">
  <img alt="Download build" src="https://img.shields.io/badge/DOWNLOAD-LATEST_BUILD-111111?style=for-the-badge&logo=github&logoColor=white">
</a>
<a href="https://github.com/Emilcikss/Unity_Bean/archive/refs/heads/main.zip">
  <img alt="Download source" src="https://img.shields.io/badge/GET-SOURCE_ZIP-111111?style=for-the-badge&logo=git&logoColor=white">
</a>
<a href="https://github.com/Emilcikss/Unity_Bean/issues">
  <img alt="Report issue" src="https://img.shields.io/badge/REPORT-ISSUE-111111?style=for-the-badge&logo=githubissues&logoColor=white">
</a>

<br/><br/>

<img src="BANNER.png" alt="Banner" width="900">

</div>

<hr/>

<h2 id="-quick-links">◈ QUICK LINKS</h2>

<ul>
  <li><b>Releases (builds):</b> <a href="https://github.com/Emilcikss/Unity_Bean/releases">Download latest</a></li>
  <li><b>Source ZIP:</b> <a href="https://github.com/Emilcikss/Unity_Bean/archive/refs/heads/main.zip">Download source</a></li>
  <li><b>Scenes:</b> <a href="#-scenes">MainMenu / UI_scene / TV / RUN</a></li>
  <li><b>Tasks:</b> <a href="#-tasks">Done / In progress</a></li>
</ul>

<hr/>

<h2 id="-preview">◈ PREVIEW</h2>s
<ul>
  <li><b>TV:</b> kanāli + statika + skaņas + mini notikumi</li>
  <li><b>UI_scene:</b> UI demo ar vairākām komponentēm</li>
  <li><b>RUN (BeanRun):</b> 2D skrējiens ar animācijām, fiziku un platformām</li>
</ul>

<hr/>

<h2 id="-about">◈ ABOUT</h2>

<p>
Šis ir Mr. Bīna tēmas <b>Unity 6</b> projekts ar vairākām ainām:
</p>

<ul>
  <li><b>MainMenu</b> — galvenā izvēlne ar pārejām uz citām ainām + “Back to Menu” sistēma</li>
  <li><b>UI_scene</b> — UI elementu demonstrācija (ievade, teksti, toggles, slideri, dropdown, scroll)</li>
  <li><b>TV</b> — retro TV sistēma ar kanāliem, statiku, skaņām un interaktīviem objektiem</li>
  <li><b>RUN (BeanRun)</b> — 2D skrējiena aina ar platformām, animācijām (idle/walk/jump/fall) un fiziku</li>
</ul>

<hr/>

<h2 id="-scenes">◈ SCENES</h2>

<table>
  <tr>
    <td width="25%"><b>MainMenu</b><br/>Ieejas punkts, navigācija starp ainām + Exit.</td>
    <td width="25%"><b>UI_scene</b><br/>UI testēšana: ievade, toggles, slideri, dropdown, scroll, objekti.</td>
    <td width="25%"><b>TV</b><br/>Kanāli 1–3, OFF melnais ekrāns, statiska pāreja, skaņu kontrole, notikumi.</td>
    <td width="25%"><b>RUN</b><br/>2D kustība + lēciens + animācijas + platformas/zemes kolīzijas.</td>
  </tr>
</table>

<hr/>

<h2 id="-features">◈ FEATURES</h2>

<details open>
  <summary><b>TV sistēma</b></summary>
  <ul>
    <li>TV ON/OFF (OFF → melns ekrāns)</li>
    <li>Kanālu pārslēgšana (1–3)</li>
    <li>Statisks “no signal” efekts pārslēgšanas laikā</li>
    <li>Statiska skaņa (loop) ar fade in/out</li>
    <li>Skaļuma slīdnis (global volume)</li>
    <li>Klikšķu skaņas uz ekrāna objektiem</li>
    <li>Kanāla notikumi (piem., “Car Chaos” + Bean kritiens) ar stāvokli</li>
  </ul>
</details>

<details open>
  <summary><b>UI demonstrācija</b></summary>
  <ul>
    <li>InputField + poga (Get Name)</li>
    <li>Checkbox / Toggle grupas (personāži)</li>
    <li>Slideri (izmērs / rotācija)</li>
    <li>Dropdown / ScrollView</li>
    <li>Vienkārša interakcija ar elementiem + SFX</li>
  </ul>
</details>

<details open>
  <summary><b>RUN (BeanRun) sistēma</b></summary>
  <ul>
    <li>2D kustība pa X (pa kreisi/pa labi)</li>
    <li>Lēciens (Space)</li>
    <li>GroundCheck ar LayerMask (Ground)</li>
    <li>Animācijas: Idle / Walk / Jump / Fall (Animator Controller)</li>
    <li>Flip bez scale laušanas (SpriteRenderer.flipX)</li>
    <li>Platformas/zemes kolīzijas (Collider2D + Rigidbody2D)</li>
  </ul>
</details>

<hr/>

<h2 id="-controls">◈ CONTROLS</h2>

<ul>
  <li><b>A / D</b> vai <b>← / →</b> — kustība (RUN)</li>
  <li><b>Space</b> — lēciens (RUN)</li>
  <li><b>MainMenu pogas</b> — pārejas uz TV / UI / RUN</li>
  <li><b>Back</b> — atgriezties uz MainMenu (katrai ainai)</li>
</ul>

<hr/>

<h2 id="-tasks">◈ TASKS</h2>

<p><b>Statuss:</b> UI + TV + RUN pamats ir gatavs, turpinās polish un final build.</p>

<table>
  <tr>
    <td width="50%">
      <b>▣ Izpildīts</b>
      <ul>
        <li>[x] UI Button, Text, Image</li>
        <li>[x] Input Field</li>
        <li>[x] Toggle / “Radio” loģika</li>
        <li>[x] Slider (skaļums + UI demo)</li>
        <li>[x] Dropdown + ScrollView (UI_scene)</li>
        <li>[x] Drag & Drop (UI demo)</li>
        <li>[x] AudioSource + SFX sistēma</li>
        <li>[x] MainMenu aina + pārejas uz scenām</li>
        <li>[x] TV aina: ON/OFF + 3 kanāli</li>
        <li>[x] Statisks overlay + statiska skaņa (fade)</li>
        <li>[x] Klikšķu interakcija kanālos</li>
        <li>[x] RUN aina: kustība + lēciens + platformas</li>
        <li>[x] Rigidbody2D + Collider2D (RUN)</li>
        <li>[x] Animator: Idle/Walk/Jump/Fall + Speed/Grounded/YVel</li>
      </ul>
    </td>
    <td width="50%">
      <b>▣ Nav izdarīts / Nākamais</b>
      <ul>
        <li>[ ] Windows build sagatavošana (final export + release)</li>
        <li>[ ] Virtuļu ķeršanas mini-spēle (integrācija)</li>
        <li>[ ] TV pogu animācijas (press/scale)</li>
        <li>[ ] CRT efekts (scanlines/vignette)</li>
        <li>[ ] Papildu kanālu “mini-notikumi”</li>
        <li>[ ] RUN: kamera follow + vienkāršs score / distance</li>
      </ul>
    </td>
  </tr>
</table>

<hr/>

<h2 id="-setup--run">◈ SETUP & RUN</h2>

<details open>
  <summary><b>Atvērt projektā (Unity Hub)</b></summary>
  <ol>
    <li>Clone repo vai lejupielādē ZIP</li>
    <li>Unity Hub → <b>Add</b> → izvēlies projekta mapi</li>
    <li>Atver ar <b>Unity 6</b></li>
    <li>Atver ainu: <code>Assets/Scenes/MainMenu.unity</code></li>
    <li>▶ Play</li>
  </ol>
</details>

<details>
  <summary><b>Build (Windows)</b></summary>
  <ol>
    <li><code>File → Build Settings</code></li>
    <li><b>Windows, Mac, Linux</b> → Target: <b>Windows</b></li>
    <li><b>Add Open Scenes</b> (MainMenu / UI_scene / TV / RUN)</li>
    <li><b>Build</b></li>
  </ol>
</details>
<hr/>

<h2 id="-roadmap">◈ ROADMAP (mazs, bet jaudīgs)</h2>

<ul>
  <li>▣ Final Windows build + Release</li>
  <li>▣ CRT vizuālais slānis (scanlines) + TV ieslēgšanas animācija</li>
  <li>▣ TV un UI polish (pogām animācijas + mikro skaņas)</li>
  <li>▣ RUN: distance/score + kamera follow</li>
  <li>▣ Integrēt virtuļu mini-spēli</li>
</ul>

<hr/>

<h2 id="-credits">◈ CREDITS</h2>

<ul>
  <li><b>Dev:</b> Emilcikss</li>
  <li><b>Engine:</b> Unity 6</li>
  <li><b>Theme:</b> Mr. Bean (fan project / educational UI demo)</li>
</ul>

<div align="center">
  <br/>
  <a href="https://github.com/Emilcikss/Unity_Bean/releases">
    <img alt="Download" src="https://img.shields.io/badge/GET-LATEST_BUILD-111111?style=for-the-badge&logo=github&logoColor=white">
  </a>
  <br/><br/>
</div>
