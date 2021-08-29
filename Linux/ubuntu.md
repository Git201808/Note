apt 

# 1. 安装软件
sudo apt install 软件名

# 2. 卸载软件
sudo apt remove 软件名

# 3. 更新软件包列表
sudo apt update

# 4. 更新已安装的包
sudo apt upgrade

# 安装常用工具

python 程序员

sudo apt install ipython
sudo apt install ipython3
sudo apt install python-pip
sudo apt install python3-pip

C++ 程序员

sudo apt install cmake
sudo apt install qicreator

ruby 程序员

sudo apt install ruby

安装ssh 服务器

sudo apt install openssh-server

# 卸载不常用的软件
libreoffice

sudo apt remove libreoffice-common

Amazon

sudo apt remove unity-webapps-common

# 找到我们所需要的软件

# deb 安装格式

sudo dpkg -i 安装包的名称

安装chrome

sudo apt install libappindicator1 libindicator7
sudo dpkg -i google-chrome-stable_current_and64.deb
sudo apt -f install 修复依赖关系

搜狗输人法
sudo dpkg -i sogoupinyin_2.1.0086_amd64.deb
sudo apt -f install