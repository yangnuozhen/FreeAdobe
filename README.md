# Re:FreeAdobe
 
 Notice!⚠️：最新版本的Photoshop2023新增了联网注册检查，若监测到为破解版会自动弹窗，并在十天内禁止使用PS，[症状见Issue #1](https://github.com/yangnuozhen/FreeAdobe/issues/1)，解决方法也是相当的简单，禁止PS联网即可。

以管理员身份打开Powershell，运行下列指令：
```Powershell
New-NetFirewallRule -DisplayName “Photoshop 2023 Patch” -Direction Outbound -Program "C:\Program Files\Adobe\Adobe Photoshop 2023\Photoshop.exe" -RemoteAddress LocalSubnet -Action Block
```

---

新版本V2.0即将在我中考完后上线，敬请期待。

---
 
具体介绍：[Re:FreeAdobe](https://nuozhen.top/ReFreeAdobe/)

![FreeAdobe](https://nuozhen.top/ReFreeAdobe/img/freeadobe_main_form.png)
