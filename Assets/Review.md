# My evaluation after completing the project:
- Advantages:
  - The project is well organized and straight forward.
  - The design is suitable for the project's scope.
  - Can be expanded in the future.

However, I still think there are still rooms for improvement 
- Disadvantages:
  - I think some classes has too much responsibility on their own and should be divided into smaller components.
  - The UIMainManager can directly call functions from GameManager, this wires them together and I suggest using Observer pattern to handle events between UI and game play.
  - There are some parts in the script that use Action delegate but forget to clear it when it's no longer needed.
  - Use switch case to work with prefab names is not ideal when the project grows bigger. And the only thing that distinguish different Normal items is just the sprite, so I suggest using variable prefabs or maybe use one prefab only as we can set the prefab's properties in script when initializing.
 