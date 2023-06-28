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

## Bug report guide

### Step.1 Open Issues page

Open [Issues page](https://github.com/yangnuozhen/ReFreeAdobe/issues).

### Step.2 Touch `New Issue`

![image](https://github.com/yangnuozhen/ReFreeAdobe/assets/56541171/0c451a5a-addd-497f-9cb2-b2cc8bb64f76)

### Step.3 Select a template

If you want to feedback message as English, please select the template that marked `(English)`

如果您想以中文反馈，请选择标记有`（简体中文）`的Issue 模板。

### Step.4 Read and fill

Read the feedback form information carefully and fill it out as required.

### Step.5 Write a great title

A concise, clear title can help us better categorize and understand the problem.

### Step.6 Submit the issue

When you are done filling out the report, click the button `Submit new issue` at the bottom.

### Step.7 Just wait

☕Have a cup of coffee and go to bed. This may take a few days for us to understand and resolve the issue.

### Notice

If you have multiple issues that require feedback, be sure to create a separate Issue for each issue, otherwise it may become confusing.
如果您有多个问题需要反馈，请务必为每个问题单独创建Issue，否则可能会造成问题混乱不清。

## License

本项目源代码遵循GPL V3协议。

⚠不建议作为商业使用⚠
一切商业使用的后果由您自行承担。

本仓库提供者、贡献者、所有者不为您使用本软件的任何行为承担责任。

**请支持正版.**
