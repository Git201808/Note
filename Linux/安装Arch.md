入邪教啦
2.分区：(我使用fdisk分区工具)
输入：fdisk /dev/sda
我们输入：n （进行新建分区
然后输入:p
然后输入：1
然后直接回车，进入以下界面
接着输入：+200M（我是先分/boot分区）回车

3.格式化分区：
mkfs.ext4 /dev/sda1
mkfs.ext4 /dev/sda3
mkfs.ext4 /dev/sda4
(我的第二分区时交换分区，等下要格为交换分区，所以这里不格）

格交换分区：
mkswap /dev/sda2
启动交换分区
swapon /dev/sda2

vi /etc/pacman.d/mirrorlist

pacstrap -i /mnt base   安装基本系统