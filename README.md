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
