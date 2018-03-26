井字棋csdn博客：https://blog.csdn.net/lyn_b/article/details/79706644  
对象树  
GameController  
  ChessTable  
    grid  
    ...  

  ChessUI是挂在GameController上，用来生成游戏的UI界面，发送游戏开始的message  
  Game脚本挂在ChessTable上，相当于游戏的观察者，里面主要记录了当前棋盘的状态，判断游戏是否结束，并且生成游戏结束的界面，同时根据底下传来的信息判断是否生成棋子，及棋子的样式。  
  gridAction是挂在grid上的脚本，触发鼠标事件的句柄，根据鼠标事件改变grid的样式( OnMouseEnter )，触发点击事件向ChessTable发送信息  
