# Re:Free Adobe 1.3（2023-1-4更新）

更新内容-修复了Acrobat DC的文件路径问题

@亦泽同学 | 复活版 by Aunt Studio(@Aunt_nuozhen)

---

 Notice!⚠️：最新版本的Photoshop2023新增了联网注册检查，若监测到为破解版会自动弹窗，并在十天内禁止使用PS，[症状见Issue #1](https://github.com/yangnuozhen/FreeAdobe/issues/1)，解决方法也是相当的简单，禁止PS联网即可。

以管理员身份打开Powershell，运行下列指令：
```Powershell
New-NetFirewallRule -DisplayName “Photoshop 2023 Patch” -Direction Outbound -Program "C:\Program Files\Adobe\Adobe Photoshop 2023\Photoshop.exe" -RemoteAddress LocalSubnet -Action Block
```

---

---

## 简介

FreeAdobe是一款Adobe优化软件，可以优化Adobe CC系列的各种软件，支持2019系列、2020系列、2021系列、2022系列、2023系列

例如 Photoshop 2023、Photoshop 2022、Photoshop 2021、Photoshop 2020、Photoshop 2019、Acrobat Pro DC 2019、Acrobat Pro DC 2020等所有2019版后的版本。

优化之后即可解除授权限制，无限使用。而且FreeAdobe支持软件升级，在升级之后再按照使用方式操作一遍即可随时享用最新版本。

>目前，Acrobat 2023版本无法使用本软件破解，请另寻途径。如有新方法将第一时间更新。

## 使用方式

1、去Adobe官网下载[CreativeCloud](https://creativecloud.adobe.com/apps/download/creative-cloud?locale=zh-cn)并且安装

[https://creativecloud.adobe.com/apps/download/creative-cloud?locale=zh-cn](https://creativecloud.adobe.com/apps/download/creative-cloud?locale=zh-cn)

2、通过CreativeCloud下载你想要的应用比如Photoshop（需要登陆CreativeCloud）

![CreativeCloud](img/creative_cloud.png)

3、在本软件(FreeAdobe)内找到你下载的版本，点击优化即可使用

![主界面](img/freeadobe_main_form.png)

4、注意不要更改adobe系列软件的安装目录(C盘)

![photoshop2021_main.png](img/photoshop2021_main.png)

## 更新地址

最新版本的FreeAdobe下载地址【支持adobe 2019 2020 2021 2022 2023全家桶】：

[Github Releases](https://github.com/yangnuozhen/FreeAdobe/releases)

原作地址：

[https://bestyize.github.io/adobe/freeadobe](https://bestyize.github.io/adobe/freeadobe)
