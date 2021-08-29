

分区
fdisk /dev/sda
o
n
p
22900200
n
p
w
查看分区刷新信息
cat /proc/partitions

格式化盘
mkfs.ext4 /dev/sda2
mkswap /dev/sda1



mount /dev/sda2 /mnt
wget -O /etc/pacman.d/mirrorlist "https://www.archlinux.org/mirrorlist/?country=CN&protocol=http&protocol=https&ip_version=4"
cat /etc/pacman.d/mirrorlist
sed -i "s/#Server/Server/g" /etc/pacman.d/mirrorlist

原同步
pacman -Syy

安装基础系统
pacstrap /mnt base base-devel

生成fstab
genfstab -U -p /mnt >> /mnt/etc/fstab

回主目录
arch-chroot /mnt /bin/bash
arch-chroot /mnt

设置语言环境
vi /etc/locale.conf

设置时间(时序
ln -fs /usr/share/zoneinfo/Asia/Shanghai /etc/localtime
同步
#hwclock --systohc
date -R看时间
入过/etc/localtime文件存在就先删除再执行
hwclock --systohc --utc

语言环境配置
vi /etc/locale.gen
locale-gen
echo "LANG=en.UTF-8" > /etc/locale.conf

网络主机名
echo "arch" > /etc/hostname
vi /etc/hostname

给root设置密码
passwd

创建普通用户
useradd -m -G wleel bing
passwd bing
bing520