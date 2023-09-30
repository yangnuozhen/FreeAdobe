# Re:FreeAdobe

公告: 如果您使用Clash for Windows等软件进行代理并且尝试破解PS 2023，请按此操作:

此处以Clash for Windows为例。

1. 打开设置
2. 找到System Proxy 设置项
3. 点击`Bypass Domain/IPNet` 右边的 Edit 按钮
![image](https://github.com/yangnuozhen/ReFreeAdobe/assets/56541171/953afd7b-6f60-4801-afc0-b927cc6f6b22)
![image](https://github.com/yangnuozhen/ReFreeAdobe/assets/56541171/c2b1f5bc-ccc4-4aed-a852-357f60a03969)

4.它应该会打开一个Visual Studio Code或其它默认文本编辑器的窗口。
![image](https://github.com/yangnuozhen/ReFreeAdobe/assets/56541171/fd8680ff-0ff8-451a-8569-3528aa08c272)

5.在倒数第二行（<`local>`的上面）插入新行。
![image](https://github.com/yangnuozhen/ReFreeAdobe/assets/56541171/f625b61e-9602-42a1-a5a8-d3db427fb866)

6.填入
```
  - '*.adobe.io'
```

![image](https://github.com/yangnuozhen/ReFreeAdobe/assets/56541171/cbf7dfef-9d47-4bcb-aa07-a20fcc72c9a5)

7.保存，关闭窗口。

此时即使开着代理，也能正常阻止*.adobe.io的出站。

---
 
具体介绍：[Re:FreeAdobe](https://nuozhen.top/ReFreeAdobe/)

![2.0](https://github.com/yangnuozhen/ReFreeAdobe/assets/56541171/446c8d87-cbdd-43c3-8f78-c7f4132d86f4)



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
