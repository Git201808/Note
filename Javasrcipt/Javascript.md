# Javascript

## 1、变量，（保留）关键字，标识符

#### JavaScript保留关键字

| **abstract** | **arguments** | **boolean** | **break** | **byte**     |
| ------------ | ------------- | ----------- | --------- | ------------ |
| case         | catch         | char        | class     | const        |
| continue     | debugger      | default     | delete    | do           |
| double       | else          | enum        | eval      | export       |
| extends      | false         | final       | finally   | float        |
| for          | function      | goto        | if        | implements   |
| import       | in            | instanceof  | int       | interface    |
| let          | long          | native      | new       | null         |
| package      | private       | protected   | public    | return       |
| short        | static        | super       | switch    | synchronized |
| this         | throw         | throws      | transient | true         |
| try          | typeof        | var         | void      | volatile     |
| while        | with          | yield       |           |              |

#### 变量的作用域和生命周期

##### 变量按作用域和生命周期

- 局部变量

  在函数内声明的变量

- 全局变量

  在函数外声明的变量是全局变量

##### 生命周期

JavaScript 变量的生命期从它们被声明的时间开始。 

局部变量会在函数运行以后被删除。 

全局变量会在页面关闭后被删除。 

## 2、数据类型

|      | 类型       | 说明                                   |
| ---- | ---------- | -------------------------------------- |
| 1    | String     | 字符串("字符串" & '字符串')            |
| 2    | Number     | 数字(int/short/long/float/doublefload) |
| 3    | Boolean    | 布尔 (ture & false)                    |
| 4    | Object     | 对象 (Object)                          |
| 5    | Null       | 空                                     |
| 6    | underfined | 末定义                                 |
|      | Array      | 数组：特殊                             |

## 3、操作符

### 1、算术运算符

| **运算符** | **描述**     | **例子**         |
| ---------- | ------------ | ---------------- |
| \+         | 加法         | x=y+2            |
| -          | 减法         | x=y-2            |
| *          | 乘法         | x=y*2            |
| /          | 除法         | x=y/2            |
| %          | 取模（余数） | x=y%2            |
| ++         | 自增         | x=++y 或者 x=y++ |
| --         | 自减         | x=­­y 或者 x=y­­ |



### 2、赋值运算符

| 运算符 | 例子 | 等同于 |
| ------ | ---- | ------ |
| =      | x=y  |        |
| +=     | x+=y | x=x+y  |
| -=     | x-=y | x=x-y  |
| *=     | x*=y | x=x*y  |
| /=     | x/=y | x=x/y  |
| %=     | x%=y | x=x%y  |

### 3、比较运算符

| 运算符 | 描述       | 例子  |
| ------ | ---------- | ----- |
| ==     | 等于       | x==y  |
| ===    | 绝对等于   | x===y |
| !=     | 不等于     | x!=y  |
| !==    | 绝对不等于 | x!==y |
| >      | 大于       | x>y   |
| >=     | 大于等于   | x>=y  |
| <      | 小于       | x<y   |
| <=     | 小于等于   | x<=y  |

### 4、逻辑运算符

| 运算符 | 描述   | 例子              |
| ------ | ------ | ----------------- |
| &&     | and 与 | (x>10 && y>1)     |
| \|\|   | or 或  | (x== 5 \|\| y==5) |
| !      | not 非 | !(x ==y)          |



## 4、分支语句

if语句

``` javascript
if(age > 18){
    console.log("成年人")
}
```

if ... else... 语句

``` javascript
if(a>0){
    console.log("a")
}else{
    console.log("a<0")
}
```

if ... else if... 语句

``` javascript
if(age < 16){
    console.log("儿童")
}else if(age < 18){
    console.log("末成年人")
}else{
    console.log("成年人")
}
```

switch 语句

``` javascript
switch(表达式) 
{ 
    case 表达式值1: 语句块1; 
        break; 
        .... 
    case 表达式N: 语句块N; 
        break; 
    default： 
    语句块; break; 
}
```



## 5、循环语句

for 

``` javascript
for(int i;i<5;i++){
    循环体;
}
```



for in 

