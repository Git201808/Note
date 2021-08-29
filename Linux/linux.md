ls---->显示当前路径下的文件以及文件夹的名字

pwd-->显示当前正在操作的路径
/  根目录，类似于windows中c或者d
/home/python ----> 根路径下的  home文件下的python文件夹
/ 斜杠
\ 反斜杠  \n
| 竖杠
- 横杠
_ 下划线

touch 文件夹 ---> 创建一个文件
touch 1.txt

cd 路径 --->跳转到某个路径
cd DeskTop --->如果当期路径下有Desktop文件夹，那么就跳转到里面

mkdir 文件夹的名字  ---> 创建一个文件夹
mkdir ---> 当期路径下创建一个 laowang文件夹

tab键 自动补全

cd .. 跳到上一层路径 每两个点代表一次返回上一层路径
    . 一个点代表当前路径
cd ./DeskTop 跳转当前路径下的DeskTop文件夹中
cd - 跳到上一次所在的路径（回看）

clear 清屏

命令的顺序要求：显示linux命令，然后在根据这个命令是否需要参数或者选项进行添加，但是选项和参数一般情况下没有先后顺序

删除-- remove
rm 文件或者文件的名字 ---> 删除文件或文件夹
如果是文件夹，那么需要添加-r

拷贝 -- copy
cp movies/ data -r  --- 拷贝

粘贴 --move
mv hello.txt music/

重命名
mv data/ xxx   xxx不存在便是重命名

tree -- 以目录树的形式显示文件结构  sudo apt-get install tree

相对路径：
绝对路径：

帮助信息
命令名 --help  ---长格式 短格式为单个-h
man 命令名 有问题找男人

重定向 >
一个 > 如果文件存在，那么内容会被覆盖 >> 如果存在，那么内容会被追加
 ls > 文件名 将当前文件重定向到指定文件中去
 ls / > file_names.txt  --- 将根目录下的文件重定向到文本命名为flies的文件中去

查看文件 gedit file_names.txt    查看定向文件


查看文件
cat显示文件里的内容 cat 文件名 -- 直接显示完

more更多 more 文件名   -- 逐步显示

tree /home/python/ | more 显示一个目录树的内容

管道 | 特殊的文件

创建链接文件 ln -- link的意思

linux 文件后缀不严格要求