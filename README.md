# Fudan_NetworkAutoVerification
 复旦大学校园网自动认证客户端

# 第一次使用
## win7系统
可以直接进入bin文件夹中，找到debug文件夹下面的网络认证工具.exe，点击运行即可。登录成功后，点击最小化缩入状态栏中。只要电脑不关机，它会每天自动认证。

## win10系统
第一次使用可能会让你安装.Net 3.5框架。你可以选择安装这个框架，或者如果你懂一些C#的话，可以通过Visual Studio重新编译该程序。

# 软件原理
## 自动化认证
该软件原理非常简单，只是作为一个后台程序，帮你计时认证。在你第一次登陆以后（软件关闭以后不会记录你的用户名和密码），最小化之后即可。
网络认证是通过发送一个PoST请求给学校的认证服务窗口，这里面需要发送你的用户名和密码以及你的电脑的IP（校园网的）。

所以该工具主要是获取本地主机的IP地址，然后将用户名和密码包装以后发送一个请求。并在24小时认证失效之前再发送一次。
