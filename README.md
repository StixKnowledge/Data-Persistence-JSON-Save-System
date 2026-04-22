<img width="1580" height="867" alt="Screenshot 2026-04-22 133629" src="https://github.com/user-attachments/assets/9a6070e0-844a-4789-a4b1-51e4c4e9a7fd" />
<img width="681" height="430" alt="Screenshot 2026-04-22 133608" src="https://github.com/user-attachments/assets/ead76789-ea2e-4427-9099-ed5d3a1e9ddc" />

💾 Unity Data Persistence: JSON Save System
A Technical Exploration of Robust Game State Serialization

📖 Project Overview
This project serves as a comprehensive practice ground for implementing Data Persistence in Unity. The core objective was to create a system that ensures game progress (scenes, variables, and states) is reliably saved to and loaded from a local JSON file, even after the application is fully closed.

🛠️ The Persistence Architecture
The system is built on a clean, modular architecture to ensure scalability:

DataPersistenceManager: The "brain" of the system. It handles the Save/Load flow and ensures all game objects are synchronized.

FileDataHandler: Manages the actual I/O operations (reading and writing the .json files to the disk).

IDataPersistence (Interface): A custom interface that allows any script (like a player’s stats or inventory) to easily "subscribe" to the save system.

GameData: The data container class that defines exactly what variables are being saved.

SerializableDictionary: A custom utility to overcome Unity's limitation of not being able to see dictionaries in the inspector, allowing for more complex data storage.

🕹️ Gameplay & Mechanics
To test the architecture, I implemented a simple but effective game loop:

Coin Collection: Collect coins to increase your total count.

The "Red Plate" Hazard: Stepping on the red plate triggers a "Death Event," which increments your Death Count.

Persistence Logic: Both your Coin Total and Death Count are tracked and saved automatically.

📁 Main Menu Logic
The game features a fully functional Main Menu to manage the JSON lifecycle:

New Game: Triggers a fresh initialization, resetting the GameData to 0 coins and 0 deaths.

Load Game: Retrieves the existing JSON file from the local directory and restores the player's previous state.

🛠️ How to Use

Engine: Unity 

Storage Format: JSON (.json)

Workflow:

Open the project in Unity.

Add the DataPersistenceManager to your persistent scene.

Attach the IDataPersistence interface to any script you want to save.

View your saved data in the Application.persistentDataPath folder.