``` javascript
for(x in object){
    循环体; 
    console.log(object[x]);
}
```



while

``` javascript
while( x > 1){
      循环体;
}
```



do while

``` javascript
do{
    循环体;
}
while(条件);
```

break 语句用于跳出循环。 

continue 用于跳过循环中的一次迭代。 



## 6、输出与交互

|     **方法**     |                         作用                          |
| :--------------: | :---------------------------------------------------: |
| document.write() |                 向HTML文档中输出内容                  |
|  console.log()   |                  写到浏览器的控制台                   |
|  window.alert()  |                      弹出提示框                       |
| window.confirm() |      弹出消息对话框通常用于允许用户做选择的动作       |
| window.prompt()  | 弹出消息对话框,通常用于询问一些需要与用户交互的信息。 |



## 7、函数



``` javascript
function 函数名([参数1，参数2,...]){
    代码块;
    [return [变量];]
}
```

**JavaScript 对大小写敏感。**

**关键词 function 必须是小写的，并且必须以与函数名称相同的大小写来调用函数。** 

- 没有参数也没有返回值的函数

  ``` javascript
  //=======没有参数也没有返回值的函数 
  //定义函数 
  function funName1() 
  { 
      console.log("函数funName1没有参数也没有返回值。"); 
  }
  //调用行数 
  funName1();
  ```

  

- 有参数没有返回值的函数

  ``` javascript
  //========有参数没有返回值的函数 
  //定义函数 JavaScript函数的形参不需要指定类型，也不需要用var声明 
  function funName2(param1) 
  { 
      console.log("函数funName2有参数,没有返回值。funName2的参数param1的值 是："); 
      console.log(param1); 
  }
  //调用函数 
  funName2(1); 
  funName2("字符串"); 
  funName2(new Date()); 
  //Date对象在第二天的详细学习
  ```

  

- 没有参数有返回值的函数

  ``` javascript
  //======没有参数有返回值的函数 
  //定义函数 
  function funName3() 
  { return "函数funName1没有参数有返回值。"; 
  }
  //调用函数 
  var a = funName3(); 
  console.log(a);
  ```

  

- 有参数有返回值的函数

  ``` javascript
  //=======有参数有返回值的函数 
  //定义函数 
  function add(num1, num2) 
  { 
      return num1 + num2; 
  }
  //调用函数 
  var b = add(5, 6); 
  console.log(b);
  ```

  

## 8、事件

| **事件**    | **描述**                     |
| ----------- | ---------------------------- |
| onchange    | HTML 元素改变                |
| onclick     | 用户点击 HTML 元素           |
| onmouseover | 用户在一个HTML元素上移动鼠标 |
| onmouseout  | 用户从一个HTML元素上移开鼠标 |
| onkeydown   | 用户按下键盘按键             |
| onload      | 浏览器已完成页面的加载       |
|             |                              |

### 事件的三种写法

#### 1、在DOM元素中直接绑定

``` html
<button onclick="btnClick()">
    按钮1
</button>
<button onclick='btnClick()'>
    按钮2
</button>
```

#### 2、在JavaScript代码中绑定

``` javascript
var btn2 = document.getElementById("btn3");
btn.onclick = function(){
    alert("在JavaScript代码中绑定");
}
```

#### 3、使用事件监听绑定事件

！ 不常用

- 添加监听

  element.addEventListener(event,function,useCapture)

  event:(必须)事件名，支持所有DOM事件。

  function:(必须) 指定要事件触发时执行的函数。

  useCapture: (可选)指定事件是否在捕获或冒泡阶段执行

  false，冒泡。默认false，不写默认false

- 移除监听

  （参数必须和添加时一致时才可以移除）

  element.removeEventListener(event,function,useCapture)



``` javascript
//获取元素 
var btn4=document.getElementById("btn4"); 
//函数
function btnClick2()
{ 
    alert("使用事件监听绑定事件"); 
}
//添加监听到点击时执行btnclick2的方法 
btn4.addEventListener("click",btnClick2,false); 
//移除监听，再次被点击时执行btnclick2的方法 
btn4.removeEventListener("click",btnClick2,false);
```

