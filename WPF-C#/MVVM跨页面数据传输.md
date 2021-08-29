# MVVM跨页面数据传输
<font color=#999AAA >提示：这里可以添加系列文章的所有文章的目录，目录需要自己手动添加
例如：第一章 Python 机器学习入门之pandas的使用
<hr style=" border:solid; width:100px; height:1px;" color=#000000 size=1">


<font color=#999AAA >提示：写完文章后，目录可以自动生成，如何生成可参考右边的帮助文档

@[TOC](文章目录)

</font>

<hr style=" border:solid; width:100px; height:1px;" color=#000000 size=1">

# 前言

<font color=#999AAA >在MVVM的架构下的项目中遇到一个功能需求，在当前控件页点击打开商品选择页面，从商品选择页面，选中特定商品后，点击确定后关闭当前页并回填选勾选的有关数据，效果主页面表格中出现已勾选的数据。
	操作逻辑如下：点击商品选择按钮，给商品选择按钮绑定打开相关窗口的命令，实例化商品选择窗口，DiningTable为委托，即在商品选择完成后点击确认关闭当前窗口时，通过使用委托进行控件页的数据刷新。
<hr style=" border:solid; width:100px; height:1px;" color=#000000 size=1">


# 一、pandas是什么？


<font color=#999AAA >示例：pandas 是基于NumPy 的一种工具，该工具是为了解决数据分析任务而创建的。



# 二、步骤
## 1.引入库


<font color=#999AAA >代码如下（示例）：



```c#
using BC2021.Model;
using BC2021.Model.Vos;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
```

## 2.读入数据

<font color=#999AAA >代码如下（示例）：



```c#
data = pd.read_csv(
    'https://labfile.oss.aliyuncs.com/courses/1283/adult.data.csv')
print(data.head())
```



<font color=#999AAA >该处使用的url网络请求的数据。

<hr style=" border:solid; width:100px; height:1px;" color=#000000 size=1">

# 总结
<font color=#999AAA >
以上就是今天要讲的内容，本文仅仅简单介绍了pandas的使用，而pandas提供了大量能使我们快速便捷地处理数据的函数和方法。


