using LCU;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsUI;
using static Lobby;
using static LCU.LCU;

namespace LFPeasy.src.Forms
{
    public partial class MainForm : WindowsUI.WinForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if(LCU.LCU.CheckParams())
            {
                LCU .LCU.tRequest summonerReq = LCU.LCU.Request(RestSharp.Method.GET, "/lol-summoner/v1/current-summoner");
                if(summonerReq.IsAvaible())
                {
                    Summoner.Root summoner = JsonConvert.DeserializeObject<Summoner.Root>(summonerReq.Content);
                    lblUsername.Text = summoner.DisplayName;
                    pbProfile.ImageLocation = "http://ddragon.leagueoflegends.com/cdn/10.24.1/img/profileicon/" + summoner.ProfileIconId + ".png";
                    pbLevel.Value = summoner.PercentCompleteForNextLevel;
                    pbLevel.Content ="(" + summoner.XpSinceLastLevel + "/" + summoner.XpUntilNextLevel + ")";
                }

                LCU.LCU.tRequest walletReq = LCU.LCU.Request(RestSharp.Method.GET, "/lol-store/v1/wallet");
                if(walletReq.IsAvaible())
                {
                    Wallet.Root wallet = JsonConvert.DeserializeObject<Wallet.Root>(walletReq.Content);
                    lblBE.Text = wallet.Ip.ToString();
                    lblRP.Text = wallet.Rp.ToString();
                }

                tRequest chatReq = Request(RestSharp.Method.GET, "/lol-chat/v1/me");
                if (chatReq.IsAvaible())
                {
                    Chat.Root chat = JsonConvert.DeserializeObject<Chat.Root>(chatReq.Content);
                    tbStatus.Content = chat.StatusMessage;
                }
            }
        }

        private void tUpdateProfile_Tick(object sender, EventArgs e)
        {
            if (LCU.LCU.CheckParams())
            {
                LCU.LCU.tRequest summonerReq = LCU.LCU.Request(RestSharp.Method.GET, "/lol-summoner/v1/current-summoner");
                if (summonerReq.IsAvaible())
                {
                    Summoner.Root summoner = JsonConvert.DeserializeObject<Summoner.Root>(summonerReq.Content);
                    lblUsername.Text = summoner.DisplayName;
                    pbProfile.ImageLocation = "http://ddragon.leagueoflegends.com/cdn/11.3.1/img/profileicon/" + summoner.ProfileIconId + ".png";
                    pbLevel.Value = summoner.PercentCompleteForNextLevel;
                    pbLevel.Content = "(" + summoner.XpSinceLastLevel + "/" + summoner.XpUntilNextLevel + ")";
                }

                LCU.LCU.tRequest walletReq = LCU.LCU.Request(RestSharp.Method.GET, "/lol-store/v1/wallet");
                if (walletReq.IsAvaible())
                {
                    Wallet.Root wallet = JsonConvert.DeserializeObject<Wallet.Root>(walletReq.Content);
                    lblBE.Text = wallet.Ip.ToString();
                    lblRP.Text = wallet.Rp.ToString();
                }
            }
        }

        private void btnAramBoost_Click(object sender, EventArgs e)
        {
            if (LCU.LCU.CheckParams())
            {
                Process[] p = Process.GetProcessesByName("LeagueClientUx");
                if(p.Length != 0)
                {
                    if (MD5Hash.GetMD5HashFromFile(Process.GetProcessesByName("LeagueClientUx").FirstOrDefault().MainModule.FileName) == "44F82D6EF65F513CD6539C195264DC7F")
                    {
                        LCU.LCU.tRequest gameflowReq = LCU.LCU.Request(RestSharp.Method.GET, "/lol-gameflow/v1/gameflow-phase");
                        if(gameflowReq.IsAvaible())
                        {
                            if (gameflowReq.Content.Contains("ChampSelect"))
                            {
                                LCU.LCU.tRequest skinBoost = LCU.LCU.Request(RestSharp.Method.POST, "lol-champ-select/v1/team-boost/purchase");
                                if(skinBoost.IsAvaible())
                                {
                                    MessageBox.Show("ARAM/URF Skin boost has been activated!", "LFPeasy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("You are not in Champion Selection Phase!", "LFPeasy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("ARAM/URF Skin boost feature needs client hotfix!", "LFPeasy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnCreateCustomLobby_Click(object sender, EventArgs e)
        {
            var lobby = new CustomLobby // Thanks leftspace89 <3 https://github.com/leftspace89/LeaguePW5/blob/915e3aacb050de799cbb3ba45605c1d36a165fb4/LeaguePW5.cs#L93
            {
                isCustom = true,
                customGameLobby = new CustomGameLobby
                {
                    lobbyName = "LFPeasy",
                    lobbyPassword = "",
                    configuration = new Configuration
                    {
                        gameMode = "PRACTICETOOL",
                        gameMutator = "",
                        gameServerRegion = "",
                        mapId = 11,
                        mutators = new Mutators { id = 1 },
                        spectatorPolicy = "AllAllowed",
                        teamSize = 5
                    }
                }
            };

            LCU.LCU.tRequest lobbyReq = LCU.LCU.Request(RestSharp.Method.POST, "/lol-lobby/v2/lobby", lobby, RestSharp.DataFormat.Json);
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            if(CheckParams())
            {
                tRequest chatReq = Request(RestSharp.Method.GET, "/lol-chat/v1/me");
                if (chatReq.IsAvaible())
                {
                    Chat.Root chat = new Chat.Root();
                    chat.StatusMessage = tbStatus.Content;
                    tRequest chatPutReq = Request(RestSharp.Method.PUT, "/lol-chat/v1/me", JsonConvert.SerializeObject(chat), RestSharp.DataFormat.Json);
                }
            }
        }

        private void cbAutoAccept_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbTimeStatus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGithub_OnTileButtonMouseClick(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Lufzys");
        }

        private void tCore_Tick(object sender, EventArgs e)
        {
            if(CheckParams())
            {
                if(cbAutoAccept.Checked)
                {
                    tRequest readyReq = Request(RestSharp.Method.GET, "/lol-matchmaking/v1/ready-check");
                    if(readyReq.IsAvaible())
                    {
                        ReadyCheck.Root readyCheck = JsonConvert.DeserializeObject<ReadyCheck.Root>(readyReq.Content);
                        if (readyCheck.State == "InProgress")
                        {
                            Request(RestSharp.Method.POST, "/lol-matchmaking/v1/ready-check/accept");
                        }
                    }
                }

                if(cbTimeStatus.Checked)
                {
                    tRequest chatReq = Request(RestSharp.Method.GET, "/lol-chat/v1/me");
                    if (chatReq.IsAvaible())
                    {
                        Chat.Root chat = new Chat.Root();
                        chat.StatusMessage = DateTime.Now.ToString("hh:mm");
                        tRequest chatPutReq = Request(RestSharp.Method.PUT, "/lol-chat/v1/me", JsonConvert.SerializeObject(chat), RestSharp.DataFormat.Json);
                    }
                }
            }
        }
    }
}
