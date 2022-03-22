﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenFrp.UI
{

    /// <summary>
    /// 多语言资源
    /// </summary>
    public class Assets
    {

        public AssetModel[] AssetCollection = new AssetModel[]
        {
            new AssetModel
            {
                LangNameS = "zh_cn",
                LangNameD = "简体中文",
                Cancel = "取消",
                Close = "关闭",
                Yes = "是",
                No = "否",
                Welcome = "欢迎使用MarchOpenFrpLauncher（仅限非商业使用）",
                Loading = "正在加载...",
                Username = "用户名",
                Password = "密码",
                ServerAddr = "服务器地址",
                Letsgo = "我们开始吧",
                Login = "登录",
                Logining = "正在登录",
                LoginFailed = "登录失败！",
                UserInfo = "用户信息",
                AccessToken = "访问密钥",
                DownloadFrpc = "下载frpc.exe",
                DownloadingFrpc = "正在下载frpc.exe",
                DownloadedFrpc = "frpc.exe下载成功！",
                Downloading = "正在下载...",
                DownloadFailed = "下载失败！",
                LaunchFrpc = "启动隧道",
                PlzSelectServer = "请选择节点",
                ViewLog = "显示日志",
                Home = "主页",
                WelcomeBack = "欢迎回来",
                Frp = "映射",
                RestartRequired = "应用程序需要重启。",
                Settings = "设置",
                Language = "语言",
                ClickToDuplicate = "点击复制",
                Duplicated = "已复制",
                FrpcLaunchMode = "Frpc启动模式",
                ByProxy = "按隧道",
                ByNode = "按节点",
                Refresh = "刷新",
                Refreshing = "正在刷新"
            },
            new AssetModel
            {
                LangNameS ="zk_tw",
                LangNameD ="繁體中文（臺灣）",
                Cancel ="取消",
                Close ="關閉",
                Yes ="是",
                No ="否",
                Welcome ="歡迎使用MarchOpenFrpLauncher（僅限非商用使用）",
                Loading ="正在加載…",
                Username ="用戶名",
                Password ="密碼",
                ServerAddr ="伺服器地址",
                Letsgo ="我們開始吧",
                Login ="登入",
                Logining ="正在登入",
                LoginFailed ="登入失敗！",
                UserInfo ="用戶資訊",
                AccessToken ="訪問密鑰",
                DownloadFrpc ="下載frpc.exe",
                DownloadingFrpc ="正在下載frpc.exe",
                DownloadedFrpc ="frpc.exe下載成功！",
                Downloading ="正在下載…",
                DownloadFailed ="下載失敗！",
                LaunchFrpc ="啟動隧道",
                PlzSelectServer ="請選擇節點",
                ViewLog ="顯示日誌",
                Home ="主頁",
                WelcomeBack ="歡迎回來",
                Frp ="穿透",
                RestartRequired ="應用程序需要重啓。",
                Settings ="設定",
                Language ="語言",
                ClickToDuplicate ="點擊複製",
                Duplicated ="已複製",
                FrpcLaunchMode ="穿透用戶端啟動模式",
                ByProxy ="按隧道",
                ByNode ="按節點",
                Refresh ="刷新",
                Refreshing ="正在刷新"
            },
            new AssetModel
            {
                LangNameS = "zk_hk",
                LangNameD = "繁體中文（香港）",
                Cancel = "取消",
                Close = "關閉",
                Yes = "是",
                No = "否",
                Welcome = "歡迎使用MarchOpenFrpLauncher（僅限非商用使用）",
                Loading = "正在加載...",
                Username = "用户名",
                Password = "密碼",
                ServerAddr = "服務器地址",
                Letsgo = "我們開始吧",
                Login = "登錄",
                Logining = "正在登錄",
                LoginFailed = "登錄失敗！",
                UserInfo = "用户信息",
                AccessToken = "訪問密鑰",
                DownloadFrpc = "下載frpc.exe",
                DownloadingFrpc = "正在下載frpc.exe",
                DownloadedFrpc = "frpc.exe下載成功！",
                Downloading = "正在下載...",
                DownloadFailed = "下載失敗！",
                LaunchFrpc = "啓動隧道",
                PlzSelectServer = "請選擇節點",
                ViewLog = "顯示日誌",
                Home = "主頁",
                WelcomeBack = "歡迎回來",
                Frp = "映射",
                RestartRequired = "應用程序需要重啓。",
                Settings = "設置",
                Language = "語言",
                ClickToDuplicate = "點擊複製",
                Duplicated = "已複製",
                FrpcLaunchMode = "Frpc啓動模式",
                ByProxy = "按隧道",
                ByNode = "按節點",
                Refresh = "刷新",
                Refreshing = "正在刷新"
            },
            new AssetModel
            {
                LangNameS = "en_us",
                LangNameD = "English",
                Cancel = "Cancel",
                Close = "Close",
                Yes = "Yes",
                No = "No",
                Welcome = "Welcome to MarchOpenFrpLauncher!(Non commercial use only)",
                Loading = "Loading...",
                Username = "Username",
                Password = "Password",
                ServerAddr = "Server IP",
                Letsgo = "Let's go!",
                Login = "Login",
                Logining = "Logining...",
                LoginFailed = "Login failed!",
                UserInfo = "User info",
                AccessToken = "Access Token",
                DownloadFrpc = "Download frpc.exe",
                DownloadingFrpc = "Downloading frpc.exe...",
                DownloadedFrpc = "Frpc has successfully downloade!",
                Downloading = "Downloading...",
                DownloadFailed = "Ops! There seems to be something wrong while downloading.",
                LaunchFrpc = "Launch Frpc",
                PlzSelectServer = "Please select a server:",
                ViewLog = "View Log",
                Home = "Home",
                WelcomeBack = "Welcome Back!",
                Frp = "Frp",
                RestartRequired = "Application requires to be restarted.",
                Settings = "Settings",
                Language = "Language",
                ClickToDuplicate = "Click to duplicate.",
                Duplicated = "Duplicated!",
                FrpcLaunchMode = "Frpc launch mode",
                ByProxy = "By proxy",
                ByNode = "By node",
                Refresh = "Refresh",
                Refreshing = "Refreshing..."
            }
        };

        public AssetModel SearchAsset(string LangNameS)
        {
            AssetModel resultNull = this.AssetCollection[0];
            foreach (var tasset in this.AssetCollection)
            {
                if(tasset.LangNameS == LangNameS)
                {
                    return tasset;
                }
            }
            return resultNull;
        }

        public string LangNameStoD(string LangNameS)
        {
            string result = "null";
            foreach (var i in this.AssetCollection)
            {
                if (i.LangNameS == LangNameS)
                    result = i.LangNameD;
            }
            return result;
        }

        public string LangNameDtoS(string LangNameD)
        {
            string result = "null";
            foreach (var i in this.AssetCollection)
            {
                if (i.LangNameD == LangNameD)
                    result = i.LangNameS;
            }
            return result;
        }
    }
}