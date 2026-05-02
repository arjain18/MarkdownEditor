Overview
Markdown Editor is a lightweight, fast, and distraction‑free editor built with Windows Forms. It allows users to write Markdown content with a live HTML preview powered by the Markdig library. The editor is designed for everyday notes, README edits, and quick documentation.

✨ Features
🔖 Core Editing
Rich text box (rtbEditor) for writing Markdown.

Syntax‑agnostic editing surface with clean UI (custom background, no borders).

Automatic handling of indentation to prevent accidental code block rendering.

🌐 Live Preview
Real‑time HTML preview using Markdig’s advanced extensions.

Styled preview with modern CSS (cards, shadows, typography, code blocks, tables).

Preview updates automatically with debounce (via renderTimer).

External links open in the system’s default browser.

📂 File Management
New File: Start fresh with an untitled document.

Open File: Load existing .md files.

Save / Save As: Save changes with overwrite or new filename.

Tracks unsaved changes (isDirty) and prompts before closing or opening another file.

Welcome template shown on startup with sample Markdown.

🖥 UI & Usability
Adjustable window transparency via a slider (trkOpacity).

Status bar messages for user feedback (e.g., "Saved", "Preview updated").

Keyboard shortcuts:

Ctrl+N → New file

Ctrl+S → Save file

Toggle preview pane visibility with a button (Show/Hide Preview).
