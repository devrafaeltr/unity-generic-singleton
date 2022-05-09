[![GitHub](https://img.shields.io/github/license/devrafael-source/unity-generic-singleton)](https://github.com/devrafael-source/unity-generic-singleton/blob/master/LICENSE)
# unity-generic-singleton


___
## Getting started
### How to install:
1. Download from [Releases](https://github.com/devrafaeltr/unity-generic-singleton/releases/tag/v2).
2. Open your project, go to Assets > Import Package > Custom Package and choose the package OR double-click the package to import to the open project.

### How to use:
1. Go to the class that you want to be a singleton
2. Make it inherit from `LocalSingleton`, for scripts that live only in its scene, or `PersistentSingleton`, for scripts that persist through scenes, and pass the class itself as parameter:  `public class Example : LocalSingleton<Example>` .
3. Now, anywhere, you can call ```Example.Instance``` and access any public member.
4. (Optional) Change `SHOW_DEBUG` value to `true` if you want debugs showing when a event is registered, called, deleted, etc.

### Notes  
Let's call your script `Example`, that inherits from `LocalSingleton`;

1. If there is no `Example` in the current scene and some script is calling it, an empty `GameObject` will be created automatically and the `Example` component will be added to it.

2. If there is multiples `Example` in the current scene, the new on will be deleted and a `Debug.LogError` will be called. This can lead to some errors, take care.
