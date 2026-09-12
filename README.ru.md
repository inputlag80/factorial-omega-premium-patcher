<h1 align="center">🛠️ Автопатчер премиум-читов Factorial Omega</h1>
<p align="center"><b>Версия 0.97.11</b></p>

<p align="center">
  <a href="README.md"><img src="https://img.shields.io/badge/🇬🇧_English-inactive-gray?style=for-the-badge" alt="English"></a>
  <a href="README.ru.md"><img src="https://img.shields.io/badge/🇷🇺_Русский-active-blue?style=for-the-badge" alt="Русский"></a>
</p>

---

Универсальный лёгкий автопатчер исходников для **!Ω Factorial Omega: My Dystopian Robot Girlfriend**.
Обходит RSA-проверку кода и локально открывает премиум-уровни читов.

---

### ✨ Особенности

- **Микро-размер** — скомпилированный файл весит всего **~6 КБ**.
- **Безопасность** — автоматически создаёт резервную копию оригинала (`GameAssembly.dll.bak`).
- **Контроль процессов** — не даст запустить патч и сломать файлы, если игра включена.

---

### 🚀 Инструкция по установке

1. Закиньте готовый файл `patcher.exe` в корневую папку игры (туда, где лежит `My Dystopian Robot Girlfriend.exe`).
2. Убедитесь, что игра в этот момент полностью закрыта.
3. Запустите патчер. Он применит изменения за долю секунды и сам закроется в случае успеха.
4. Включайте игру и заходите в меню читов — админка полностью разблокирована!

---

### 💻 Самостоятельная компиляция из исходника

Ставить сторонний софт не нужно — в Windows уже встроен компилятор C#.
Откройте PowerShell в папке с файлом `patcher.cs` и выполните:

```powershell
& "$env:SystemRoot\Microsoft.NET\Framework64\v4.0.30319\csc.exe" /target:exe /out:patcher.exe patcher.cs
