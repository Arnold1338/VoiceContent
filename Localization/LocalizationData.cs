using System.Collections.Generic;

/*
    * Try not to repeat words and/or phrases
    * Try to be specific while trying to minimize repetition, so words and phrases that can be used in normal situations don't trigger content
    * Obviously, don't add sponsors or words like "honey" or "sofi" because these can be used in day to day conversation
*/

namespace VoiceContent.Localization
{
    public static class LocalizationData
    {
        private static readonly Dictionary<string, Dictionary<string, List<string>>> data = new Dictionary<string, Dictionary<string, List<string>>>()
        {
            ["en"] = new Dictionary<string, List<string>>
            {
                ["swearWords"] = new List<string>
            {
                "fuck",
                "shit",
                "cunt",
                "bitch",
                "bastard",
                "asshole",
                "bullshit",
                "cock",
                "twat",
                "wanker",
                "bellend",
                "slut",
                "prick",
                "pussy",
                "motherfucker",
                "hell",
                "kill yourself",
            },
                ["youtuberPhrases"] = new List<string>
            {
                "like and subscribe",
                "don't forget to share",
                "hit that subscribe button",
                "like comment and subscribe",
                "don't forget to subscribe",
                "let's jump right into it",
                "give this video a thumbs up",
                "that like button",
                "the like button",
                "that notification bell",
                "the notification bell",
                "that subscribe button",
                "the subscribe button",
                "before starting this video",
            },
                ["sponsorPhrases"] = new List<string>
            {
                "i want to give a huge shoutout to our sponsor",
                "i want to give a shoutout to our sponsor",
                "i want to take a quick moment to thank",
                "video is sponsored by",
                "video is made possible by",
                "video is brought to you by",
                "episode is sponsored by",
                "episode is brought to you by",
                "episode is made possible by",
                "before we begin i want to thank",
                "promo code",
                "discount code",
                "star code",
                "creator code",
                "patreon",
                "gfuel",
                "temu",
                "nordvpn",
                "private internet access",
                "expressvpn",
                "audible",
                "skillshare",
                "squarespace",
                "raid shadow legends",
                "raycon",
                "hello fresh",
                "manscaped",
                "betterhelp",
                "grammarly",
                "blue apron",
                "dollar shave club",
                "rocket money",
                "fortnite",
                "honkai star rail",
                "genshin impact",
                "paypal",
                "surfshark",
            }
            }, // WindowsVoiceRecognitonAPI, VoskVoiceRecognitionAPI
            ["ru-RU"] = new Dictionary<string, List<string>>
            {
                ["swearWords"] = new List<string>
            {
                "сука",
                "тварь",
                "ебать",
                "блять",
                "ублюдок",
                "сволочь",
                "нахуй",
                "хуй",
                "мразь",
                "тварь",
            },
                ["youtuberPhrases"] = new List<string>
            {
                "лайк",
                "подписка",
                "колокольчик",
                "канал"
            },
                ["sponsorPhrases"] = new List<string>
            {
                "патреон",
                "patreon",
                "газпром",
                "имба энержи",
                "ростелеком",
                "теле2",
                "expressvpn",
                "мегафон",
                "билайн",
                "squarespace",
                "raid shadow legends",
                "landfall games",
                "fortnite",
                "honkai star rail",
                "genshin impact",
                "paypal"
            }
            } // VoskVoiceRecognitionAPI
        };

        public static List<string> GetLocalizedList(string languageCode, string key)
        {

            if (data.TryGetValue(languageCode, out var languageData) && languageData.TryGetValue(key, out var list))
            {
                return list;
            }
            return new List<string>();
        }
    }
}