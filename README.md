[![GitHub](https://img.shields.io/github/license/devrafael-source/unity-generic-singleton)](https://github.com/devrafael-source/unity-generic-singleton/blob/master/LICENSE)
# unity-generic-singleton


___
## Getting started
### How to install:
1. Download and import to your project.
2. Done!

### How to use:
1. Go to the class that you want to be a singleton
2. Make it inherit from `LocalSingleton` or `PersistentSingleton` and pass the class itself as parameter:  `public class Example : LocalSingleton<Example>` .
3. Now, anywhere, you can call ```Example.Instance``` and access any public member.

### Notes  
Let's call your script `Example`, that inherits from `LocalSingleton`;

1. `LocalSingleton` inherits from `MonoBehaviour`, so it's needed to put `Example` in a gameobject. If you call `Example` somewhere will happen case 2.

2. If there is no `Example` in the current scene and some script is calling it, an empty `GameObject` will be created automatically and the `Example` component will be added to it.

3. If there is multiples `Example` in the current scene, a `Debug.LogError` will be called. This can lead to some errors, take care.
