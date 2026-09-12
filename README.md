<h1 align="center">🛠️ Factorial Omega Premium Cheats Auto-Patcher</h1>
<p align="center"><b>Version 0.97.11</b></p>

<p align="center">
  <a href="README.md"><img src="https://img.shields.io/badge/🇬🇧_English-active-blue?style=for-the-badge" alt="English"></a>
  <a href="README.ru.md"><img src="https://img.shields.io/badge/🇷🇺_Русский-inactive-gray?style=for-the-badge" alt="Русский"></a>
</p>

---

Universal lightweight source-code auto-patcher for **!Ω Factorial Omega: My Dystopian Robot Girlfriend**.
Bypasses RSA code verification and unlocks premium cheat tiers locally.

---

### ✨ Features

- **Micro-size** — the compiled binary takes only **~6 KB**.
- **Safe** — automatically creates a backup of the original file (`GameAssembly.dll.bak`).
- **Process check** — prevents file corruption by verifying the game is not running.

---

### 🚀 How to Use

1. Download **`patcher_en.exe`** from this repository.
2. Place it into the game root folder (next to `My Dystopian Robot Girlfriend.exe`).
3. Make sure the game is fully closed.
4. Run the patcher. It applies the patch in under a second and closes automatically on success.
5. Launch the game and open the cheat menu — the developer/admin panel is fully unlocked.

---

### 💻 How to Compile from Source

Windows already ships with a built-in C# compiler — no extra software needed.
Open PowerShell in the folder containing `patcher_en.cs` and run:

```powershell
& "$env:SystemRoot\Microsoft.NET\Framework64\v4.0.30319\csc.exe" /target:exe /out:patcher_en.exe patcher_en.cs
