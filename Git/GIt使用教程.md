# GIt使用教程

### create a new repository on the command line

```shell
echo "# Note" >> README.md
git init //初始化
git add README.md //添加描述信息
git commit -m "first commit" //提交到工作区
git branch -M main //分支
git remote add origin git@github.com:Git201808/Note.git//添加到远程仓库
git push -u origin main//提交更新到远程仓库
```

###  push an existing repository from the command line

```shell
git remote add origin git@github.com:Git201808/Note.git //添加远程仓库
git branch -M main //添加分支
git push -u origin main//推送更新到远程仓库
```

