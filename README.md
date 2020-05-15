# unity-generic-singleton


___
## Getting started
### How to install:
1. Download and import to your project.
2. Done!

### How to use:
1. Go to the class that you want to be a single
2. Make it inherit from `Singleton` and pass the class itself as parameter:  `public class Example : Singleton<Example>` .
3. Now, anywhere, you can call ```Example.Instance``` and access any public member.

### Notes  
Let's call your script `Example`.

`Singleton` inherits from `MonoBehaviour`, so it's needed to put `Example`, that inherits from `Singleton`, in a gameobject.

If there is no `Example` in the current scene, a new empty `GameObject` will be created automatically and the `Example` component will be added to it.

If there is multiples `Example` in the current scene, a `Debug.LogError` will be called, because this can lead to some errors. Pay attention.
