## 0x001 - Singleton

### Description

The code provided here demonstrates the implementation of the Singleton design pattern in C#. The Singleton pattern ensures that a class has only one instance and provides a global point of access to that instance. This is achieved by making the constructor of the class private and providing a static method to obtain the single instance of the class.

### Implementation

- The `ConfigManager` class is designed as a Singleton, with the following characteristics:
  - It has a private, static `instance` field to hold the single instance of the `ConfigManager` class.
  - The constructor of `ConfigManager` is private, preventing external instantiation.
  - The `settings` field is a `Dictionary` used to store configuration settings as key-value pairs.

- The `GetInstance` method is a static method used to obtain the single instance of the `ConfigManager`. It checks whether an instance already exists and creates one if it doesn't.

- The `GetSetting` method allows you to retrieve a specific configuration setting by providing a key. It checks if the key exists in the `settings` dictionary and returns the corresponding value.

- The `SetSetting` method allows you to set or update a configuration setting. If the key exists in the `settings` dictionary, it updates the value; otherwise, it adds a new key-value pair.

### Usage Example

The `Program` class demonstrates how to use the `ConfigManager` Singleton to manage configuration settings. In the `Main` method:

1. An instance of `ConfigManager` is obtained using `ConfigManager.GetInstance()`, ensuring that only one instance is created.

2. Configuration settings, such as "FontSize" and "Theme," are set using the `SetSetting` method.

3. These settings are then retrieved using the `GetSetting` method.

4. Finally, the retrieved settings are printed to the console.

### Output

The code will produce the following output:

