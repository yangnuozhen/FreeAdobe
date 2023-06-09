# Re:FreeAdobe
 
 Notice!⚠️：最新版本的Photoshop2023新增了联网注册检查，若监测到为破解版会自动弹窗，并在十天内禁止使用PS，[症状见Issue #1](https://github.com/yangnuozhen/FreeAdobe/issues/1)，解决方法也是相当的简单，禁止PS联网即可。

以管理员身份打开Powershell，运行下列指令：
```Powershell
New-NetFirewallRule -DisplayName “Photoshop 2023 Patch” -Direction Outbound -Program "C:\Program Files\Adobe\Adobe Photoshop 2023\Photoshop.exe" -RemoteAddress LocalSubnet -Action Block
```
>Tip: There will be a feature update that can automatic fix this problem by running that comand.
---

新版本V2.0即将在我中考完后上线，敬请期待。

Future Preview (V2.0) : 
![QQ截图20230609234237](https://github.com/yangnuozhen/ReFreeAdobe/assets/56541171/446c8d87-cbdd-43c3-8f78-c7f4132d86f4)



![QQ截图20230609234311](https://github.com/yangnuozhen/ReFreeAdobe/assets/56541171/e001b79e-87bc-4e22-95e3-357e4f1eb479)

---
 
具体介绍：[Re:FreeAdobe](https://nuozhen.top/ReFreeAdobe/)

![FreeAdobe](https://nuozhen.top/ReFreeAdobe/img/freeadobe_main_form.png)

---

## License

本项目源代码遵循GPL V3协议。

⚠不建议作为商业使用⚠
一切商业使用的后果由您自行承担。

本仓库提供者、贡献者、所有者不为您使用本软件的任何行为承担责任。

**请支持正版.**
