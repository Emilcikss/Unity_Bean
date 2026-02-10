<div align="center">

<h1>UNITY_BEAN ▣ MR. BĪNS UI + TV PROJECT</h1>
<p><b>Unity 6 projekts, kas demonstrē UI sistēmas, interaktīvu TV ainu ar kanāliem, statiku, skaņām un mini-notikumiem.</b></p>

<p>
  <a href="#-quick-links">Quick Links</a> ▣
  <a href="#-preview">Preview</a> ▣
  <a href="#-features">Features</a> ▣
  <a href="#-tasks">Tasks</a> ▣
  <a href="#-setup--run">Setup</a> ▣
  <a href="#-structure">Structure</a> ▣
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

<img alt="Unity" src="https://img.shields.io/badge/ENGINE-UNITY_6-0b0b0b?style=flat-square&logo=unity&logoColor=white">
<img alt="Platform" src="https://img.shields.io/badge/PLATFORM-WINDOWS-0b0b0b?style=flat-square&logo=windows&logoColor=white">
<img alt="Scenes" src="https://img.shields.io/badge/SCENES-MAINMENU_%7C_UI_%7C_TV-0b0b0b?style=flat-square&logo=buffer&logoColor=white">
<img alt="Focus" src="https://img.shields.io/badge/FOCUS-UI%20%7C%20SFX%20%7C%20STATE-0b0b0b?style=flat-square">

<br/><br/>

<img src="Docs/banner_main.png" alt="Banner" width="900">

</div>

<hr/>

<h2 id="-quick-links">◈ QUICK LINKS</h2>

<ul>
  <li><b>Releases (builds):</b> <a href="https://github.com/Emilcikss/Unity_Bean/releases">Download latest</a></li>
  <li><b>Source ZIP:</b> <a href="https://github.com/Emilcikss/Unity_Bean/archive/refs/heads/main.zip">Download source</a></li>
  <li><b>Scenes:</b> <a href="#-scenes">MainMenu / UI_scene / TV</a></li>
  <li><b>Tasks:</b> <a href="#-tasks">Done / In progress</a></li>
</ul>

<hr/>

<h2 id="-preview">◈ PREVIEW</h2>

<table>
  <tr>
    <td align="center"><b>TV Scene</b><br/><img src="Docs/preview_tv.png" width="420" alt="TV Preview"></td>
    <td align="center"><b>UI Scene</b><br/><img src="Docs/preview_ui.png" width="420" alt="UI Preview"></td>
  </tr>
  <tr>
    <td align="center"><b>Static + Channel switch</b><br/><img src="Docs/preview_switch.gif" width="420" alt="Switch Preview"></td>
    <td align="center"><b>Car Chaos event</b><br/><img src="Docs/preview_channel2.gif" width="420" alt="Car Chaos Preview"></td>
  </tr>
</table>

<p><i>Tip:</i> Ieliec bildes/GIF mapē <code>Docs/</code> ar tiem pašiem nosaukumiem.</p>

<hr/>

<h2 id="-about">◈ ABOUT</h2>

<p>
Šis ir Mr. Bīna tēmas <b>Unity 6</b> projekts ar vairākām ainām:
</p>

<ul>
  <li><b>MainMenu</b> — vienkārša izvēlne, pāreja uz pārējām ainām</li>
  <li><b>UI_scene</b> — UI elementu demonstrācija (ievade, teksti, toggles, slideri, dropdown, scroll)</li>
  <li><b>TV</b> — retro TV sistēma ar kanāliem, statiku, skaņām un interaktīviem objektiem</li>
</ul>

<hr/>

<h2 id="-scenes">◈ SCENES</h2>

<table>
  <tr>
    <td width="33%"><b>MainMenu</b><br/>Ieejas punkts, navigācija starp ainām.</td>
    <td width="33%"><b>UI_scene</b><br/>UI testēšana: ievade, toggles, slideri, dropdown, scroll, objekti.</td>
    <td width="33%"><b>TV</b><br/>Kanāli 1–3, OFF melnais ekrāns, statiska pāreja, skaņu kontrole, notikumi.</td>
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
    <li>Vienkārša interakcija ar elementiem</li>
  </ul>
</details>

<hr/>

<h2 id="-tasks">◈ TASKS</h2>

<p><b>Statuss:</b> izdarīts pamats + TV sistēma, turpinās polish un build.</p>

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
        <li>[x] MainMenu aina</li>
        <li>[x] TV aina: ON/OFF + 3 kanāli</li>
        <li>[x] Statisks overlay + statiska skaņa (fade)</li>
        <li>[x] Klikšķu interakcija kanālos</li>
        <li>[x] Notikuma stāvoklis (CarChaos) + saglabāšana (opc.)</li>
      </ul>
    </td>
    <td width="50%">
      <b>▣ Nav izdarīts / Nākamais</b>
      <ul>
        <li>[ ] Rigidbody + Collider (fizika)</li>
        <li>[ ] Windows build sagatavošana (final export)</li>
        <li>[ ] Virtuļu ķeršanas mini-spēle (integrācija)</li>
        <li>[ ] TV pogu animācijas (press/scale)</li>
        <li>[ ] CRT efekts (scanlines/vignette)</li>
        <li>[ ] Papildu kanālu “mini-notikumi”</li>
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
    <li>Atver ainu: <code>Assets/Scenes/MainMenu.unity</code> vai <code>TV.unity</code></li>
    <li>▶ Play</li>
  </ol>
</details>

<details>
  <summary><b>Build (Windows)</b></summary>
  <ol>
    <li><code>File → Build Settings</code></li>
    <li><b>Windows, Mac, Linux</b> → Target: <b>Windows</b></li>
    <li><b>Add Open Scenes</b></li>
    <li><b>Build</b></li>
  </ol>
</details>

<hr/>

<h2 id="-structure">◈ PROJECT STRUCTURE</h2>

<pre>
Assets/
  Scenes/
    MainMenu.unity
    UI_scene.unity
    TV.unity
  Scripts/
    TV/
  Images/
  Sounds/ (vai sfx/)
  Fonts/
Docs/
  banner_main.png
  preview_tv.png
  preview_ui.png
  preview_switch.gif
  preview_channel2.gif
</pre>

<hr/>

<h2 id="-roadmap">◈ ROADMAP (mazs, bet jaudīgs)</h2>

<ul>
  <li>▣ Integrēt virtuļu mini-spēli TV kanālā</li>
  <li>▣ UI polish: pogu animācijas + skaņas mikro-detaļas</li>
  <li>▣ CRT vizuālais slānis (scanlines) + TV ieslēgšanas animācija</li>
  <li>▣ Final Windows build + Release</li>
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
