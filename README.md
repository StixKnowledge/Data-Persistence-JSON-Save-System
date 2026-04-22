<img width="1580" height="867" alt="Screenshot 2026-04-22 133629" src="https://github.com/user-attachments/assets/9a6070e0-844a-4789-a4b1-51e4c4e9a7fd" />
<img width="681" height="430" alt="Screenshot 2026-04-22 133608" src="https://github.com/user-attachments/assets/ead76789-ea2e-4427-9099-ed5d3a1e9ddc" />

💾 Unity Data Persistence: Secure JSON Save System
A Modular Architecture for Persistent & Encrypted Game States

📖 Project Overview

This project is an advanced exploration of Data Persistence in Unity. While the core objective is to save and load game states (scenes, variables, and progress), this introduces a Security Layer to prevent "Save File Editing" and cheating.

A robust Technical Framework designed to handle complex game states in Unity. By combining JSON Serialization with a custom XOR Encryption layer, it provides a secure and developer-friendly way to manage data. The system is built using the Interface Pattern, making it completely decoupled—meaning you can add "Save/Load" functionality to any script with just one line of code.

🛡️ Security & Encryption
To protect the integrity of the game data, I implemented an XOR-based Encryption System.

Toggleable Security: The DataPersistenceManager includes a boolean toggle. You can choose to save in Plain JSON (for debugging) or Encrypted Format (for production).

Anti-Cheat: When encryption is enabled, the .json file becomes unreadable to humans. If a player tries to modify their coin count or death toll in a text editor, the file will remain protected.

Serialization: The system converts complex C# objects into structured JSON strings before the encryption layer processes them for disk storage.

🕹️ Gameplay & Mechanics
Seamless Auto-Save: The game utilizes OnApplicationQuit to automatically save your progress.

Persistent Stats: Tracks Coin Collection and Death Counts (triggered by the "Red Plate" hazard).

Main Menu Logic: * New Game: Wipes the existing JSON to start fresh.

Load Game: Decrypts and deserializes the saved data to restore the session.

🛠️ The Persistence Architecture
DataPersistenceManager: The central hub that triggers saves and loads.

FileDataHandler: Handles the I/O and contains the Encryption/Decryption logic.

IDataPersistence: An interface that allows any script to become "save-aware" with zero friction.

SerializableDictionary: A utility class that enables Unity to save and display Dictionaries—something it cannot do by default.

📁 Technical Note: Save Location
The data is stored at Application.persistentDataPath. Even when encrypted, the file remains lightweight and efficient.

🛠️ How to Use
Engine: Unity

Storage Format: JSON (.json)

Workflow:

Open the project in Unity.

Add the DataPersistenceManager to your persistent scene.

Attach the IDataPersistence interface to any script you want to save.

View your saved data in the Application.persistentDataPath folder.

Credits: YOUTUBE UNIVERSITY
