using Microsoft.Win32;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Color = Microsoft.Xna.Framework.Color;
using ButtonState = Microsoft.Xna.Framework.Input.ButtonState;
using Keys = Microsoft.Xna.Framework.Input.Keys;
using Rectangle = Microsoft.Xna.Framework.Rectangle;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Terraria.Achievements;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.Events;
using Terraria.GameContent.Liquid;
using Terraria.GameContent.Tile_Entities;
using Terraria.GameContent.UI;
using Terraria.GameContent.UI.Chat;
using Terraria.GameContent.UI.States;
using Terraria.Graphics;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Initializers;
using Terraria.IO;
using Terraria.Map;
using Terraria.Net;
using Terraria.ObjectData;
using Terraria.Social;
using Terraria.UI;
using Terraria.UI.Chat;
using Terraria.Utilities;
using Terraria.World.Generation;

namespace Terraria
{
	public class LN
	{
		// 번역하시는 분들께
		//
		// 중간에 들어간 text 같은 것은 프로그램에서 쓰는거라 번역안하셔도 됩니다.
		// 명사가 들어간다고 생각해주시면 될듯.
		// 

		// 주 : 데미지 X 대미지

		// #### 담당 파트 ### //
		/*
		itemName
		번:라피에나
		검:버들서
		AnglerQuestChat
		번:
		검:
		setBonus
		번:버들서
		검:버들서
		dialog
		번:Poro
		검:
		setLang
		번:버들서
		검:
		npcName
		번:버들서
		검:
		toolTip1
		번:
		검:
		toolTip2
		번:
		검:
	
		원문을 확인하려면 파일을 구버전으로 롤백해 보십시오.
		*/

		public static string KrTailString(string name)
		{

			return name;
		}

		public static string itemName(int l)
		{
			switch (l)
			{
				#region netid-
				case -48:
					return "백금 활";
				case -47:
					return "백금 망치";
				case -46:
					return "백금 도끼";
				case -45:
					return "백금 숏소드";
				case -44:
					return "백금 브로드소드";
				case -43:
					return "백금 곡괭이";
				case -42:
					return "텅스텐 보우";
				case -41:
					return "텅스텐 해머";
				case -40:
					return "텅스텐 도끼";
				case -39:
					return "텅스텐 숏소드";
				case -38:
					return "텅스텐 브로드소드";
				case -37:
					return "텅스텐 곡괭이";
				case -36:
					return "납 활";
				case -35:
					return "납 망치";
				case -34:
					return "납 도끼";
				case -33:
					return "납 숏소드";
				case -32:
					return "납 브로드소드";
				case -31:
					return "납 곡괭이";
				case -30:
					return "주석 활";
				case -29:
					return "주석 망치";
				case -28:
					return "주석 도끼";
				case -27:
					return "주석 숏소드";
				case -26:
					return "주석 브로드소드";
				case -25:
					return "주석 곡괭이";
				case -24:
					return "노랑 광선검";
				case -23:
					return "백색 광선검";
				case -22:
					return "자주색 광선검";
				case -21:
					return "녹색 광선검";
				case -20:
					return "붉은 광선검";
				case -19:
					return "푸른 광선검";
				case -18:
					return "구리 활";
				case -17:
					return "구리 망치";
				case -16:
					return "구리 도끼";
				case -15:
					return "구리 숏소드";
				case -14:
					return "구리 브로드소드";
				case -13:
					return "구리 곡괭이";
				case -12:
					return "은제 활";
				case -11:
					return "은제 망치";
				case -10:
					return "은제 도끼";
				case -9:
					return "은제 숏소드";
				case -8:
					return "은제 브로드소드";
				case -7:
					return "은제 곡괭이";
				case -6:
					return "황금 활";
				case -5:
					return "황금 망치";
				case -4:
					return "황금 도끼";
				case -3:
					return "황금 숏소드";
				case -2:
					return "황금 브로드소드";
				case -1:
					return "황금 곡괭이";
				#endregion
				#region 0001 ~ 0500
				case 1:
					return "철제 곡괭이";
				case 2:
					return "흙 블럭";
				case 3:
					return "돌 블럭";
				case 4:
					return "철제 브로드소드";
				case 5:
					return "버섯";
				case 6:
					return "철제 숏소드";
				case 7:
					return "철제 망치";
				case 8:
					return "횃불";
				case 9:
					return "나무";
				case 10:
					return "철제 도끼";
				case 11:
					return "철광석";
				case 12:
					return "구리광석";
				case 13:
					return "금광석";
				case 14:
					return "은광석";
				case 15:
					return "구리 시계";
				case 16:
					return "은제 시계";
				case 17:
					return "금제 시계";
				case 18:
					return "측심기";
				case 19:
					return "금 괴";
				case 20:
					return "구리 괴";
				case 21:
					return "은 괴";
				case 22:
					return "철 괴";
				case 23:
					return "젤";
				case 24:
					return "목검";
				case 25:
					return "나무 문";
				case 26:
					return "돌 벽면";
				case 27:
					return "도토리";
				case 28:
					return "하급 치유 물약";
				case 29:
					return "생명의 결정";
				case 30:
					return "흙 벽면";
				case 31:
					return "병";
				case 32:
					return "나무 탁자";
				case 33:
					return "화로";
				case 34:
					return "나무 의자";
				case 35:
					return "철제 모루";
				case 36:
					return "작업대";
				case 37:
					return "고글";
				case 38:
					return "렌즈";
				case 39:
					return "나무 활";
				case 40:
					return "나무 화살";
				case 41:
					return "불화살";
				case 42:
					return "수리검";
				case 43:
					return "수상쩍은 시선의 눈";
				case 44:
					return "악마의 활";
				case 45:
					return "밤의 전투도끼";
				case 46:
					return "빛의 파멸";
				case 47:
					return "사악한 화살";
				case 48:
					return "상자";
				case 49:
					return "재생의 반지";
				case 50:
					return "마법의 거울";
				case 51:
					return "광대의 화살";
				case 52:
					return "천사상";
				case 53:
					return "병에 담긴 구름";
				case 54:
					return "헤르메스의 신발";
				case 55:
					return "마법의 부메랑";
				case 56:
					return "데모나이트 광석";
				case 57:
					return "데모나이트 괴";
				case 58:
					return "하트";
				case 59:
					return "오염된 씨앗";
				case 60:
					return "역겨운 버섯";
				case 61:
					return "흑단석 블럭";
				case 62:
					return "잔디 씨앗";
				case 63:
					return "해바라기";
				case 64:
					return "타락가시";
				case 65:
					return "별의격노";
				case 66:
					return "정화의 가루";
				case 67:
					return "역겨운 가루";
				case 68:
					return "썩은 덩어리";
				case 69:
					return "벌레 이빨";
				case 70:
					return "벌레 먹이";
				case 71:
					return "동화";
				case 72:
					return "은화";
				case 73:
					return "금화";
				case 74:
					return "백금화";
				case 75:
					return "별똥별";
				case 76:
					return "구리 각반";
				case 77:
					return "철제 각반";
				case 78:
					return "은제 각반";
				case 79:
					return "황금 각반";
				case 80:
					return "구리 사슬갑옷";
				case 81:
					return "철제 사슬갑옷";
				case 82:
					return "은제 사슬갑옷";
				case 83:
					return "황금 사슬갑옷";
				case 84:
					return "갈고랑쇠";
				case 85:
					return "쇠사슬";
				case 86:
					return "그림자 비늘";
				case 87:
					return "돼지 저금통";
				case 88:
					return "채광용 모자";
				case 89:
					return "구리 투구";
				case 90:
					return "철제 투구";
				case 91:
					return "은제 투구";
				case 92:
					return "황금 투구";
				case 93:
					return "나무 벽면";
				case 94:
					return "나무 플랫폼";
				case 95:
					return "부싯돌 권총";
				case 96:
					return "머스킷 총";
				case 97:
					return "머스킷 탄";
				case 98:
					return "미니샤크";
				case 99:
					return "철제 활";
				case 100:
					return "그림자 각반";
				case 101:
					return "그림자 비늘갑옷";
				case 102:
					return "그림자 투구";
				case 103:
					return "악몽의 곡괭이";
				case 104:
					return "'파괴자'";
				case 105:
					return "양초";
				case 106:
					return "구리 샹들리에";
				case 107:
					return "은제 샹들리에";
				case 108:
					return "금제 샹들리에";
				case 109:
					return "마나 결정";
				case 110:
					return "하급 마나 물약";
				case 111:
					return "별의힘 반지";
				case 112:
					return "불의 꽃";
				case 113:
					return "마력탄";
				case 114:
					return "흙 막대기";
				case 115:
					return "그림자 보주";
				case 116:
					return "운석";
				case 117:
					return "운석 괴";
				case 118:
					return "갈고리";
				case 119:
					return "화염부메랑";
				case 120:
					return "녹아버린 격노";
				case 121:
					return "불타는 대검";
				case 122:
					return "녹아버린 곡괭이";
				case 123:
					return "운석 투구";
				case 124:
					return "운석 슈트";
				case 125:
					return "운석 각반";
				case 126:
					return "물이 담긴 병";
				case (int)sbyte.MaxValue:
					return "우주 총";
				case 128:
					return "로켓 신발";
				case 129:
					return "회색 벽돌";
				case 130:
					return "회색 벽돌 벽면";
				case 131:
					return "붉은 벽돌";
				case 132:
					return "붉은 벽돌 벽면";
				case 133:
					return "점토 블럭";
				case 134:
					return "파란 벽돌";
				case 135:
					return "파란 벽돌 벽면";
				case 136:
					return "사슬 랜턴";
				case 137:
					return "녹색 벽돌";
				case 138:
					return "녹색 벽돌 벽면";
				case 139:
					return "분홍 벽돌";
				case 140:
					return "분홍 벽돌 벽면";
				case 141:
					return "황금 벽돌";
				case 142:
					return "황금 벽돌 벽면";
				case 143:
					return "은 벽돌";
				case 144:
					return "은 벽돌 벽면";
				case 145:
					return "구리 벽돌";
				case 146:
					return "구리 벽돌 벽면";
				case 147:
					return "대못";
				case 148:
					return "물 양초";
				case 149:
					return "책";
				case 150:
					return "거미줄";
				case 151:
					return "죽음의 헬멧";
				case 152:
					return "죽음의 흉갑";
				case 153:
					return "죽음의 각반";
				case 154:
					return "뼈";
				case 155:
					return "무라마사";
				case 156:
					return "코발트 방패";
				case 157:
					return "물의 홀";
				case 158:
					return "행운의 말편자";
				case 159:
					return "빛나는 빨간 풍선";
				case 160:
					return "작살총";
				case 161:
					return "뾰족뾰족한 구슬";
				case 162:
					return "꽤 아픈 쇠공";
				case 163:
					return "푸른 달";
				case 164:
					return "권총";
				case 165:
					return "물의 화살";
				case 166:
					return "폭탄";
				case 167:
					return "다이너마이트";
				case 168:
					return "수류탄";
				case 169:
					return "모래 블럭";
				case 170:
					return "유리";
				case 171:
					return "표지판";
				case 172:
					return "화산재 블럭";
				case 173:
					return "흑요석";
				case 174:
					return "지옥석";
				case 175:
					return "지옥석 괴";
				case 176:
					return "진흙 블럭";
				case 177:
					return "사파이어";
				case 178:
					return "루비";
				case 179:
					return "에메랄드";
				case 180:
					return "토파즈";
				case 181:
					return "아메디스트";
				case 182:
					return "다이아몬드";
				case 183:
					return "발광 버섯";
				case 184:
					return "스타";
				case 185:
					return "담쟁이 채찍";
				case 186:
					return "호흡용 갈대";
				case 187:
					return "물갈퀴";
				case 188:
					return "치유 물약";
				case 189:
					return "마나 물약";
				case 190:
					return "초목의 검";
				case 191:
					return "가시 차크람";
				case 192:
					return "흑요석 벽돌";
				case 193:
					return "흑요석 해골";
				case 194:
					return "버섯 잔디 씨앗";
				case 195:
					return "정글 잔디 씨앗";
				case 196:
					return "나무 망치";
				case 197:
					return "유성 대포";
				case 198:
					return "푸른 위상검";
				case 199:
					return "붉은 위상검";
				case 200:
					return "녹색 위상검";
				case 201:
					return "자주색 위상검";
				case 202:
					return "백색 위상검";
				case 203:
					return "노랑 위상검";
				case 204:
					return "운석 날망치";
				case 205:
					return "빈 양동이";
				case 206:
					return "물 양동이";
				case 207:
					return "용암 양동이";
				case 208:
					return "정글 장미";
				case 209:
					return "침";
				case 210:
					return "덩굴";
				case 211:
					return "야생의 발톱";
				case 212:
					return "바람의 발찌";
				case 213:
					return "재성장의 지팡이";
				case 214:
					return "지옥석 벽돌";
				case 215:
					return "방귀 쿠션";
				case 216:
					return "족쇄";
				case 217:
					return "녹아버린 날망치";
				case 218:
					return "화염채찍";
				case 219:
					return "피닉스 블래스터";
				case 220:
					return "태양의분노";
				case 221:
					return "지옥의 화로";
				case 222:
					return "점토 단지";
				case 223:
					return "자연의 선물";
				case 224:
					return "침대";
				case 225:
					return "비단";
				case 226:
					return "하급 활력 물약";
				case 227:
					return "활력 물약";
				case 228:
					return "정글 모자";
				case 229:
					return "정글 상의";
				case 230:
					return "정글 바지";
				case 231:
					return "녹아버린 투구";
				case 232:
					return "녹아버린 흉갑";
				case 233:
					return "녹아버린 각반";
				case 234:
					return "운석 총알";
				case 235:
					return "끈끈이 폭탄";
				case 236:
					return "검정 렌즈";
				case 237:
					return "선글래스";
				case 238:
					return "마법사 모자";
				case 239:
					return "정장용 모자";
				case 240:
					return "턱시도 셔츠";
				case 241:
					return "턱시도 바지";
				case 242:
					return "여름 모자";
				case 243:
					return "토끼 후드";
				case 244:
					return "배관공의 모자";
				case 245:
					return "배관공의 셔츠";
				case 246:
					return "배관공의 바지";
				case 247:
					return "영웅의 모자";
				case 248:
					return "영웅의 셔츠";
				case 249:
					return "영웅의 바지";
				case 250:
					return "어항";
				case 251:
					return "고고학자의 모자";
				case 252:
					return "고고학자의 자켓";
				case 253:
					return "고고학자의 바지";
				case 254:
					return "검은 실";
				case (int)byte.MaxValue:
					return "녹색 실";
				case 256:
					return "닌자 후드";
				case 257:
					return "닌자 셔츠";
				case 258:
					return "닌자 바지";
				case 259:
					return "가죽";
				case 260:
					return "붉은 모자";
				case 261:
					return "금붕어";
				case 262:
					return "로브";
				case 263:
					return "로봇 모자";
				case 264:
					return "금 왕관";
				case 265:
					return "지옥불 화살";
				case 266:
					return "모래총";
				case 267:
					return "가이드 부두 인형";
				case 268:
					return "잠수모";
				case 269:
					return "익숙한 셔츠";
				case 270:
					return "익숙한 바지";
				case 271:
					return "익숙한 가발";
				case 272:
					return "악마의 낫";
				case 273:
					return "밤의 칼날";
				case 274:
					return "어둠의 창";
				case 275:
					return "산호";
				case 276:
					return "선인장";
				case 277:
					return "삼지창";
				case 278:
					return "은 총알";
				case 279:
					return "투척용 칼";
				case 280:
					return "창";
				case 281:
					return "취관";
				case 282:
					return "형광봉";
				case 283:
					return "씨앗";
				case 284:
					return "나무 부메랑";
				case 285:
					return "쇠붙이";
				case 286:
					return "접착식 형광봉";
				case 287:
					return "독이 묻은 칼";
				case 288:
					return "흑요석 피부 물약";
				case 289:
					return "재생 물약";
				case 290:
					return "신속 물약";
				case 291:
					return "아가미 물약";
				case 292:
					return "철피부 물약";
				case 293:
					return "마나 재생 물약";
				case 294:
					return "마법 강화 물약";
				case 295:
					return "가벼움의 물약";
				case 296:
					return "동굴 탐험가의 물약";
				case 297:
					return "투명화 물약";
				case 298:
					return "빛나는 물약";
				case 299:
					return "올빼미의 물약";
				case 300:
					return "전투의 물약";
				case 301:
					return "가시 물약";
				case 302:
					return "수상 보행 물약";
				case 303:
					return "궁수의 물약";
				case 304:
					return "사냥꾼의 물약";
				case 305:
					return "중력 물약";
				case 306:
					return "황금 상자";
				case 307:
					return "해맞이꽃 씨앗";
				case 308:
					return "달맞이꽃 씨앗";
				case 309:
					return "반짝이꽃 씨앗";
				case 310:
					return "사망초 씨앗";
				case 311:
					return "물방울잎 씨앗";
				case 312:
					return "화염초 씨앗";
				case 313:
					return "해맞이꽃";
				case 314:
					return "달맞이꽃";
				case 315:
					return "반짝이꽃";
				case 316:
					return "사망초";
				case 317:
					return "물방울잎";
				case 318:
					return "화염초";
				case 319:
					return "상어 지느러미";
				case 320:
					return "깃털";
				case 321:
					return "묘비";
				case 322:
					return "마임 가면";
				case 323:
					return "개미귀신 아랫턱";
				case 324:
					return "불법 총기 부품";
				case 325:
					return "닥터의 셔츠";
				case 326:
					return "닥터의 바지";
				case 327:
					return "황금 열쇠";
				case 328:
					return "그림자 상자";
				case 329:
					return "그림자 열쇠";
				case 330:
					return "흑요석 벽돌 벽면";
				case 331:
					return "정글 포자";
				case 332:
					return "물레";
				case 333:
					return "피아노";
				case 334:
					return "옷장";
				case 335:
					return "벤치";
				case 336:
					return "욕조";
				case 337:
					return "빨간색 현수막";
				case 338:
					return "녹색 현수막";
				case 339:
					return "파란색 현수막";
				case 340:
					return "노란색 현수막";
				case 341:
					return "가로등";
				case 342:
					return "티키 횃불";
				case 343:
					return "통";
				case 344:
					return "중화 랜턴";
				case 345:
					return "요리 단지";
				case 346:
					return "금고";
				case 347:
					return "해골 랜턴";
				case 348:
					return "쓰레기통";
				case 349:
					return "촛대";
				case 350:
					return "분홍색 꽃병";
				case 351:
					return "머그잔";
				case 352:
					return "작은 통";
				case 353:
					return "에일";
				case 354:
					return "책장";
				case 355:
					return "왕좌";
				case 356:
					return "그릇";
				case 357:
					return "스프가 담긴 그릇";
				case 358:
					return "화장실";
				case 359:
					return "할아버지의 시계";
				case 360:
					return "갑옷 동상";
				case 361:
					return "고블린 전장 깃발";
				case 362:
					return "너덜거리는 천";
				case 363:
					return "제재소";
				case 364:
					return "코발트 광석";
				case 365:
					return "미스릴 광석";
				case 366:
					return "아다만타이트 광석";
				case 367:
					return "완벽한 승리의 망치";
				case 368:
					return "엑스칼리버";
				case 369:
					return "신성한 씨앗";
				case 370:
					return "흑단모래 블럭";
				case 371:
					return "코발트 모자";
				case 372:
					return "코발트 투구";
				case 373:
					return "코발트 가면";
				case 374:
					return "코발트 흉갑";
				case 375:
					return "코발트 각반";
				case 376:
					return "미스릴 후드";
				case 377:
					return "미스릴 투구";
				case 378:
					return "미스릴 모자";
				case 379:
					return "미스릴 사슬갑옷";
				case 380:
					return "미스릴 각반";
				case 381:
					return "코발트 괴";
				case 382:
					return "미스릴 괴";
				case 383:
					return "코발트 전기톱";
				case 384:
					return "미스릴 전기톱";
				case 385:
					return "코발트 드릴";
				case 386:
					return "미스릴 드릴";
				case 387:
					return "아다만타이트 전기톱";
				case 388:
					return "아다만타이트 드릴";
				case 389:
					return "태극의 힘";
				case 390:
					return "미스릴 미늘창";
				case 391:
					return "아다만타이트 괴";
				case 392:
					return "유리 벽면";
				case 393:
					return "나침반";
				case 394:
					return "잠수 장비";
				case 395:
					return "GPS";
				case 396:
					return "흑요석 말편자";
				case 397:
					return "흑요석 방패";
				case 398:
					return "뗌장이의 작업장";
				case 399:
					return "구름 풍선";
				case 400:
					return "아다만타이트 헤드기어";
				case 401:
					return "아다만타이트 투구";
				case 402:
					return "아다만타이트 가면";
				case 403:
					return "아다만타이트 흉갑";
				case 404:
					return "아다만타이트 각반";
				case 405:
					return "유령의 신발";
				case 406:
					return "아다만타이트 글레이브";
				case 407:
					return "공구 벨트";
				case 408:
					return "진주모래 블럭";
				case 409:
					return "진주석 블럭";
				case 410:
					return "채광용 셔츠";
				case 411:
					return "채광용 바지";
				case 412:
					return "진주석 벽돌";
				case 413:
					return "다채색 벽돌";
				case 414:
					return "이암 벽돌";
				case 415:
					return "코발트 벽돌";
				case 416:
					return "미스릴 벽돌";
				case 417:
					return "진주석 벽돌 벽면";
				case 418:
					return "다채색 벽돌 벽면";
				case 419:
					return "이암 벽돌 벽면";
				case 420:
					return "코발트 벽돌 벽면";
				case 421:
					return "미스릴 벽돌 벽면";
				case 422:
					return "성스러운 물";
				case 423:
					return "사악한 물";
				case 424:
					return "실트 블럭";
				case 425:
					return "요정의 종";
				case 426:
					return "브레이커 블레이드";
				case 427:
					return "푸른 횃불";
				case 428:
					return "붉은 횃불";
				case 429:
					return "녹색 횃불";
				case 430:
					return "자주색 횃불";
				case 431:
					return "백색 횃불";
				case 432:
					return "노란 횃불";
				case 433:
					return "악마의 횃불";
				case 434:
					return "시계태엽 돌격소총";
				case 435:
					return "코발트 연발궁";
				case 436:
					return "미스릴 연발궁";
				case 437:
					return "이중 갈고리";
				case 438:
					return "별 동상";
				case 439:
					return "칼 동상";
				case 440:
					return "슬라임 동상";
				case 441:
					return "고블린 동상";
				case 442:
					return "방패 동상";
				case 443:
					return "박쥐 동상";
				case 444:
					return "물고기 동상";
				case 445:
					return "토끼 동상";
				case 446:
					return "해골 동상";
				case 447:
					return "사신 동상";
				case 448:
					return "여자 동상";
				case 449:
					return "임프 동상";
				case 450:
					return "가고일 동상";
				case 451:
					return "어둠의 동상";
				case 452:
					return "말벌 동상";
				case 453:
					return "폭탄 동상";
				case 454:
					return "게 동상";
				case 455:
					return "망치 동상";
				case 456:
					return "물약 동상";
				case 457:
					return "창 동상";
				case 458:
					return "십자가 동상";
				case 459:
					return "해파리 동상";
				case 460:
					return "활 동상";
				case 461:
					return "부메랑 동상";
				case 462:
					return "신발 동상";
				case 463:
					return "상자 동상";
				case 464:
					return "새 동상";
				case 465:
					return "도끼 동상";
				case 466:
					return "타락귀 동상";
				case 467:
					return "나무 동상";
				case 468:
					return "모루 동상";
				case 469:
					return "곡괭이 동상";
				case 470:
					return "버섯 동상";
				case 471:
					return "눈알 동상";
				case 472:
					return "기둥 동상";
				case 473:
					return "하트 동상";
				case 474:
					return "솥단지 동상";
				case 475:
					return "해바라기 동상";
				case 476:
					return "왕 동상";
				case 477:
					return "여왕 동상";
				case 478:
					return "피라냐 동상";
				case 479:
					return "널빤지 벽면";
				case 480:
					return "나무 기둥";
				case 481:
					return "아다만타이트 연발궁";
				case 482:
					return "아다만타이트 검";
				case 483:
					return "코발트 검";
				case 484:
					return "미스릴 검";
				case 485:
					return "달의 부적";
				case 486:
					return "자";
				case 487:
					return "수정 구슬";
				case 488:
					return "미스코 볼";
				case 489:
					return "마법사의 휘장";
				case 490:
					return "전사의 휘장";
				case 491:
					return "레인져의 휘장";
				case 492:
					return "악마의 날개";
				case 493:
					return "천사의 날개";
				case 494:
					return "마법의 하프";
				case 495:
					return "무지개 지팡이";
				case 496:
					return "얼음의 지팡이";
				case 497:
					return "넵튠의 조개껍질";
				case 498:
					return "마네킹";
				case 499:
					return "상급 치유 물약";
				case 500:
					return "상급 마나 물약";
				#endregion
				#region 0501 ~ 1000
				case 501:
					return "픽시의 가루";
				case 502:
					return "수정 파편";
				case 503:
					return "광대 모자";
				case 504:
					return "광대 셔츠";
				case 505:
					return "광대 바지";
				case 506:
					return "화염방사기";
				case 507:
					return "종";
				case 508:
					return "하프";
				case 509:
					return "렌치";
				case 510:
					return "전선 절단기";
				case 511:
					return "활성된 돌 블럭";
				case 512:
					return "비활성된 돌 블럭";
				case 513:
					return "레버";
				case 514:
					return "레이저 총";
				case 515:
					return "수정 총알";
				case 516:
					return "신성한 화살";
				case 517:
					return "마법의 단검";
				case 518:
					return "수정 폭풍";
				case 519:
					return "저주받은 불길";
				case 520:
					return "빛의 정수";
				case 521:
					return "밤의 정수";
				case 522:
					return "저주받은 불꽃";
				case 523:
					return "저주받은 횃불";
				case 524:
					return "아다만타이트 화로";
				case 525:
					return "미스릴 모루";
				case 526:
					return "유니콘의 뿔";
				case 527:
					return "어둠의 조각";
				case 528:
					return "빛의 조각";
				case 529:
					return "붉은 압력판";
				case 530:
					return "전선";
				case 531:
					return "주문서";
				case 532:
					return "별의 망토";
				case 533:
					return "메가샤크";
				case 534:
					return "산탄총";
				case 535:
					return "현자의 돌";
				case 536:
					return "거인의 장갑";
				case 537:
					return "코발트 나기나타";
				case 538:
					return "스위치";
				case 539:
					return "다트 함정";
				case 540:
					return "바위";
				case 541:
					return "녹색 압력판";
				case 542:
					return "회색 압력판";
				case 543:
					return "갈색 압력판";
				case 544:
					return "기계 눈";
				case 545:
					return "저주받은 화살";
				case 546:
					return "저주받은 총알";
				case 547:
					return "공포의 정수";
				case 548:
					return "힘의 정수";
				case 549:
					return "시야의 정수";
				case 550:
					return "궁니르";
				case 551:
					return "신성한 판금갑옷";
				case 552:
					return "신성한 각반";
				case 553:
					return "신성한 투구";
				case 554:
					return "십자가 목걸이";
				case 555:
					return "마나 꽃";
				case 556:
					return "기계 지렁이";
				case 557:
					return "기계 해골";
				case 558:
					return "신성한 헤드기어";
				case 559:
					return "신성한 가면";
				case 560:
					return "슬라임 왕관";
				case 561:
					return "빛의 원반";
				case 562:
					return "음악 상자 (Overworld Day)";
				case 563:
					return "음악 상자 (Eerie)";
				case 564:
					return "음악 상자 (Night)";
				case 565:
					return "음악 상자 (Title)";
				case 566:
					return "음악 상자 (Underground)";
				case 567:
					return "음악 상자 (Boss 1)";
				case 568:
					return "음악 상자 (Jungle)";
				case 569:
					return "음악 상자 (Corruption)";
				case 570:
					return "음악 상자 (Underground Corruption)";
				case 571:
					return "음악 상자 (The Hallow)";
				case 572:
					return "음악 상자 (Boss 2)";
				case 573:
					return "음악 상자 (Underground Hallow)";
				case 574:
					return "음악 상자 (Boss 3)";
				case 575:
					return "비행의 정수";
				case 576:
					return "음악 상자";
				case 577:
					return "데모나이트 벽돌";
				case 578:
					return "신성한 연발궁";
				case 579:
					return "드랙스";
				case 580:
					return "폭발물";
				case 581:
					return "입구 펌프";
				case 582:
					return "출구 펌프";
				case 583:
					return "1 초 타이머";
				case 584:
					return "3 초 타이머";
				case 585:
					return "5 초 타이머";
				case 586:
					return "사탕 지팡이 블럭";
				case 587:
					return "사탕 지팡이 벽면";
				case 588:
					return "산타 모자";
				case 589:
					return "산타 셔츠";
				case 590:
					return "산타 바지";
				case 591:
					return "녹색 사탕 지팡이 블럭";
				case 592:
					return "녹색 사탕 지팡이 벽면";
				case 593:
					return "눈 블럭";
				case 594:
					return "눈 벽돌";
				case 595:
					return "눈 벽돌 벽면";
				case 596:
					return "파란 전구";
				case 597:
					return "빨간 전구";
				case 598:
					return "녹색 전구";
				case 599:
					return "파란 선물 상자";
				case 600:
					return "녹색 선물 상자";
				case 601:
					return "노란 선물 상자";
				case 602:
					return "스노우 글로브";
				case 603:
					return "당근";
				case 604:
					return "아다만타이트 기둥";
				case 605:
					return "아다만타이트 기둥 벽면";
				case 606:
					return "데모나이트 벽돌 벽면";
				case 607:
					return "사암 벽돌";
				case 608:
					return "사암 벽돌 벽면";
				case 609:
					return "흑단석 벽돌";
				case 610:
					return "흑단석 벽돌 벽면";
				case 611:
					return "붉은 치장용 벽토";
				case 612:
					return "노란 치장용 벽토";
				case 613:
					return "녹색 치장용 벽토";
				case 614:
					return "회색 치장용 벽토";
				case 615:
					return "붉은 치장용 벽토 벽면";
				case 616:
					return "노란 치장용 벽토 벽면";
				case 617:
					return "녹색 치장용 벽토 벽면";
				case 618:
					return "회색 치장용 벽토 벽면";
				case 619:
					return "흑단나무";
				case 620:
					return "진한 마호가니";
				case 621:
					return "진주나무";
				case 622:
					return "흑단나무 벽면";
				case 623:
					return "마호가니 벽면";
				case 624:
					return "진주나무 벽면";
				case 625:
					return "흑단나무 상자";
				case 626:
					return "마호가니 상자";
				case 627:
					return "진주나무 상자";
				case 628:
					return "흑단나무 의자";
				case 629:
					return "마호가니 의자";
				case 630:
					return "진주나무 의자";
				case 631:
					return "흑단나무 플랫폼";
				case 632:
					return "마호가니 플랫폼";
				case 633:
					return "진주나무 플랫폼";
				case 634:
					return "뼈 플랫폼";
				case 635:
					return "흑단나무 작업대";
				case 636:
					return "마호가니 작업대";
				case 637:
					return "진주나무 작업대";
				case 638:
					return "흑단나무 탁자";
				case 639:
					return "마호가니 탁자";
				case 640:
					return "진주나무 탁자";
				case 641:
					return "흑단나무 피아노";
				case 642:
					return "마호가니 피아노";
				case 643:
					return "진주나무 피아노";
				case 644:
					return "흑단나무 침대";
				case 645:
					return "마호가니 침대";
				case 646:
					return "진주나무 침대";
				case 647:
					return "흑단나무 옷장";
				case 648:
					return "마호가니 옷장";
				case 649:
					return "진주나무 옷장";
				case 650:
					return "흑단나무 문";
				case 651:
					return "마호가니 문";
				case 652:
					return "진주나무 문";
				case 653:
					return "흑단나무 검";
				case 654:
					return "흑단나무 망치";
				case 655:
					return "흑단나무 활";
				case 656:
					return "마호가니 검";
				case 657:
					return "마호가니 망치";
				case 658:
					return "마호가니 활";
				case 659:
					return "진주나무 검";
				case 660:
					return "진주나무 망치";
				case 661:
					return "진주나무 활";
				case 662:
					return "무지개 벽돌";
				case 663:
					return "무지개 벽돌 벽면";
				case 664:
					return "얼음 블럭";
				case 665:
					return "Red의 날개";
				case 666:
					return "Red의 투구";
				case 667:
					return "Red의 흉갑";
				case 668:
					return "Red의 각반";
				case 669:
					return "물고기";
				case 670:
					return "얼음 부메랑";
				case 671:
					return "열쇠검";
				case 672:
					return "커틀러스";
				case 673:
					return "아한대 나무 작업대";
				case 674:
					return "진정한 엑스칼리버";
				case 675:
					return "진정한 밤의 칼날";
				case 676:
					return "한기의 징표";
				case 677:
					return "아한대 나무 탁자";
				case 678:
					return "Red의 물약";
				case 679:
					return "전술 산탄총";
				case 680:
					return "담쟁이 덩굴 상자";
				case 681:
					return "얼음 상자";
				case 682:
					return "골수";
				case 683:
					return "타락한 삼지창";
				case 684:
					return "한기의 투구";
				case 685:
					return "한기의 흉갑";
				case 686:
					return "한기의 각반";
				case 687:
					return "주석 투구";
				case 688:
					return "주석 사슬갑옷";
				case 689:
					return "주석 각반";
				case 690:
					return "납 투구";
				case 691:
					return "납 사슬갑옷";
				case 692:
					return "납 각반";
				case 693:
					return "텅스텐 투구";
				case 694:
					return "텅스텐 사슬갑옷";
				case 695:
					return "텅스텐 각반";
				case 696:
					return "백금 투구";
				case 697:
					return "백금 사슬갑옷";
				case 698:
					return "백금 각반";
				case 699:
					return "주석 광석";
				case 700:
					return "납 광석";
				case 701:
					return "텅스텐 광석";
				case 702:
					return "백금 광석";
				case 703:
					return "주석 괴";
				case 704:
					return "납 괴";
				case 705:
					return "텅스텐 괴";
				case 706:
					return "백금 괴";
				case 707:
					return "주석 시계";
				case 708:
					return "텅스텐 시계";
				case 709:
					return "백금 시계";
				case 710:
					return "주석 샹들리에";
				case 711:
					return "텅스텐 샹들리에";
				case 712:
					return "백금 샹들리에";
				case 713:
					return "백금 양초";
				case 714:
					return "백금 촛대";
				case 715:
					return "백금 왕관";
				case 716:
					return "납 모루";
				case 717:
					return "주석 벽돌";
				case 718:
					return "텅스텐 벽돌";
				case 719:
					return "백금 벽돌";
				case 720:
					return "주석 벽돌 벽면";
				case 721:
					return "텅스텐 벽돌 벽면";
				case 722:
					return "백금 벽돌 벽면";
				case 723:
					return "광선 검";
				case 724:
					return "얼음의 칼날";
				case 725:
					return "얼음의 활";
				case 726:
					return "한기의 지팡이";
				case 727:
					return "나무 투구";
				case 728:
					return "나무 흉갑";
				case 729:
					return "나무 각반";
				case 730:
					return "흑단나무 투구";
				case 731:
					return "흑단나무 흉갑";
				case 732:
					return "흑단나무 각반";
				case 733:
					return "마호가니 투구";
				case 734:
					return "마호가니 흉갑";
				case 735:
					return "마호가니 각반";
				case 736:
					return "진주나무 투구";
				case 737:
					return "진주나무 흉갑";
				case 738:
					return "진주나무 각반";
				case 739:
					return "아메디스트 지팡이";
				case 740:
					return "토파즈 지팡이";
				case 741:
					return "사파이어 지팡이";
				case 742:
					return "에메랄드 지팡이";
				case 743:
					return "루비 지팡이";
				case 744:
					return "다이아몬드 지팡이";
				case 745:
					return "잔디 벽면";
				case 746:
					return "정글 벽면";
				case 747:
					return "꽃 벽면";
				case 748:
					return "제트팩";
				case 749:
					return "나비 날개";
				case 750:
					return "선인장 벽면";
				case 751:
					return "구름";
				case 752:
					return "구름 벽면";
				case 753:
					return "해초";
				case 754:
					return "룬의 모자";
				case 755:
					return "룬의 로브";
				case 756:
					return "버섯 창";
				case 757:
					return "테라 블레이드";
				case 758:
					return "유탄 발사기";
				case 759:
					return "로켓 발사기";
				case 760:
					return "근접 지뢰 발사기";
				case 761:
					return "요정의 날개";
				case 762:
					return "슬라임 블럭";
				case 763:
					return "살덩이 블럭";
				case 764:
					return "버섯 벽면";
				case 765:
					return "비 구름";
				case 766:
					return "뼈 블럭";
				case 767:
					return "한기의 슬라임 블럭";
				case 768:
					return "뼈 블럭 벽면";
				case 769:
					return "슬라임 블럭 벽면";
				case 770:
					return "살덩이 블럭 벽면";
				case 771:
					return "로켓 I";
				case 772:
					return "로켓 II";
				case 773:
					return "로켓 III";
				case 774:
					return "로켓 IV";
				case 775:
					return "아스팔트 블럭";
				case 776:
					return "코발트 곡괭이";
				case 777:
					return "미스릴 곡괭이";
				case 778:
					return "아다만타이트 곡괭이";
				case 779:
					return "정화오염장치";
				case 780:
					return "녹색 용액";
				case 781:
					return "파란색 용액";
				case 782:
					return "자주색 용액";
				case 783:
					return "진한 파란색 용액";
				case 784:
					return "빨간 용액";
				case 785:
					return "하피의 날개";
				case 786:
					return "뼈 날개";
				case 787:
					return "버섯 망치";
				case 788:
					return "파열의 쐐기풀";
				case 789:
					return "앙크 현수막";
				case 790:
					return "뱀모양 현수막";
				case 791:
					return "오메가 현수막";
				case 792:
					return "진홍 투구";
				case 793:
					return "진홍 미늘갑옷";
				case 794:
					return "진홍 각반";
				case 795:
					return "피의 도살자";
				case 796:
					return "힘줄의 화살";
				case 797:
					return "살덩이 분쇄기";
				case 798:
					return "사신의 곡괭이";
				case 799:
					return "욕망의 핏덩어리";
				case 800:
					return "장의사";
				case 801:
					return "고기완자";
				case 802:
					return "부패한 창";
				case 803:
					return "에스키모 후드";
				case 804:
					return "에스키모 코트";
				case 805:
					return "에스키모 바지";
				case 806:
					return "생나무 의자";
				case 807:
					return "선인장 의자";
				case 808:
					return "뼈 의자";
				case 809:
					return "살덩이 의자";
				case 810:
					return "버섯 의자";
				case 811:
					return "뼈 작업대";
				case 812:
					return "선인장 작업대";
				case 813:
					return "살덩이 작업대";
				case 814:
					return "버섯 작업대";
				case 815:
					return "슬라임 작업대";
				case 816:
					return "선인장 문";
				case 817:
					return "살덩이 문";
				case 818:
					return "버섯 문";
				case 819:
					return "생나무 문";
				case 820:
					return "뼈 문";
				case 821:
					return "불꽃의 날개";
				case 822:
					return "한기의 날개";
				case 823:
					return "유령의 날개";
				case 824:
					return "태양판 블럭";
				case 825:
					return "디스크 벽면";
				case 826:
					return "하늘의 의자";
				case 827:
					return "뼈 탁자";
				case 828:
					return "살덩이 탁자";
				case 829:
					return "생나무 탁자";
				case 830:
					return "하늘의 탁자";
				case 831:
					return "생나무 상자";
				case 832:
					return "생나무 지팡이";
				case 833:
					return "자주색 얼음 블럭";
				case 834:
					return "분홍 얼음 블럭";
				case 835:
					return "붉은 얼음 블럭";
				case 836:
					return "진홍석 블럭";
				case 837:
					return "하늘의 문";
				case 838:
					return "하늘의 상자";
				case 839:
					return "스팀펑크 모자";
				case 840:
					return "스팀펑크 셔츠";
				case 841:
					return "스팀펑크 바지";
				case 842:
					return "꿀벌 모자";
				case 843:
					return "꿀벌 셔츠";
				case 844:
					return "꿀벌 바지";
				case 845:
					return "세계의 현수막";
				case 846:
					return "태양의 현수막";
				case 847:
					return "중력의 현수막";
				case 848:
					return "파라오의 가면";
				case 849:
					return "작동장치";
				case 850:
					return "파란색 렌치";
				case 851:
					return "초록색 렌치";
				case 852:
					return "파란 압력판";
				case 853:
					return "노란 압력판";
				case 854:
					return "할인 카드";
				case 855:
					return "행운의 동전";
				case 856:
					return "유니콘 막대";
				case 857:
					return "모래폭풍 병";
				case 858:
					return "아한대 나무 소파";
				case 859:
					return "비치 볼";
				case 860:
					return "신화의 부적";
				case 861:
					return "달의 조개껍질";
				case 862:
					return "별의 장막";
				case 863:
					return "수상 보행 신발";
				case 864:
					return "티아라";
				case 865:
					return "공주의 드레스";
				case 866:
					return "파라오의 로브";
				case 867:
					return "초록 모자";
				case 868:
					return "버섯 모자";
				case 869:
					return "탬 오 쉔터";
				case 870:
					return "미라 가면";
				case 871:
					return "미라 셔츠";
				case 872:
					return "미라 바지";
				case 873:
					return "카우보이 모자";
				case 874:
					return "카우보이 자켓";
				case 875:
					return "카우보이 바지";
				case 876:
					return "해적 모자";
				case 877:
					return "해적 셔츠";
				case 878:
					return "해적 바지";
				case 879:
					return "바이킹 투구";
				case 880:
					return "혈석";
				case 881:
					return "선인장 검";
				case 882:
					return "선인장 곡괭이";
				case 883:
					return "얼음 벽돌";
				case 884:
					return "얼음 벽돌 벽면";
				case 885:
					return "접착식 붕대";
				case 886:
					return "갑옷 광택제";
				case 887:
					return "위석";
				case 888:
					return "눈가리개";
				case 889:
					return "고속 시계";
				case 890:
					return "확성기";
				case 891:
					return "나자르";
				case 892:
					return "비타민";
				case 893:
					return "접이식 지도";
				case 894:
					return "선인장 투구";
				case 895:
					return "선인장 흉갑";
				case 896:
					return "선인장 각반";
				case 897:
					return "힘의 장갑";
				case 898:
					return "번개의 장화";
				case 899:
					return "태양의 돌";
				case 900:
					return "달의 돌";
				case 901:
					return "갑옷 버팀대";
				case 902:
					return "약용 붕대";
				case 903:
					return "'도면'";
				case 904:
					return "반저주의 진언";
				case 905:
					return "동전 발사기";
				case 906:
					return "용암의 부적";
				case 907:
					return "흑요석 수상 보행 신발";
				case 908:
					return "용암의 장화";
				case 909:
					return "깨끗한 분수대";
				case 910:
					return "사막 분수대";
				case 911:
					return "귀신들린 나무";
				case 912:
					return "귀신들린 나무 문";
				case 913:
					return "귀신들린 나무 플랫폼";
				case 914:
					return "귀신들린 나무 상자";
				case 915:
					return "귀신들린 나무 의자";
				case 916:
					return "귀신들린 나무 작업대";
				case 917:
					return "귀신들린 나무탁자";
				case 918:
					return "귀신들린 나무 옷장";
				case 919:
					return "귀신들린 나무 피아노";
				case 920:
					return "귀신들린 나무 침대";
				case 921:
					return "귀신들린 목재 검";
				case 922:
					return "귀신들린 목재 해머";
				case 923:
					return "귀신들린 목재 활";
				case 924:
					return "귀신들린 목재 투구";
				case 925:
					return "귀신들린 목재 흉갑";
				case 926:
					return "귀신들린 목재 각반";
				case 927:
					return "귀신들린 목재 벽";
				case 928:
					return "대포";
				case 929:
					return "대포알";
				case 930:
					return "조명탄 발사기";
				case 931:
					return "조명탄";
				case 932:
					return "뼈의 지팡이";
				case 933:
					return "잎의 지팡이";
				case 934:
					return "날으는 양탄자";
				case 935:
					return "복수자의 휘장";
				case 936:
					return "기계 장갑";
				case 937:
					return "지뢰";
				case 938:
					return "성기사의 방패";
				case 939:
					return "거미줄 발사기";
				case 940:
					return "정글 분수대";
				case 941:
					return "차가운 분수대";
				case 942:
					return "오염된 분수대";
				case 943:
					return "진홍 분수대";
				case 944:
					return "신성한 분수대";
				case 945:
					return "피의 분수대";
				case 946:
					return "우산";
				case 947:
					return "녹조류 광석";
				case 948:
					return "스팀펑크 날개";
				case 949:
					return "눈뭉치";
				case 950:
					return "아이스 스케이트";
				case 951:
					return "눈뭉치 발사기";
				case 952:
					return "거미줄 덮힌 상자";
				case 953:
					return "등산용 발톱";
				case 954:
					return "고대의 철제 투구";
				case 955:
					return "고대의 황금 투구";
				case 956:
					return "고대의 그림자 투구";
				case 957:
					return "고대의 그림자 비늘갑옷";
				case 958:
					return "고대의 그림자 각반";
				case 959:
					return "고대의 죽음의 투구";
				case 960:
					return "고대의 코발트 투구";
				case 961:
					return "고대의 코발트 흉갑";
				case 962:
					return "고대의 코발트 각반";
				case 963:
					return "검은띠";
				case 964:
					return "붐스틱";
				case 965:
					return "밧줄";
				case 966:
					return "모닥불";
				case 967:
					return "마시멜로";
				case 968:
					return "나무 꽂힌 마시멜로";
				case 969:
					return "요리된 마시멜로";
				case 970:
					return "빨간 로켓";
				case 971:
					return "초록 로켓";
				case 972:
					return "파란 로켓";
				case 973:
					return "노란 로켓";
				case 974:
					return "얼음 횃불";
				case 975:
					return "못 박힌 신발";
				case 976:
					return "등산용 호랑이 발톱";
				case 977:
					return "버선";
				case 978:
					return "분홍색 에스키모 후드";
				case 979:
					return "분홍색 에스키모 코트";
				case 980:
					return "분홍색 에스키모 바지";
				case 981:
					return "분홍색 실";
				case 982:
					return "마나 재생의 띠";
				case 983:
					return "모래폭풍 풍선";
				case 984:
					return "닌자 달인의 장비";
				case 985:
					return "밧줄 묶음";
				case 986:
					return "바람총";
				case 987:
					return "눈보라병";
				case 988:
					return "서릿불 화살";
				case 989:
					return "마법이 깃든 검";
				case 990:
					return "독괭이";
				case 991:
					return "코발트 전투도끼";
				case 992:
					return "미스릴 전투도끼";
				case 993:
					return "아다만타이트 전투도끼";
				case 994:
					return "포식자의 뼈";
				case 995:
					return "혼합기";
				case 996:
					return "고기 분쇄기";
				case 997:
					return "추출기";
				case 998:
					return "응고기";
				case 999:
					return "호박석";
				case 1000:
					return "색종이 총";
				#endregion
				#region 1001 ~ 1500
				case 1001:
					return "녹조류 가면";
				case 1002:
					return "녹조류 투구";
				case 1003:
					return "녹조류 헤드기어";
				case 1004:
					return "녹조류 판금갑옷";
				case 1005:
					return "녹조류 각반";
				case 1006:
					return "녹조류 괴";
				case 1007:
					return "붉은색 염료";
				case 1008:
					return "주황색 염료";
				case 1009:
					return "노란색 염료";
				case 1010:
					return "라임색 염료";
				case 1011:
					return "초록색 염료";
				case 1012:
					return "암록색 염료";
				case 1013:
					return "청록색 염료";
				case 1014:
					return "하늘색 염료";
				case 1015:
					return "파란색 염료";
				case 1016:
					return "자주색 염료";
				case 1017:
					return "보라색 염료";
				case 1018:
					return "분홍색 염료";
				case 1019:
					return "빨간색과 검정색 염료";
				case 1020:
					return "주황색과 검정색 염료";
				case 1021:
					return "노란색과 검정색 염료";
				case 1022:
					return "라임색과 검정색 염료";
				case 1023:
					return "초록색과 검정색 염료";
				case 1024:
					return "암록색과 검정색 염료";
				case 1025:
					return "청록색과 검정색 염료";
				case 1026:
					return "하늘색과 검정색 염료";
				case 1027:
					return "파란색과 검정색 염료";
				case 1028:
					return "자주색과 검정색 염료";
				case 1029:
					return "보라색과 검정색 염료";
				case 1030:
					return "분홍색과 검정색 염료";
				case 1031:
					return "불꽃 염료";
				case 1032:
					return "불꽃색과 검정색 염료";
				case 1033:
					return "초록 불꽃 염료";
				case 1034:
					return "초록 불꽃색과 검정색 염료";
				case 1035:
					return "푸른 불꽃 염료";
				case 1036:
					return "푸른 불꽃색과 검정색 염료";
				case 1037:
					return "은빛 염료";
				case 1038:
					return "밝은 빨간색 염료";
				case 1039:
					return "밝은 주황색 염료";
				case 1040:
					return "밝은 노란색 염료";
				case 1041:
					return "밝은 라임색 염료";
				case 1042:
					return "밝은 초록색 염료";
				case 1043:
					return "밝은 암록색 염료";
				case 1044:
					return "밝은 청록색 염료";
				case 1045:
					return "밝은 하늘색 염료";
				case 1046:
					return "밝은 파란색 염료";
				case 1047:
					return "밝은 자주색 염료";
				case 1048:
					return "밝은 보라색 염료";
				case 1049:
					return "밝은 분홍색 염료";
				case 1050:
					return "검정색 염료";
				case 1051:
					return "빨간색과 은빛 염료";
				case 1052:
					return "주황색과 은빛 염료";
				case 1053:
					return "노란색과 은빛 염료";
				case 1054:
					return "라임색과 은빛 염료";
				case 1055:
					return "초록색과 은빛 염료";
				case 1056:
					return "암록색과 은빛 염료";
				case 1057:
					return "청록색과 은빛 염료";
				case 1058:
					return "하늘색과 은빛 염료";
				case 1059:
					return "파란색과 은빛 염료";
				case 1060:
					return "자주색과 은빛 염료";
				case 1061:
					return "보라색과 은빛 염료";
				case 1062:
					return "분홍색과 은빛 염료";
				case 1063:
					return "강렬한 불꽃 염료";
				case 1064:
					return "강렬한 초록 불꽃 염료";
				case 1065:
					return "강렬한 푸른 불꽃 염료";
				case 1066:
					return "무지개 염료";
				case 1067:
					return "강렬한 무지개 염료";
				case 1068:
					return "노란색 그라데이션 염료";
				case 1069:
					return "청록색 그라데이션 염료";
				case 1070:
					return "보라색 그라데이션 염료";
				case 1071:
					return "페인트붓";
				case 1072:
					return "페인트 롤러";
				case 1073:
					return "빨간색 페인트";
				case 1074:
					return "주황색 페인트";
				case 1075:
					return "노란색 페인트";
				case 1076:
					return "라임색 페인트";
				case 1077:
					return "초록색 페인트";
				case 1078:
					return "암록색 페인트";
				case 1079:
					return "청록색 페인트";
				case 1080:
					return "하늘색 페인트";
				case 1081:
					return "파란색 페인트";
				case 1082:
					return "자주색 페인트";
				case 1083:
					return "보라색 페인트";
				case 1084:
					return "분홍색 페인트";
				case 1085:
					return "진한 빨간색 페인트";
				case 1086:
					return "진한 주황색 페인트";
				case 1087:
					return "진한 노란색 페인트";
				case 1088:
					return "진한 라임색 페인트";
				case 1089:
					return "진한 초록색 페인트";
				case 1090:
					return "진한 암록색 페인트";
				case 1091:
					return "진한 청록색 페인트";
				case 1092:
					return "진한 하늘색 페인트";
				case 1093:
					return "진한 파란색 페인트";
				case 1094:
					return "진한 자주색 페인트";
				case 1095:
					return "진한 보라색 페인트";
				case 1096:
					return "진한 분홍색 페인트";
				case 1097:
					return "검정색 페인트";
				case 1098:
					return "하얀색 페인트";
				case 1099:
					return "회색 페인트";
				case 1100:
					return "페인트 긁개";
				case 1101:
					return "리자드 벽돌";
				case 1102:
					return "리자드 벽돌 벽면";
				case 1103:
					return "진창눈 블럭";
				case 1104:
					return "팔라듐 광석";
				case 1105:
					return "오리칼쿰 광석";
				case 1106:
					return "티타늄 광석";
				case 1107:
					return "암록색 버섯";
				case 1108:
					return "녹색 버섯";
				case 1109:
					return "하늘색 꽃";
				case 1110:
					return "노란색 홍황초";
				case 1111:
					return "블루베리";
				case 1112:
					return "라임색 해초";
				case 1113:
					return "분홍 백년초";
				case 1114:
					return "주황색 혈근초";
				case 1115:
					return "빨간색 겉껍질";
				case 1116:
					return "청록색 겉껍질";
				case 1117:
					return "보라색 겉껍질";
				case 1118:
					return "자주색 점액";
				case 1119:
					return "검은 잉크";
				case 1120:
					return "염료통";
				case 1121:
					return "꿀벌 총";
				case 1122:
					return "귀신들린 손도끼";
				case 1123:
					return "꿀벌 파수꾼";
				case 1124:
					return "벌집";
				case 1125:
					return "꿀 블럭";
				case 1126:
					return "벌집 벽면";
				case 1127:
					return "바삭한 꿀 블럭";
				case 1128:
					return "꿀 양동이";
				case 1129:
					return "벌집 지팡이";
				case 1130:
					return "꿀벌수류탄";
				case 1131:
					return "중력 글로브";
				case 1132:
					return "벌집 조각";
				case 1133:
					return "혐오스러운 꿀벌";
				case 1134:
					return "꿀병";
				case 1135:
					return "우비 모자";
				case 1136:
					return "우비";
				case 1137:
					return "리자드 문";
				case 1138:
					return "던전 문";
				case 1139:
					return "납 문";
				case 1140:
					return "철제 문";
				case 1141:
					return "사원 열쇠";
				case 1142:
					return "리자드 상자";
				case 1143:
					return "리자드 의자";
				case 1144:
					return "리자드 탁자";
				case 1145:
					return "리자드 작업대";
				case 1146:
					return "슈퍼 다트 함정";
				case 1147:
					return "불꽃 함정";
				case 1148:
					return "뾰족뾰족 구슬 함정";
				case 1149:
					return "창 함정";
				case 1150:
					return "나무 대못";
				case 1151:
					return "리자드 압력판";
				case 1152:
					return "리자드 동상";
				case 1153:
					return "리자드 감시꾼 동상";
				case 1154:
					return "리자드 수호자 동상";
				case 1155:
					return "말벌 총";
				case 1156:
					return "피라냐 총";
				case 1157:
					return "난쟁이 지팡이";
				case 1158:
					return "난쟁이 목걸이";
				case 1159:
					return "티키 가면";
				case 1160:
					return "티키 셔츠";
				case 1161:
					return "티키 바지";
				case 1162:
					return "나뭇잎 날개";
				case 1163:
					return "눈보라 풍선";
				case 1164:
					return "풍선 다발";
				case 1165:
					return "박쥐의 날개";
				case 1166:
					return "뼈 검";
				case 1167:
					return "헤라클레스 딱정벌레";
				case 1168:
					return "연막탄";
				case 1169:
					return "뼈다귀 열쇠";
				case 1170:
					return "꽃꿀";
				case 1171:
					return "티키 토템";
				case 1172:
					return "리자드의 알";
				case 1173:
					return "묘비";
				case 1174:
					return "십자가 묘비";
				case 1175:
					return "주춧돌";
				case 1176:
					return "비석";
				case 1177:
					return "오벨리스크";
				case 1178:
					return "잎사귀 송풍기";
				case 1179:
					return "녹조류 총알";
				case 1180:
					return "앵무새 크래커";
				case 1181:
					return "이상한 발광 버섯";
				case 1182:
					return "묘목";
				case 1183:
					return "병 속에 도깨비불";
				case 1184:
					return "팔라듐 괴";
				case 1185:
					return "팔라듐 검";
				case 1186:
					return "팔라듐 단창";
				case 1187:
					return "팔라듐 연발궁";
				case 1188:
					return "팔라듐 곡괭이";
				case 1189:
					return "팔라듐 드릴";
				case 1190:
					return "팔라듐 전기톱";
				case 1191:
					return "오리칼쿰 괴";
				case 1192:
					return "오리칼쿰 검";
				case 1193:
					return "오리칼쿰 미늘창";
				case 1194:
					return "오리칼쿰 연발궁";
				case 1195:
					return "오리칼쿰 곡괭이";
				case 1196:
					return "오리칼쿰 드릴";
				case 1197:
					return "오리칼쿰 전기톱";
				case 1198:
					return "티타늄 괴";
				case 1199:
					return "티타늄 검";
				case 1200:
					return "티타늄 삼지창";
				case 1201:
					return "티타늄 연발궁";
				case 1202:
					return "티타늄 곡괭이";
				case 1203:
					return "티타늄 드릴";
				case 1204:
					return "티타늄 전기톱";
				case 1205:
					return "팔라듐 가면";
				case 1206:
					return "팔라듐 투구";
				case 1207:
					return "팔라듐 헤드기어";
				case 1208:
					return "팔라듐 흉갑";
				case 1209:
					return "팔라듐 각반";
				case 1210:
					return "오리칼쿰 가면";
				case 1211:
					return "오리칼쿰 투구";
				case 1212:
					return "오리칼쿰 헤드기어";
				case 1213:
					return "오리칼쿰 흉갑";
				case 1214:
					return "오리칼쿰 각반";
				case 1215:
					return "티타늄 가면";
				case 1216:
					return "티타늄 투구";
				case 1217:
					return "티타늄 헤드기어";
				case 1218:
					return "티타늄 흉갑";
				case 1219:
					return "티타늄 각반";
				case 1220:
					return "오리칼쿰 모루";
				case 1221:
					return "티타늄 화로";
				case 1222:
					return "팔라듐 전투도끼";
				case 1223:
					return "오리칼쿰 전투도끼";
				case 1224:
					return "티타늄 전투도끼";
				case 1225:
					return "신성한 괴";
				case 1226:
					return "녹조류 크레이모어";
				case 1227:
					return "녹조류 세이버";
				case 1228:
					return "녹조류 파르티잔";
				case 1229:
					return "녹조류 단궁";
				case 1230:
					return "녹조류 곡괭이";
				case 1231:
					return "녹조류 드릴";
				case 1232:
					return "녹조류 전기톱";
				case 1233:
					return "녹조류 거대도끼";
				case 1234:
					return "녹조류 전투망치";
				case 1235:
					return "녹조류 화살";
				case 1236:
					return "아메디스트 갈고리";
				case 1237:
					return "토파즈 갈고리";
				case 1238:
					return "사파이어 갈고리";
				case 1239:
					return "에메랄드 갈고리";
				case 1240:
					return "루비 갈고리";
				case 1241:
					return "다이아몬드 갈고리";
				case 1242:
					return "모기 호박";
				case 1243:
					return "우산 모자";
				case 1244:
					return "비구름 지팡이";
				case 1245:
					return "주황색 횃불";
				case 1246:
					return "진홍모래 블럭";
				case 1247:
					return "꿀벌 망토";
				case 1248:
					return "골렘의 눈";
				case 1249:
					return "꿀 풍선";
				case 1250:
					return "파란 말편자 풍선";
				case 1251:
					return "하얀 말편자 풍선";
				case 1252:
					return "노란 말편자 풍선";
				case 1253:
					return "얼어붙은 거북등껍질";
				case 1254:
					return "저격소총";
				case 1255:
					return "비너스 매그넘";
				case 1256:
					return "진홍색 지팡이";
				case 1257:
					return "혈석 괴";
				case 1258:
					return "스틴저";
				case 1259:
					return "꽃의 힘";
				case 1260:
					return "무지개 총";
				case 1261:
					return "스틴저 볼트";
				case 1262:
					return "녹조류 착암기";
				case 1263:
					return "순간이동기";
				case 1264:
					return "한기의 꽃";
				case 1265:
					return "우지";
				case 1266:
					return "자석 구체";
				case 1267:
					return "자주색 착색 유리";
				case 1268:
					return "노란 착색 유리";
				case 1269:
					return "파란 착색 유리";
				case 1270:
					return "초록 착색 유리";
				case 1271:
					return "빨간 착색 유리";
				case 1272:
					return "다채색 착색 유리";
				case 1273:
					return "스켈레트론의 손";
				case 1274:
					return "해골";
				case 1275:
					return "벨라의 모자";
				case 1276:
					return "갱스터 모자";
				case 1277:
					return "세일러 모자";
				case 1278:
					return "안대";
				case 1279:
					return "세일러 셔츠";
				case 1280:
					return "세일러 바지";
				case 1281:
					return "스켈레트론 가면";
				case 1282:
					return "아메디스트 로브";
				case 1283:
					return "토파즈 로브";
				case 1284:
					return "사파이어 로브";
				case 1285:
					return "에메랄드 로브";
				case 1286:
					return "루비 로브";
				case 1287:
					return "다이아몬드 로브";
				case 1288:
					return "하얀색 턱시도 셔츠";
				case 1289:
					return "하얀색 턱시도 바지";
				case 1290:
					return "혼란의 목걸이";
				case 1291:
					return "생명의 열매";
				case 1292:
					return "리자드 제단";
				case 1293:
					return "리자드 전원 전지";
				case 1294:
					return "톱괭이";
				case 1295:
					return "고열 광선";
				case 1296:
					return "땅의 지팡이";
				case 1297:
					return "골렘의 주먹";
				case 1298:
					return "물의 상자";
				case 1299:
					return "쌍안경";
				case 1300:
					return "소총 조준경";
				case 1301:
					return "파괴자의 휘장";
				case 1302:
					return "고속 총알";
				case 1303:
					return "해파리 목걸이";
				case 1304:
					return "좀비의 팔";
				case 1305:
					return "'도끼'";
				case 1306:
					return "얼음의 낫";
				case 1307:
					return "의류상의 부두 인형";
				case 1308:
					return "독 지팡이";
				case 1309:
					return "슬라임의 지팡이";
				case 1310:
					return "독 다트";
				case 1311:
					return "눈알 용수철";
				case 1312:
					return "장난감 썰매";
				case 1313:
					return "해골의 책";
				case 1314:
					return "KO 대포";
				case 1315:
					return "해적 지도";
				case 1316:
					return "거북이 투구";
				case 1317:
					return "거북이 비늘갑옷";
				case 1318:
					return "거북이 각반";
				case 1319:
					return "눈덩이 대포";
				case 1320:
					return "뼈 곡괭이";
				case 1321:
					return "마법의 화살통";
				case 1322:
					return "용암석";
				case 1323:
					return "흑요석 장미";
				case 1324:
					return "바나나랑";
				case 1325:
					return "쇠사슬 단검";
				case 1326:
					return "불화의 지팡이";
				case 1327:
					return "죽음의 낫";
				case 1328:
					return "거북이 등껍질";
				case 1329:
					return "조직 샘플";
				case 1330:
					return "척추뼈";
				case 1331:
					return "피 묻은 척추";
				case 1332:
					return "이코르";
				case 1333:
					return "이코르 횃불";
				case 1334:
					return "이코르 화살";
				case 1335:
					return "이코르 총알";
				case 1336:
					return "골든 샤워";
				case 1337:
					return "토끼 대포";
				case 1338:
					return "폭발성 토끼";
				case 1339:
					return "맹독의 물약";
				case 1340:
					return "맹독의 플라스크";
				case 1341:
					return "맹독의 화살";
				case 1342:
					return "맹독의 총알";
				case 1343:
					return "화염의 건틀릿";
				case 1344:
					return "톱니";
				case 1345:
					return "색종이";
				case 1346:
					return "나노머신";
				case 1347:
					return "폭약";
				case 1348:
					return "금가루";
				case 1349:
					return "파티 총알";
				case 1350:
					return "나노 총알";
				case 1351:
					return "폭발하는 총알";
				case 1352:
					return "황금빛 총알";
				case 1353:
					return "저주받은 불꽃의 플라스크";
				case 1354:
					return "불의 플라스크";
				case 1355:
					return "황금의 플라스크";
				case 1356:
					return "이코르의 플라스크";
				case 1357:
					return "나노머신의 플라스크";
				case 1358:
					return "파티의 플라스크";
				case 1359:
					return "독의 플라스크";
				case 1360:
					return "크툴후의 눈 전리품";
				case 1361:
					return "세상을 먹는 자 전리품";
				case 1362:
					return "크툴후의 뇌 전리품";
				case 1363:
					return "스켈레트론 전리품";
				case 1364:
					return "여왕 벌 전리품";
				case 1365:
					return "육체의 벽 전리품";
				case 1366:
					return "파괴자 전리품";
				case 1367:
					return "스켈레트론 프라임 전리품";
				case 1368:
					return "레티나이저 전리품";
				case 1369:
					return "스파즈나티즘 전리품";
				case 1370:
					return "플렌테라 전리품";
				case 1371:
					return "골렘 전리품";
				case 1372:
					return "떠오르는 피의 달";
				case 1373:
					return "매달린 사람";
				case 1374:
					return "불의 영광";
				case 1375:
					return "구부린 뼈";
				case 1376:
					return "벽 해골";
				case 1377:
					return "매달린 해골";
				case 1378:
					return "파란색 슬라브 벽면";
				case 1379:
					return "파란색 타일 벽면";
				case 1380:
					return "분홍색 슬라브 벽면";
				case 1381:
					return "분홍색 타일 벽면";
				case 1382:
					return "녹색 슬라브 벽면";
				case 1383:
					return "녹색 타일 벽면";
				case 1384:
					return "파란 벽돌 플랫폼";
				case 1385:
					return "분홍 벽돌 플랫폼";
				case 1386:
					return "녹색 벽돌 플랫폼";
				case 1387:
					return "금속 선반";
				case 1388:
					return "놋쇠 선반";
				case 1389:
					return "나무 선반";
				case 1390:
					return "놋쇠 랜턴";
				case 1391:
					return "새장형 랜턴";
				case 1392:
					return "운반용 랜턴";
				case 1393:
					return "연금술의 랜턴";
				case 1394:
					return "디아볼리스트 랜턴";
				case 1395:
					return "기름 적신 벽전등";
				case 1396:
					return "파란색 던전 의자";
				case 1397:
					return "파란색 던전 탁자";
				case 1398:
					return "파란색 던전 작업대";
				case 1399:
					return "녹색 던전 의자";
				case 1400:
					return "녹색 던전 탁자";
				case 1401:
					return "녹색 던전 작업대";
				case 1402:
					return "분홍색 던전 의자";
				case 1403:
					return "분홍색 던전 탁자";
				case 1404:
					return "분홍색 던전 작업대";
				case 1405:
					return "파란색 던전 양초";
				case 1406:
					return "녹색 던전 양초";
				case 1407:
					return "분홍색 던전 양초";
				case 1408:
					return "파란색 던전 꽃병";
				case 1409:
					return "녹색 던전 꽃병";
				case 1410:
					return "분홍색 던전 꽃병";
				case 1411:
					return "파란색 던전 문";
				case 1412:
					return "녹색 던전 문";
				case 1413:
					return "분홍색 던전 문";
				case 1414:
					return "파란색 던전 책장";
				case 1415:
					return "녹색 던전 책장";
				case 1416:
					return "분홍색 던전 책장";
				case 1417:
					return "지하묘지";
				case 1418:
					return "던전 선반";
				case 1419:
					return "뼉다구 제이 땅그지' 씨";
				case 1420:
					return "저주받은 사람";
				case 1421:
					return "종말을 보는 눈";
				case 1422:
					return "때때로 악은 당신을 주시한다";
				case 1423:
					return "깨어난 쌍둥이";
				case 1424:
					return "비명지르는 자";
				case 1425:
					return "포커치는 고블린들";
				case 1426:
					return "위대한 드라이어드에 관하여";
				case 1427:
					return "해바라기";
				case 1428:
					return "테라리아풍 고딕양식";
				case 1429:
					return "비니";
				case 1430:
					return "주입기";
				case 1431:
					return "병 속에 별";
				case 1432:
					return "빈 총알";
				case 1433:
					return "경계";
				case 1434:
					return "새 발전기";
				case 1435:
					return "'파괴자'";
				case 1436:
					return "두 눈의 불멸성";
				case 1437:
					return "신성한 땅을 가로지르는 유니콘";
				case 1438:
					return "거친 파도의 테라리아";
				case 1439:
					return "별이 빛나는 밤";
				case 1440:
					return "가이드 피카소";
				case 1441:
					return "'수호자의 시선'";
				case 1442:
					return "누군가의 아버지";
				case 1443:
					return "간호리자";
				case 1444:
					return "그림자광선 지팡이";
				case 1445:
					return "지옥화염의 쇠스랑";
				case 1446:
					return "유령 지팡이";
				case 1447:
					return "나무 울타리";
				case 1448:
					return "납 울타리";
				case 1449:
					return "비눗방울 기계";
				case 1450:
					return "비눗방울 지팡이";
				case 1451:
					return "행군하는 해골들의 현수막";
				case 1452:
					return "사령술사의 기호";
				case 1453:
					return "녹슨 중대의 기준";
				case 1454:
					return "너덜너덜한 형제의 인장";
				case 1455:
					return "녹아버린 군단의 깃발";
				case 1456:
					return "악마의 인장";
				case 1457:
					return "흑요석 플랫폼";
				case 1458:
					return "흑요석 문";
				case 1459:
					return "흑요석 의자";
				case 1460:
					return "흑요석 탁자";
				case 1461:
					return "흑요석 작업대";
				case 1462:
					return "흑요석 꽃병";
				case 1463:
					return "흑요석 책장";
				case 1464:
					return "헬바운드 현수막";
				case 1465:
					return "지옥의 망치 현수막";
				case 1466:
					return "지옥의 탑 현수막";
				case 1467:
					return "인간의 잃어버린 희망 현수막";
				case 1468:
					return "흑요석 감시자 현수막";
				case 1469:
					return "용암 분출 현수막";
				case 1470:
					return "파란색 던전 침대";
				case 1471:
					return "녹색 던전 침대";
				case 1472:
					return "분홍색 던전 침대";
				case 1473:
					return "흑요석 침대";
				case 1474:
					return "월리";
				case 1475:
					return "심연";
				case 1476:
					return "영혼을 거두는 자";
				case 1477:
					return "대지";
				case 1478:
					return "갇힌 유령";
				case 1479:
					return "악마의 눈";
				case 1480:
					return "금광 발견";
				case 1481:
					return "첫 만남";
				case 1482:
					return "좋은 아침";
				case 1483:
					return "탐험의 보상";
				case 1484:
					return "창문 너머";
				case 1485:
					return "구름 위에 놓인 섬";
				case 1486:
					return "잔디를 밟지 마세요";
				case 1487:
					return "백색의 땅";
				case 1488:
					return "빛이 들지 않는 협곡";
				case 1489:
					return "기만의 땅";
				case 1490:
					return "해돋이";
				case 1491:
					return "모래의 비밀";
				case 1492:
					return "신나는 불모지 여행";
				case 1493:
					return "사악한 존재";
				case 1494:
					return "하늘의 수호자";
				case 1495:
					return "미국식 폭발물";
				case 1496:
					return "발견";
				case 1497:
					return "토지";
				case 1498:
					return "늙은 광부";
				case 1499:
					return "두개골";
				case 1500:
					return "뇌와의 대면";
				#endregion
				#region 1501 ~ 2000
				case 1501:
					return "용암 호수";
				case 1502:
					return "슈퍼 히어로 삼인조";
				case 1503:
					return "유령의 후드";
				case 1504:
					return "유령의 로브";
				case 1505:
					return "유령의 바지";
				case 1506:
					return "유령의 곡괭이";
				case 1507:
					return "유령의 날망치";
				case 1508:
					return "심령체";
				case 1509:
					return "고딕 의자";
				case 1510:
					return "고딕 탁자";
				case 1511:
					return "고딕 작업대";
				case 1512:
					return "고딕 책장";
				case 1513:
					return "성기사의 망치";
				case 1514:
					return "SWAT 헬멧";
				case 1515:
					return "꿀벌의 날개";
				case 1516:
					return "커다란 하피 깃털";
				case 1517:
					return "뼈 깃털";
				case 1518:
					return "불 깃털";
				case 1519:
					return "얼음 깃털";
				case 1520:
					return "찢어진 박쥐 날개";
				case 1521:
					return "너덜거리는 꿀벌 날개";
				case 1522:
					return "커다란 아메디스트";
				case 1523:
					return "커다란 토파즈";
				case 1524:
					return "커다란 사파이어";
				case 1525:
					return "커다란 에메랄드";
				case 1526:
					return "커다란 루비";
				case 1527:
					return "커다란 다이아몬드";
				case 1528:
					return "정글 상자";
				case 1529:
					return "부패된 상자";
				case 1530:
					return "진홍의 상자";
				case 1531:
					return "신성한 상자";
				case 1532:
					return "한기의 상자";
				case 1533:
					return "정글 열쇠";
				case 1534:
					return "부패된 열쇠";
				case 1535:
					return "진홍의 열쇠";
				case 1536:
					return "신성한 열쇠";
				case 1537:
					return "한기의 열쇠";
				case 1538:
					return "불도깨비의 얼굴";
				case 1539:
					return "불길한 존재";
				case 1540:
					return "빛나는 달";
				case 1541:
					return "살아있는 공포";
				case 1542:
					return "흐르는 용암";
				case 1543:
					return "유령의 페인트붓";
				case 1544:
					return "유령의 페인트 롤러";
				case 1545:
					return "유령의 페인트 긁개";
				case 1546:
					return "슈루마이트 헤드기어";
				case 1547:
					return "슈루마이트 가면";
				case 1548:
					return "슈루마이트 투구";
				case 1549:
					return "슈루마이트 흉갑";
				case 1550:
					return "슈루마이트 각반";
				case 1551:
					return "오토해머";
				case 1552:
					return "슈루마이트 괴";
				case 1553:
					return "S.D.M.G.";
				case 1554:
					return "Cenx의 티아라";
				case 1555:
					return "Cenx의 흉갑";
				case 1556:
					return "Cenx의 각반";
				case 1557:
					return "Crowno의 가면";
				case 1558:
					return "Crowno의 흉갑";
				case 1559:
					return "Crowno의 각반";
				case 1560:
					return "Will의 투구";
				case 1561:
					return "Will의 흉갑";
				case 1562:
					return "Will의 각반";
				case 1563:
					return "Jim의 투구";
				case 1564:
					return "Jim의 흉갑";
				case 1565:
					return "Jim의 각반";
				case 1566:
					return "Aaron의 투구";
				case 1567:
					return "Aaron의 흉갑";
				case 1568:
					return "Aaron의 각반";
				case 1569:
					return "흡혈귀의 칼";
				case 1570:
					return "부러진 영웅의 검";
				case 1571:
					return "타락귀의 재앙";
				case 1572:
					return "얼어붙은 히드라의 지팡이";
				case 1573:
					return "가이드의 창조";
				case 1574:
					return "'상인'";
				case 1575:
					return "점심을 먹어치우는 Crowno";
				case 1576:
					return "희귀한 주술";
				case 1577:
					return "아름다운 밤풍경 ";
				case 1578:
					return "연인의 목걸이";
				case 1579:
					return "질풍의 장화";
				case 1580:
					return "D-Town의 투구";
				case 1581:
					return "D-Town의 흉갑";
				case 1582:
					return "D-Town의 각반";
				case 1583:
					return "D-Town의 날개";
				case 1584:
					return "Will의 날개";
				case 1585:
					return "Crowno의 날개";
				case 1586:
					return "Cenx의 날개";
				case 1587:
					return "Cenx의 드레스";
				case 1588:
					return "Cenx의 드레스 바지";
				case 1589:
					return "팔라듐 원형기둥";
				case 1590:
					return "팔라듐 원형기둥 벽면";
				case 1591:
					return "풍선껌 블럭";
				case 1592:
					return "풍선껌 블럭 벽면";
				case 1593:
					return "티탄암 블럭";
				case 1594:
					return "티탄암 블럭 벽면";
				case 1595:
					return "마법의 수갑";
				case 1596:
					return "음악 상자 (Snow)";
				case 1597:
					return "음악 상자 (Space)";
				case 1598:
					return "음악 상자 (Crimson)";
				case 1599:
					return "음악 상자 (Boss 4)";
				case 1600:
					return "음악 상자 (Alt Overworld Day)";
				case 1601:
					return "음악 상자 (Rain)";
				case 1602:
					return "음악 상자 (Ice)";
				case 1603:
					return "음악 상자 (Desert)";
				case 1604:
					return "음악 상자 (Ocean)";
				case 1605:
					return "음악 상자 (Dungeon)";
				case 1606:
					return "음악 상자 (Plantera)";
				case 1607:
					return "음악 상자 (Boss 5)";
				case 1608:
					return "음악 상자 (Temple)";
				case 1609:
					return "음악 상자 (Eclipse)";
				case 1610:
					return "음악 상자 (Mushrooms)";
				case 1611:
					return "나비 가루";
				case 1612:
					return "앙크 부적";
				case 1613:
					return "앙크 방패";
				case 1614:
					return "파란 조명탄";
				case 1615:
					return "아귀 현수막";
				case 1616:
					return "화난 비구름 현수막";
				case 1617:
					return "버섯 집게 현수막";
				case 1618:
					return "개미귀신 현수막";
				case 1619:
					return "피라루쿠 현수막";
				case 1620:
					return "무장한 해골 현수막";
				case 1621:
					return "박쥐 현수막";
				case 1622:
					return "새 현수막";
				case 1623:
					return "검은 은둔자 현수막";
				case 1624:
					return "블러드 피더 현수막";
				case 1625:
					return "블러드 젤리 현수막";
				case 1626:
					return "블러드 크롤러 현수막";
				case 1627:
					return "뼈다귀 뱀  현수막";
				case 1628:
					return "토끼 현수막";
				case 1629:
					return "혼돈의 정령 현수막";
				case 1630:
					return "미믹 현수막";
				case 1631:
					return "광대 현수막";
				case 1632:
					return "타락한 토끼 현수막";
				case 1633:
					return "타락한 금붕어 현수막";
				case 1634:
					return "게 현수막";
				case 1635:
					return "크리메라 현수막";
				case 1636:
					return "진홍의 도끼 현수막";
				case 1637:
					return "저주받은 망치 현수막";
				case 1638:
					return "악마 현수막";
				case 1639:
					return "악마의 눈 현수막";
				case 1640:
					return "더플링 현수막";
				case 1641:
					return "영혼을 먹는 자 현수막";
				case 1642:
					return "마법이 깃든 검 현수막";
				case 1643:
					return "좀비 에스키모 현수막";
				case 1644:
					return "얼굴 괴물 현수막";
				case 1645:
					return "플로티 그로스 현수막";
				case 1646:
					return "날치 현수막";
				case 1647:
					return "날아다니는 뱀 현수막";
				case 1648:
					return "프랑켄슈타인 현수막";
				case 1649:
					return "버섯 구근 현수막";
				case 1650:
					return "버섯 해파리 현수막";
				case 1651:
					return "복족류 현수막";
				case 1652:
					return "고블린 궁수 현수막";
				case 1653:
					return "고블린 마법사 현수막";
				case 1654:
					return "고블린 정찰병 현수막";
				case 1655:
					return "고블린 도적 현수막";
				case 1656:
					return "고블린 전사 현수막";
				case 1657:
					return "금붕어 현수막";
				case 1658:
					return "하피 현수막";
				case 1659:
					return "지옥박쥐 현수막";
				case 1660:
					return "허플링 현수막";
				case 1661:
					return "말벌 현수막";
				case 1662:
					return "얼음 정령 현수막";
				case 1663:
					return "얼음에 뒤덮힌 인어 현수막";
				case 1664:
					return "불도깨비 현수막";
				case 1665:
					return "해파리 현수막";
				case 1666:
					return "정글 크리퍼 현수막";
				case 1667:
					return "리자드 현수막";
				case 1668:
					return "식인식물 현수막";
				case 1669:
					return "운석 머리 현수막";
				case 1670:
					return "나방 현수막";
				case 1671:
					return "미라 현수막";
				case 1672:
					return "무시 무당벌레 현수막";
				case 1673:
					return "앵무새 현수막";
				case 1674:
					return "피그론 현수막";
				case 1675:
					return "피라냐 현수막";
				case 1676:
					return "해적 현수막";
				case 1677:
					return "픽시 현수막";
				case 1678:
					return "우비 좀비 현수막";
				case 1679:
					return "사신 현수막";
				case 1680:
					return "상어 현수막";
				case 1681:
					return "해골 현수막";
				case 1682:
					return "해골 마법사 현수막";
				case 1683:
					return "슬라임 현수막";
				case 1684:
					return "스노우 플링스 현수막";
				case 1685:
					return "거미 현수막";
				case 1686:
					return "포자 좀비 현수막";
				case 1687:
					return "정체불명의 늪생물 현수막";
				case 1688:
					return "거북이 현수막";
				case 1689:
					return "독성 진흙 현수막";
				case 1690:
					return "우산 슬라임 현수막";
				case 1691:
					return "유니콘 현수막";
				case 1692:
					return "흡혈귀 현수막";
				case 1693:
					return "대머리 독수리 현수막";
				case 1694:
					return "님프 현수막";
				case 1695:
					return "늑대인간 현수막";
				case 1696:
					return "늑대 현수막";
				case 1697:
					return "월드 피더 현수막";
				case 1698:
					return "지렁이 현수막";
				case 1699:
					return "망령 현수막";
				case 1700:
					return "와이번 현수막";
				case 1701:
					return "좀비 현수막";
				case 1702:
					return "유리 플랫폼";
				case 1703:
					return "유리 의자";
				case 1704:
					return "황금 의자";
				case 1705:
					return "황금 화장실";
				case 1706:
					return "바 의자";
				case 1707:
					return "꿀 의자";
				case 1708:
					return "스팀펑크 의자";
				case 1709:
					return "유리 문";
				case 1710:
					return "황금 문";
				case 1711:
					return "꿀 문";
				case 1712:
					return "스팀펑크 문";
				case 1713:
					return "유리 탁자";
				case 1714:
					return "연회 탁자";
				case 1715:
					return "바";
				case 1716:
					return "황금 탁자";
				case 1717:
					return "꿀 탁자";
				case 1718:
					return "스팀펑크 탁자";
				case 1719:
					return "유리 침대";
				case 1720:
					return "황금 침대";
				case 1721:
					return "꿀 침대";
				case 1722:
					return "스팀펑크 침대";
				case 1723:
					return "생나무 벽면";
				case 1724:
					return "항아리 속에 방귀";
				case 1725:
					return "호박 ";
				case 1726:
					return "호박 벽면";
				case 1727:
					return "건초";
				case 1728:
					return "건초 벽면";
				case 1729:
					return "으스스한 나무";
				case 1730:
					return "으스스한 나무 벽면";
				case 1731:
					return "호박 투구";
				case 1732:
					return "호박 흉갑";
				case 1733:
					return "호박 각반";
				case 1734:
					return "사과 사탕";
				case 1735:
					return "영혼 케이크";
				case 1736:
					return "간호사 모자";
				case 1737:
					return "간호사 셔츠";
				case 1738:
					return "간호사 바지";
				case 1739:
					return "마법사의 모자";
				case 1740:
					return "가이 포크스 가면";
				case 1741:
					return "염료상 로브";
				case 1742:
					return "스팀펑크 고글";
				case 1743:
					return "사이보그 투구";
				case 1744:
					return "사이보그 셔츠";
				case 1745:
					return "사이보그 바지";
				case 1746:
					return "크리퍼 가면";
				case 1747:
					return "크리퍼 셔츠";
				case 1748:
					return "크리퍼 바지";
				case 1749:
					return "고양이 가면";
				case 1750:
					return "고양이 셔츠";
				case 1751:
					return "고양이 바지";
				case 1752:
					return "유령 가면";
				case 1753:
					return "유령 셔츠";
				case 1754:
					return "호박 가면";
				case 1755:
					return "호박 셔츠";
				case 1756:
					return "호박 바지";
				case 1757:
					return "로봇 가면";
				case 1758:
					return "로봇 셔츠";
				case 1759:
					return "로봇 바지";
				case 1760:
					return "유니콘 가면";
				case 1761:
					return "유니콘 셔츠";
				case 1762:
					return "유니콘 바지";
				case 1763:
					return "흡혈귀 가면";
				case 1764:
					return "흡혈귀 셔츠";
				case 1765:
					return "흡혈귀 바지";
				case 1766:
					return "마녀의 모자";
				case 1767:
					return "작은 요정 모자";
				case 1768:
					return "작은 요정 셔츠";
				case 1769:
					return "작은 요정 바지";
				case 1770:
					return "픽시 셔츠";
				case 1771:
					return "픽시 바지";
				case 1772:
					return "공주의 모자";
				case 1773:
					return "공주의 드레스";
				case 1774:
					return "'좋아요' 백";
				case 1775:
					return "마녀의 드레스";
				case 1776:
					return "마녀의 신발";
				case 1777:
					return "프랑켄슈타인의 신부 가면";
				case 1778:
					return "프랑켄슈타인의 신부 드레스";
				case 1779:
					return "닌자거북이 가면";
				case 1780:
					return "닌자거북이 셔츠";
				case 1781:
					return "닌자거북이 바지";
				case 1782:
					return "캔디 콘 소총";
				case 1783:
					return "캔디 콘";
				case 1784:
					return "잭 오 랜턴 발사기";
				case 1785:
					return "폭발하는 잭 오 랜턴";
				case 1786:
					return "낫";
				case 1787:
					return "호박 파이";
				case 1788:
					return "허수아비 모자";
				case 1789:
					return "허수아비 셔츠";
				case 1790:
					return "허수아비 바지";
				case 1791:
					return "가마솥";
				case 1792:
					return "호박 의자";
				case 1793:
					return "호박 문";
				case 1794:
					return "호박 탁자";
				case 1795:
					return "호박 작업대";
				case 1796:
					return "호박 플랫폼";
				case 1797:
					return "너덜거리는 요정의 날개";
				case 1798:
					return "거미알";
				case 1799:
					return "마법의 호박 씨앗";
				case 1800:
					return "박쥐 갈고리";
				case 1801:
					return "박쥐의 홀";
				case 1802:
					return "갈까마귀 지팡이";
				case 1803:
					return "정글 열쇠 틀";
				case 1804:
					return "부패한 열쇠 틀";
				case 1805:
					return "진홍의 열쇠 틀";
				case 1806:
					return "신성한 열쇠 틀";
				case 1807:
					return "한기의 열쇠 틀";
				case 1808:
					return "매달린 잭 오 랜턴";
				case 1809:
					return "썩은 달걀";
				case 1810:
					return "불운의 실뭉치";
				case 1811:
					return "검은 요정의 가루";
				case 1812:
					return "잭들리에";
				case 1813:
					return "잭 오 랜턴";
				case 1814:
					return "으스스한 의자";
				case 1815:
					return "으스스한 문";
				case 1816:
					return "으스스한 탁자";
				case 1817:
					return "으스스한 작업대";
				case 1818:
					return "으스스한 플랫폼";
				case 1819:
					return "사신의 후드";
				case 1820:
					return "사신의 로브";
				case 1821:
					return "여우 가면";
				case 1822:
					return "여우 셔츠";
				case 1823:
					return "여우 바지";
				case 1824:
					return "고양이 귀";
				case 1825:
					return "피투성이 마체테";
				case 1826:
					return "머리없는 기수의 칼날";
				case 1827:
					return "칼날 장갑";
				case 1828:
					return "호박 씨";
				case 1829:
					return "으스스한 갈고리";
				case 1830:
					return "으스스한 날개";
				case 1831:
					return "으스스한 나뭇가지";
				case 1832:
					return "으스스한 투구";
				case 1833:
					return "으스스한 흉갑";
				case 1834:
					return "으스스한 각반";
				case 1835:
					return "말뚝 발사기";
				case 1836:
					return "말뚝";
				case 1837:
					return "저주받은 묘목";
				case 1838:
					return "우주 생명체 가면";
				case 1839:
					return "우주 생명체 셔츠";
				case 1840:
					return "우주 생명체 바지";
				case 1841:
					return "늑대 가면";
				case 1842:
					return "늑대 셔츠";
				case 1843:
					return "늑대 바지";
				case 1844:
					return "호박 달의 큰 메달";
				case 1845:
					return "사령의 스크롤";
				case 1846:
					return "춤추는 해골";
				case 1847:
					return "수확의 고통";
				case 1848:
					return "혈월의 여백작";
				case 1849:
					return "할로윈 전야";
				case 1850:
					return "소름끼치는 호기심의";
				case 1851:
					return "보물 사냥꾼 셔츠";
				case 1852:
					return "보물 사냥꾼 바지";
				case 1853:
					return "드라이어드 피복";
				case 1854:
					return "드라이어드 들보";
				case 1855:
					return "탄식하는 나무 전리품";
				case 1856:
					return "펌킹 전리품";
				case 1857:
					return "잭 오 랜턴 가면";
				case 1858:
					return "저격수의 조준경";
				case 1859:
					return "하트 랜턴";
				case 1860:
					return "해파리 잠수 장비";
				case 1861:
					return "북극의 잠수 장비";
				case 1862:
					return "한기의 불꽃 장화";
				case 1863:
					return "방귀 풍선";
				case 1864:
					return "파피루스 풍뎅이";
				case 1865:
					return "천상의 돌";
				case 1866:
					return "호버보드";
				case 1867:
					return "사탕 지팡이";
				case 1868:
					return "설탕 자두";
				case 1869:
					return "선물 상자";
				case 1870:
					return "레드 라이더";
				case 1871:
					return "축제의 날개";
				case 1872:
					return "소나무 블럭";
				case 1873:
					return "크리스마스 트리";
				case 1874:
					return "트리 별장식 1";
				case 1875:
					return "트리 별장식 2";
				case 1876:
					return "트리 별장식 3";
				case 1877:
					return "트리 리본 장식";
				case 1878:
					return "하얀색 화환";
				case 1879:
					return "하얀색과 빨간색의 화환";
				case 1880:
					return "빨간색 화환";
				case 1881:
					return "빨간색과 녹색의 화환";
				case 1882:
					return "녹색 화환";
				case 1883:
					return "녹색과 하얀색의 화환";
				case 1884:
					return "다채색 전구";
				case 1885:
					return "빨간 전구";
				case 1886:
					return "노란 전구";
				case 1887:
					return "녹색 전구";
				case 1888:
					return "빨간색과 녹색의 전구";
				case 1889:
					return "노란색과 녹색의 전구";
				case 1890:
					return "빨간색과 노란색의 전구";
				case 1891:
					return "하얀색 전구";
				case 1892:
					return "하얀색과 빨간색의 전구";
				case 1893:
					return "하얀색과 노란색의 전구";
				case 1894:
					return "하얀색과 녹색의 전구";
				case 1895:
					return "다채색 조명";
				case 1896:
					return "빨간색 조명";
				case 1897:
					return "녹색 조명";
				case 1898:
					return "파란색 조명";
				case 1899:
					return "노란색 조명";
				case 1900:
					return "빨간색과 노란색 조명";
				case 1901:
					return "빨간색과 녹색 조명";
				case 1902:
					return "노란색과 녹색 조명";
				case 1903:
					return "파란색과 녹색 조명";
				case 1904:
					return "빨간색과 파란색 조명";
				case 1905:
					return "파란색과 노란색 조명";
				case 1906:
					return "커다란 나비리본";
				case 1907:
					return "순록의 뿔";
				case 1908:
					return "호랑가시나무 장식";
				case 1909:
					return "사탕 지팡이 검";
				case 1910:
					return "엘프의 융해기";
				case 1911:
					return "크리스마스 푸딩";
				case 1912:
					return "에그노그";
				case 1913:
					return "별 아니스";
				case 1914:
					return "순록의 종";
				case 1915:
					return "사탕 지팡이 갈고리";
				case 1916:
					return "크리스마스 갈고리";
				case 1917:
					return "사탕 지팡이 곡괭이";
				case 1918:
					return "과일케이크 차크람";
				case 1919:
					return "설탕 쿠키";
				case 1920:
					return "생강빵 쿠키";
				case 1921:
					return "벙어리 장갑";
				case 1922:
					return "석탄";
				case 1923:
					return "연장통";
				case 1924:
					return "소나무 문";
				case 1925:
					return "소나무 의자";
				case 1926:
					return "소나무 탁자";
				case 1927:
					return "개 호루라기";
				case 1928:
					return "크리스마스 트리 검";
				case 1929:
					return "체인건";
				case 1930:
					return "칼날솔잎";
				case 1931:
					return "눈보라 지팡이";
				case 1932:
					return "산타클라우스 모자";
				case 1933:
					return "산타클라우스 셔츠";
				case 1934:
					return "산타클라우스 힐";
				case 1935:
					return "파카 후드";
				case 1936:
					return "파카 코트";
				case 1937:
					return "파카 바지";
				case 1938:
					return "눈 모자";
				case 1939:
					return "어글리 스웨터";
				case 1940:
					return "트리 가면";
				case 1941:
					return "트리 셔츠";
				case 1942:
					return "트리 트렁크";
				case 1943:
					return "요정 모자";
				case 1944:
					return "요정 셔츠";
				case 1945:
					return "요정 바지";
				case 1946:
					return "눈사람 대포";
				case 1947:
					return "북극의 창";
				case 1948:
					return "크리스마스 트리 벽지";
				case 1949:
					return "장식 벽지";
				case 1950:
					return "사탕 지팡이 벽지";
				case 1951:
					return "축제의 벽지";
				case 1952:
					return "별모양 벽지";
				case 1953:
					return "물결무늬 벽지";
				case 1954:
					return "눈송이 벽지";
				case 1955:
					return "크램퍼스 뿔 벽지";
				case 1956:
					return "파랑초록 벽지";
				case 1957:
					return "그린치 손가락 벽지";
				case 1958:
					return "장난꾸러기 선물상자";
				case 1959:
					return "아기 그린치의 장난기 가득한 호루라기";
				case 1960:
					return "얼음 여왕 전리품";
				case 1961:
					return "산타-NK1 전리품";
				case 1962:
					return "에버스크림 전리품";
				case 1963:
					return "음악 상자 (Pumpkin Moon)";
				case 1964:
					return "음악 상자 (Alt Underground)";
				case 1965:
					return "음악 상자 (Frost Moon)";
				case 1966:
					return "갈색 페인트";
				case 1967:
					return "그림자 페인트";
				case 1968:
					return "반전 페인트";
				case 1969:
					return "팀 염료";
				case 1970:
					return "아메디스트 스파크 블럭";
				case 1971:
					return "토파즈 스파크 블럭";
				case 1972:
					return "사파이어 스파크 블럭";
				case 1973:
					return "에메랄드 스파크 블럭";
				case 1974:
					return "루비 스파크 블럭";
				case 1975:
					return "다이아몬드 스파크 블럭";
				case 1976:
					return "호박 스파크 블럭";
				case 1977:
					return "생명의 머리 염색약";
				case 1978:
					return "마나의 머리 염색약";
				case 1979:
					return "깊이의 머리 염색약";
				case 1980:
					return "돈의 머리 염색약";
				case 1981:
					return "시간의 머리 염색약";
				case 1982:
					return "팀의 머리 염색약";
				case 1983:
					return "지형의 머리 염색약";
				case 1984:
					return "파티의 머리 염색약";
				case 1985:
					return "무지개 머리 염색약";
				case 1986:
					return "속도의 머리 염색약";
				case 1987:
					return "천사 링";
				case 1988:
					return "페즈 모자";
				case 1989:
					return "여자마네킹";
				case 1990:
					return "머리 염색 제거제";
				case 1991:
					return "잠자리채";
				case 1992:
					return "반딧불이";
				case 1993:
					return "병 속에 반딧불이";
				case 1994:
					return "제왕나비";
				case 1995:
					return "자주황제나비";
				case 1996:
					return "큰멋쟁이나비";
				case 1997:
					return "율리시스 나비";
				case 1998:
					return "유황 나비";
				case 1999:
					return "나무 요정 나비";
				case 2000:
					return "제브라호랑나비";
				#endregion
				#region 2001 ~ 2500
				case 2001:
					return "줄리아 나비";
				case 2002:
					return "지렁이";
				case 2003:
					return "쥐";
				case 2004:
					return "개똥벌레";
				case 2005:
					return "병 속에 개똥벌레";
				case 2006:
					return "달팽이";
				case 2007:
					return "야광 달팽이";
				case 2008:
					return "고급 회색 벽지";
				case 2009:
					return "빙원 벽지";
				case 2010:
					return "음악 벽지";
				case 2011:
					return "자주색 비 벽지";
				case 2012:
					return "무지개 벽지";
				case 2013:
					return "반짝이는 돌 벽지";
				case 2014:
					return "별빛 하늘 벽지";
				case 2015:
					return "새";
				case 2016:
					return "큰어치";
				case 2017:
					return "홍관조";
				case 2018:
					return "다람쥐";
				case 2019:
					return "토끼";
				case 2020:
					return "선인장 책장";
				case 2021:
					return "흑단나무 책장";
				case 2022:
					return "살덩이 책장";
				case 2023:
					return "꿀 책장";
				case 2024:
					return "스팀펑크 책장";
				case 2025:
					return "유리 책장";
				case 2026:
					return "마호가니 책장";
				case 2027:
					return "진주나무 책장";
				case 2028:
					return "으스스한 책장";
				case 2029:
					return "하늘의 책장";
				case 2030:
					return "리자드 책장";
				case 2031:
					return "한기의 책장";
				case 2032:
					return "선인장 랜턴";
				case 2033:
					return "흑단나무 랜턴";
				case 2034:
					return "살덩이 랜턴";
				case 2035:
					return "꿀 랜턴";
				case 2036:
					return "스팀펑크 랜턴";
				case 2037:
					return "유리 랜턴";
				case 2038:
					return "마호가니 랜턴";
				case 2039:
					return "진주나무 랜턴";
				case 2040:
					return "한기의 랜턴";
				case 2041:
					return "리자드 랜턴";
				case 2042:
					return "하늘의 랜턴";
				case 2043:
					return "으스스한 랜턴";
				case 2044:
					return "한기의 문";
				case 2045:
					return "선인장 양초";
				case 2046:
					return "흑단나무 양초";
				case 2047:
					return "살덩이 양초";
				case 2048:
					return "유리 양초";
				case 2049:
					return "한기의 양초";
				case 2050:
					return "마호가니 양초";
				case 2051:
					return "진주나무 양초";
				case 2052:
					return "리자드 양초";
				case 2053:
					return "하늘의 양초";
				case 2054:
					return "호박 양초";
				case 2055:
					return "선인장 샹들리에";
				case 2056:
					return "흑단나무 샹들리에";
				case 2057:
					return "살덩이 샹들리에";
				case 2058:
					return "꿀 샹들리에";
				case 2059:
					return "한기의 샹들리에";
				case 2060:
					return "마호가니 샹들리에";
				case 2061:
					return "진주나무 샹들리에";
				case 2062:
					return "리자드 샹들리에";
				case 2063:
					return "하늘의 샹들리에";
				case 2064:
					return "으스스한 샹들리에";
				case 2065:
					return "유리 샹들리에";
				case 2066:
					return "선인장 침대";
				case 2067:
					return "살덩이 침대";
				case 2068:
					return "한기의 침대";
				case 2069:
					return "리자드 침대";
				case 2070:
					return "하늘의 침대";
				case 2071:
					return "으스스한 침대";
				case 2072:
					return "선인장 욕조";
				case 2073:
					return "흑단나무 욕조";
				case 2074:
					return "살덩이 욕조";
				case 2075:
					return "유리 욕조";
				case 2076:
					return "한기의 욕조";
				case 2077:
					return "마호가니 욕조";
				case 2078:
					return "진주나무 욕조";
				case 2079:
					return "리자드 욕조";
				case 2080:
					return "하늘의 욕조";
				case 2081:
					return "으스스한 욕조";
				case 2082:
					return "선인장 램프";
				case 2083:
					return "흑단나무 램프";
				case 2084:
					return "살덩이 램프";
				case 2085:
					return "유리 램프";
				case 2086:
					return "한기의 램프";
				case 2087:
					return "마호가니 램프";
				case 2088:
					return "진주나무 램프";
				case 2089:
					return "리자드 램프";
				case 2090:
					return "하늘의 램프";
				case 2091:
					return "으스스한 램프";
				case 2092:
					return "선인장 촛대";
				case 2093:
					return "흑단나무 촛대";
				case 2094:
					return "살덩이 촛대";
				case 2095:
					return "꿀 촛대";
				case 2096:
					return "스팀펑크 촛대";
				case 2097:
					return "유리 촛대";
				case 2098:
					return "마호가니 촛대";
				case 2099:
					return "진주나무 촛대";
				case 2100:
					return "한기의 촛대";
				case 2101:
					return "리자드 촛대";
				case 2102:
					return "하늘의 촛대";
				case 2103:
					return "으스스한 촛대";
				case 2104:
					return "크툴후의 뇌 가면";
				case 2105:
					return "육체의 벽 가면";
				case 2106:
					return "쌍둥이 가면";
				case 2107:
					return "스켈레톤 프라임 가면";
				case 2108:
					return "여왕벌 가면";
				case 2109:
					return "플렌테라 가면";
				case 2110:
					return "골렘 가면";
				case 2111:
					return "세계를 먹는 자 가면";
				case 2112:
					return "크툴후의 눈 가면";
				case 2113:
					return "파괴자 가면";
				case 2114:
					return "대장장이 선반";
				case 2115:
					return "무기 선반";
				case 2116:
					return "투구 선반";
				case 2117:
					return "창 선반";
				case 2118:
					return "검 선반";
				case 2119:
					return "돌 석판";
				case 2120:
					return "사암 석판";
				case 2121:
					return "개구리";
				case 2122:
					return "청둥 오리";
				case 2123:
					return "오리";
				case 2124:
					return "꿀 욕조";
				case 2125:
					return "스팀펑크 욕조";
				case 2126:
					return "생나무 욕조";
				case 2127:
					return "귀신들린 나무 욕조";
				case 2128:
					return "뼈 욕조";
				case 2129:
					return "꿀 램프";
				case 2130:
					return "스팀펑크 램프";
				case 2131:
					return "생나무 램프";
				case 2132:
					return "귀신들린 목재 램프";
				case 2133:
					return "황금 램프";
				case 2134:
					return "뼈 램프";
				case 2135:
					return "생나무 책장";
				case 2136:
					return "귀신들린 나무 책장";
				case 2137:
					return "황금 책장";
				case 2138:
					return "뼈 책장";
				case 2139:
					return "생나무 침대";
				case 2140:
					return "뼈 침대";
				case 2141:
					return "생나무 샹들리에";
				case 2142:
					return "귀신들린 목재 샹들리에";
				case 2143:
					return "황금 샹들리에";
				case 2144:
					return "뼈 샹들리에";
				case 2145:
					return "생나무 랜턴";
				case 2146:
					return "귀신들린 목재 랜턴";
				case 2147:
					return "황금 랜턴";
				case 2148:
					return "뼈 랜턴";
				case 2149:
					return "생나무 촛대";
				case 2150:
					return "귀신들린 목재 촛대";
				case 2151:
					return "황금 촛대";
				case 2152:
					return "뼈 촛대";
				case 2153:
					return "생나무 양초";
				case 2154:
					return "귀신들린 목재 양초";
				case 2155:
					return "황금 양초";
				case 2156:
					return "검은 전갈";
				case 2157:
					return "전갈";
				case 2158:
					return "방울방울 벽지";
				case 2159:
					return "구리관 벽지";
				case 2160:
					return "새끼오리 벽지";
				case 2161:
					return "한기의 핵";
				case 2162:
					return "토끼 우리";
				case 2163:
					return "다람쥐 우리";
				case 2164:
					return "청둥 오리 우리";
				case 2165:
					return "오리 우리";
				case 2166:
					return "새장";
				case 2167:
					return "큰 어치 새장";
				case 2168:
					return "홍관조 새장";
				case 2169:
					return "폭포 벽면";
				case 2170:
					return "용암폭포 벽면";
				case 2171:
					return "진홍의 씨앗";
				case 2172:
					return "고중량 작업대";
				case 2173:
					return "구리 도금";
				case 2174:
					return "달팽이 우리";
				case 2175:
					return "야광 달팽이 우리";
				case 2176:
					return "쉬루마이트 채굴 발톱";
				case 2177:
					return "탄통";
				case 2178:
					return "제왕나비가 담긴 병";
				case 2179:
					return "자주황제나비가 담긴 병";
				case 2180:
					return "큰멋쟁이나비가 담긴 병";
				case 2181:
					return "율리시스 나비가 담긴 병";
				case 2182:
					return "유황 나비가 담긴 병";
				case 2183:
					return "나무 요정 나비가 담긴 병";
				case 2184:
					return "제브라호랑나비가 담긴 병";
				case 2185:
					return "줄리아 나비가 담긴 병";
				case 2186:
					return "전갈 우리";
				case 2187:
					return "검은 전갈 우리";
				case 2188:
					return "맹독 지팡이";
				case 2189:
					return "유령의 가면";
				case 2190:
					return "개구리 우리";
				case 2191:
					return "쥐 우리";
				case 2192:
					return "뼈 용접기";
				case 2193:
					return "살덩이 복제기";
				case 2194:
					return "유리 가마";
				case 2195:
					return "리자드 화로";
				case 2196:
					return "살아있는 물레";
				case 2197:
					return "하늘 방아";
				case 2198:
					return "제빙기";
				case 2199:
					return "딱정벌레 투구";
				case 2200:
					return "딱정벌레 비늘 갑옷";
				case 2201:
					return "딱정벌레 등딱지";
				case 2202:
					return "딱정벌레 각반";
				case 2203:
					return "스팀펑크 보일러";
				case 2204:
					return "꿀 분배기";
				case 2205:
					return "펭귄";
				case 2206:
					return "펭귄 우리";
				case 2207:
					return "지렁이 우리";
				case 2208:
					return "테라리움";
				case 2209:
					return "최고급 마나 물약";
				case 2210:
					return "흑단나무 울타리";
				case 2211:
					return "마호가니 울타리";
				case 2212:
					return "진주나무 울타리";
				case 2213:
					return "귀신들린 목재 울타리";
				case 2214:
					return "자동 벽돌 배치 장치";
				case 2215:
					return "확장 손잡이";
				case 2216:
					return "페인트 분무기";
				case 2217:
					return "휴대용 시멘트 혼합기";
				case 2218:
					return "딱정벌레 껍질";
				case 2219:
					return "천상의 자석";
				case 2220:
					return "천상의 휘장";
				case 2221:
					return "천상의 수갑";
				case 2222:
					return "행상인의 모자";
				case 2223:
					return "파동의 활";
				case 2224:
					return "커다란 왕조 시대의 랜턴";
				case 2225:
					return "왕조 시대의 램프";
				case 2226:
					return "왕조 시대의 랜턴";
				case 2227:
					return "커다란 왕조 시대의 양초";
				case 2228:
					return "왕조 시대의 의자";
				case 2229:
					return "왕조 시대의 작업대";
				case 2230:
					return "왕조 시대의 상자";
				case 2231:
					return "왕조 시대의 침대";
				case 2232:
					return "왕조 시대의 욕조";
				case 2233:
					return "왕조 시대의 책장";
				case 2234:
					return "왕조 시대의 컵";
				case 2235:
					return "왕조 시대의 활";
				case 2236:
					return "왕조 시대의 양초";
				case 2237:
					return "왕조 시대의 시계";
				case 2238:
					return "황금 시계";
				case 2239:
					return "유리 시계";
				case 2240:
					return "꿀 시계";
				case 2241:
					return "스팀펑크 시계";
				case 2242:
					return "고급 접시";
				case 2243:
					return "유리 접시";
				case 2244:
					return "와인잔";
				case 2245:
					return "생나무 피아노";
				case 2246:
					return "살덩이 피아노";
				case 2247:
					return "한기의 피아노";
				case 2248:
					return "한기의 탁자";
				case 2249:
					return "꿀 상자";
				case 2250:
					return "스팀펑크 상자";
				case 2251:
					return "꿀 작업대";
				case 2252:
					return "한기의 작업대";
				case 2253:
					return "스팀펑크 작업대";
				case 2254:
					return "유리 피아노";
				case 2255:
					return "꿀 피아노";
				case 2256:
					return "스팀펑크 피아노";
				case 2257:
					return "꿀 컵";
				case 2258:
					return "성배";
				case 2259:
					return "왕조 시대의 탁자";
				case 2260:
					return "왕조 시대의 나무";
				case 2261:
					return "붉은 왕조 시대의 지붕 널";
				case 2262:
					return "푸른 왕조 시대의 지붕 널";
				case 2263:
					return "하얀 왕조 시대의 벽면";
				case 2264:
					return "푸른 왕조 시대의 벽면";
				case 2265:
					return "왕조 시대의 문";
				case 2266:
					return "사케";
				case 2267:
					return "팟타이";
				case 2268:
					return "쌀국수";
				case 2269:
					return "리볼버";
				case 2270:
					return "게틀리게이터";
				case 2271:
					return "비전 룬 벽면";
				case 2272:
					return "물총";
				case 2273:
					return "카타나";
				case 2274:
					return "엄청나게 밝은 횃불";
				case 2275:
					return "마법 모자";
				case 2276:
					return "다이아몬드 반지";
				case 2277:
					return "도복";
				case 2278:
					return "기모노";
				case 2279:
					return "집시 로브";
				case 2280:
					return "딱정벌레 날개";
				case 2281:
					return "호랑이 가죽";
				case 2282:
					return "표범 가죽";
				case 2283:
					return "얼룩말 가죽";
				case 2284:
					return "진홍의 망토";
				case 2285:
					return "신비한 망토";
				case 2286:
					return "붉은 망토";
				case 2287:
					return "겨울 망토";
				case 2288:
					return "한기의 의자";
				case 2289:
					return "나무 낚싯대";
				case 2290:
					return "농어";
				case 2291:
					return "강철 낚싯대";
				case 2292:
					return "섬유 유리 낚싯대";
				case 2293:
					return "영혼을 낚는 자";
				case 2294:
					return "황금 낚싯대";
				case 2295:
					return "기계공의 낚싯대";
				case 2296:
					return "사냥감의 낚싯대";
				case 2297:
					return "송어";
				case 2298:
					return "연어";
				case 2299:
					return "대서양 대구";
				case 2300:
					return "참다랑어";
				case 2301:
					return "붉돔";
				case 2302:
					return "네온테트라";
				case 2303:
					return "판피류 동굴어";
				case 2304:
					return "자리돔";
				case 2305:
					return "진홍의 타이거피쉬";
				case 2306:
					return "한기의 황어";
				case 2307:
					return "공주물고기";
				case 2308:
					return "황금 잉어";
				case 2309:
					return "거울 물고기";
				case 2310:
					return "프리즈마이트";
				case 2311:
					return "꽃동멸";
				case 2312:
					return "화염지느러미 잉어";
				case 2313:
					return "쌍 대구";
				case 2314:
					return "꿀지느러미";
				case 2315:
					return "흑요물고기";
				case 2316:
					return "새우";
				case 2317:
					return "혼돈의 물고기";
				case 2318:
					return "흑단잉어";
				case 2319:
					return "헤모피라냐";
				case 2320:
					return "우럭";
				case 2321:
					return "악취어";
				case 2322:
					return "채광의 물약";
				case 2323:
					return "생명 습득의 물약";
				case 2324:
					return "평온함의 물약";
				case 2325:
					return "건축가의 물약";
				case 2326:
					return "거인의 물약";
				case 2327:
					return "물갈퀴의 물약";
				case 2328:
					return "소환술의 물약";
				case 2329:
					return "위협 감지의 물약";
				case 2330:
					return "보라색 곤봉물고기";
				case 2331:
					return "흑요석 황새치";
				case 2332:
					return "황새치";
				case 2333:
					return "철제 울타리";
				case 2334:
					return "나무 상자";
				case 2335:
					return "철 상자";
				case 2336:
					return "황금 상자";
				case 2337:
					return "오래된 신발";
				case 2338:
					return "해초";
				case 2339:
					return "주석 깡통";
				case 2340:
					return "광산수레 선로";
				case 2341:
					return "약탈자 상어";
				case 2342:
					return "톱상어";
				case 2343:
					return "광산수레";
				case 2344:
					return "탄약 회수의 물약";
				case 2345:
					return "체력 증진의 물약";
				case 2346:
					return "인내의 물약";
				case 2347:
					return "격노의 물약";
				case 2348:
					return "지옥불의 물약";
				case 2349:
					return "분노의 물약";
				case 2350:
					return "회귀의 물약";
				case 2351:
					return "순간이동의 물약";
				case 2352:
					return "사랑의 물약";
				case 2353:
					return "악취의 물약";
				case 2354:
					return "낚시의 물약";
				case 2355:
					return "수중 탐지의 물약";
				case 2356:
					return "상자의 물약";
				case 2357:
					return "한기의 가시꽃 씨앗";
				case 2358:
					return "한기의 가시꽃";
				case 2359:
					return "온기의 물약";
				case 2360:
					return "물고기 갈고리";
				case 2361:
					return "꿀벌 헤드기어";
				case 2362:
					return "꿀벌 흉갑";
				case 2363:
					return "꿀벌 각반";
				case 2364:
					return "말벌 지팡이";
				case 2365:
					return "임프 지팡이";
				case 2366:
					return "여왕 거미 지팡이";
				case 2367:
					return "낚시꾼 모자";
				case 2368:
					return "낚시꾼 조끼";
				case 2369:
					return "낚시꾼 바지";
				case 2370:
					return "거미 가면";
				case 2371:
					return "거미 흉갑";
				case 2372:
					return "거미 각반";
				case 2373:
					return "고성능 낚시줄";
				case 2374:
					return "낚시꾼 귀걸이";
				case 2375:
					return "낚시도구 상자";
				case 2376:
					return "파란색 던전 피아노";
				case 2377:
					return "녹색 던전 피아노";
				case 2378:
					return "분홍색 던전 피아노";
				case 2379:
					return "황금 피아노";
				case 2380:
					return "흑요석 피아노";
				case 2381:
					return "뼈 피아노";
				case 2382:
					return "선인장 피아노";
				case 2383:
					return "으스스한 피아노";
				case 2384:
					return "하늘의 피아노";
				case 2385:
					return "리자드 피아노";
				case 2386:
					return "파란색 던전 옷장";
				case 2387:
					return "녹색 던전 옷장";
				case 2388:
					return "분홍색 던전 옷장";
				case 2389:
					return "황금 옷장";
				case 2390:
					return "흑요석 옷장";
				case 2391:
					return "뼈 옷장";
				case 2392:
					return "선인장 옷장";
				case 2393:
					return "으스스한 옷장";
				case 2394:
					return "하늘의 옷장";
				case 2395:
					return "꿀 옷장";
				case 2396:
					return "리자드 옷장";
				case 2397:
					return "소파";
				case 2398:
					return "흑단나무 소파";
				case 2399:
					return "마호가니 소파";
				case 2400:
					return "진주나무 소파";
				case 2401:
					return "귀신들린 나무 소파";
				case 2402:
					return "파란색 던전 소파";
				case 2403:
					return "녹색 던전 소파";
				case 2404:
					return "분홍색 던전 소파";
				case 2405:
					return "황금 소파";
				case 2406:
					return "흑요석 소파";
				case 2407:
					return "뼈 소파";
				case 2408:
					return "선인장 소파";
				case 2409:
					return "으스스한 소파";
				case 2410:
					return "하늘의 소파";
				case 2411:
					return "꿀 소파";
				case 2412:
					return "스팀펑크 소파";
				case 2413:
					return "버섯 소파";
				case 2414:
					return "유리 소파";
				case 2415:
					return "호박 소파";
				case 2416:
					return "리자드 소파";
				case 2417:
					return "조개 머리핀";
				case 2418:
					return "인어 장식품";
				case 2419:
					return "인어 꼬리";
				case 2420:
					return "산들바람 물고기";
				case 2421:
					return "살덩이포획꾼";
				case 2422:
					return "초고열선 낚싯대";
				case 2423:
					return "개구리 뒷다리";
				case 2424:
					return "닻";
				case 2425:
					return "요리한 물고기";
				case 2426:
					return "요리한 새우";
				case 2427:
					return "사시미";
				case 2428:
					return "솜털 당근";
				case 2429:
					return "비늘 송로버섯";
				case 2430:
					return "끈적끈적한 안장";
				case 2431:
					return "꿀벌의 밀랍";
				case 2432:
					return "구리 도금 벽면";
				case 2433:
					return "돌 석판 벽면";
				case 2434:
					return "돛";
				case 2435:
					return "산호석 블럭";
				case 2436:
					return "파란 해라피";
				case 2437:
					return "초록 해파리";
				case 2438:
					return "분홍 해파리";
				case 2439:
					return "파란 해파리가 담긴 항아리";
				case 2440:
					return "초록 해파리가 담긴 항아리";
				case 2441:
					return "분홍 해파리가 담긴 항아리";
				case 2442:
					return "구명대";
				case 2443:
					return "조타륜";
				case 2444:
					return "나침표";
				case 2445:
					return "벽에 붙이는 닻";
				case 2446:
					return "금붕어 전리품";
				case 2447:
					return "토끼물고기 전리품";
				case 2448:
					return "황새치 전리품";
				case 2449:
					return "상어이빨 전리품";
				case 2450:
					return "박쥐물고기";
				case 2451:
					return "꿀벌 참다랑어";
				case 2452:
					return "고양이물고기";
				case 2453:
					return "구름물고기";
				case 2454:
					return "저주받은물고기";
				case 2455:
					return "흙물고기";
				case 2456:
					return "다이너마이트 물고기";
				case 2457:
					return "플랑크톤 포식자";
				case 2458:
					return "떨어진 별고기";
				case 2459:
					return "'크툴후의 물고기'";
				case 2460:
					return "피쇼트론";
				case 2461:
					return "하피물고기";
				case 2462:
					return "배고픈물고기";
				case 2463:
					return "이코르물고기";
				case 2464:
					return "보석물고기";
				case 2465:
					return "신기루 물고기";
				case 2466:
					return "돌연변이 플링스지느러미";
				case 2467:
					return "펭귄물고기";
				case 2468:
					return "픽시물고기";
				case 2469:
					return "거미물고기";
				case 2470:
					return "툰드라 송어";
				case 2471:
					return "유니콘 물고기";
				case 2472:
					return "가이드 부두 물고기";
				case 2473:
					return "와이번꼬리";
				case 2474:
					return "좀비 물고기";
				case 2475:
					return "광대버섯지느러미";
				case 2476:
					return "엔젤피쉬";
				case 2477:
					return "피투성이의 작은부레관해파리";
				case 2478:
					return "뼈물고기";
				case 2479:
					return "토끼물고기";
				case 2480:
					return "캡틴 참치수염";
				case 2481:
					return "흰 동가리";
				case 2482:
					return "악마의 지옥물고기";
				case 2483:
					return "파충류같은 기형 물고기";
				case 2484:
					return "피시론";
				case 2485:
					return "감염된 갈치";
				case 2486:
					return "진흙물고기";
				case 2487:
					return "슬라임물고기";
				case 2488:
					return "열대의 바라쿠다";
				case 2489:
					return "왕 슬라임 전리품";
				case 2490:
					return "병 속의 배";
				case 2491:
					return "튼튼한 안장";
				case 2492:
					return "압력판 선로";
				case 2493:
					return "왕 슬라임 가면";
				case 2494:
					return "지느러미 날개";
				case 2495:
					return "보물 지도";
				case 2496:
					return "해초 화분";
				case 2497:
					return "나를 털어줘요 Pixel 해적";
				case 2498:
					return "물고기 코스프레 가면";
				case 2499:
					return "물고기 코스프레 셔츠";
				case 2500:
					return "물고기 코스프레 지느러미스커트";
				#endregion
				#region 2501 ~ 2748
				case 2501:
					return "생강 수염";
				case 2502:
					return "달콤한 고글";
				case 2503:
					return "아한대 나무";
				case 2504:
					return "야자수";
				case 2505:
					return "아한대 나무 벽면";
				case 2506:
					return "야자수 벽면";
				case 2507:
					return "아한대 나무 울타리";
				case 2508:
					return "야자수 울타리";
				case 2509:
					return "아한대 나무 투구";
				case 2510:
					return "아한대 나무 흉갑";
				case 2511:
					return "아한대 나무 각반";
				case 2512:
					return "야자수 투구";
				case 2513:
					return "야자수 흉갑";
				case 2514:
					return "야자수 각반";
				case 2515:
					return "야자수 활";
				case 2516:
					return "야자수 망치";
				case 2517:
					return "야자수 검";
				case 2518:
					return "야자수 플랫폼";
				case 2519:
					return "야자수 욕조";
				case 2520:
					return "야자수 침대";
				case 2521:
					return "야자수 벤치";
				case 2522:
					return "야자수 촛대";
				case 2523:
					return "야자수 양초";
				case 2524:
					return "야자수 의자";
				case 2525:
					return "야자수 샹들리에";
				case 2526:
					return "야자수 상자";
				case 2527:
					return "야자수 소파";
				case 2528:
					return "야자수 문";
				case 2529:
					return "야자수 옷장";
				case 2530:
					return "야자수 랜턴";
				case 2531:
					return "야자수 피아노";
				case 2532:
					return "야자수 탁자";
				case 2533:
					return "야자수 램프";
				case 2534:
					return "야자수 작업대";
				case 2535:
					return "광학 지팡이";
				case 2536:
					return "야자수 책장";
				case 2537:
					return "버섯 욕조";
				case 2538:
					return "버섯 침대";
				case 2539:
					return "버섯 벤치";
				case 2540:
					return "버섯 책장";
				case 2541:
					return "버섯 촛대";
				case 2542:
					return "버섯 양초";
				case 2543:
					return "버섯 샹들리에";
				case 2544:
					return "버섯 상자";
				case 2545:
					return "버섯 옷장";
				case 2546:
					return "버섯 랜턴";
				case 2547:
					return "버섯 램프";
				case 2548:
					return "버섯 피아노";
				case 2549:
					return "버섯 플랫폼";
				case 2550:
					return "버섯 탁자";
				case 2551:
					return "거미 지팡이";
				case 2552:
					return "아한대 나무 욕조";
				case 2553:
					return "아한대 나무 침대";
				case 2554:
					return "아한대 나무 책장";
				case 2555:
					return "아한대 나무 촛대";
				case 2556:
					return "아한대 나무 양초";
				case 2557:
					return "아한대 나무 의자";
				case 2558:
					return "아한대 나무 샹들리에";
				case 2559:
					return "아한대 나무 상자";
				case 2560:
					return "아한대 나무 시계";
				case 2561:
					return "아한대 나무 문";
				case 2562:
					return "아한대 나무 옷장";
				case 2563:
					return "아한대 나무 램프";
				case 2564:
					return "아한대 나무 랜턴";
				case 2565:
					return "아한대 나무 피아노";
				case 2566:
					return "아한대 나무 플랫폼";
				case 2567:
					return "슬라임 욕조";
				case 2568:
					return "슬라임 침대";
				case 2569:
					return "슬라임 책장";
				case 2570:
					return "슬라임 촛대";
				case 2571:
					return "슬라임 양초";
				case 2572:
					return "슬라임 의자";
				case 2573:
					return "슬라임 샹들리에";
				case 2574:
					return "슬라임 상자";
				case 2575:
					return "슬라임 시계";
				case 2576:
					return "슬라임 문";
				case 2577:
					return "슬라임 옷장";
				case 2578:
					return "슬라임 램프";
				case 2579:
					return "슬라임 랜턴";
				case 2580:
					return "슬라임 피아노";
				case 2581:
					return "슬라임 플랫폼";
				case 2582:
					return "슬라임 소파";
				case 2583:
					return "슬라임 탁자";
				case 2584:
					return "해적 지팡이";
				case 2585:
					return "슬라임 갈고리";
				case 2586:
					return "끈적이는 수류탄";
				case 2587:
					return "타르타르 소스";
				case 2588:
					return "듀크 피시론 가면";
				case 2589:
					return "듀크 피시론 전리품";
				case 2590:
					return "화염병";
				case 2591:
					return "뼈 시계";
				case 2592:
					return "선인장 시계";
				case 2593:
					return "흑단나무 시계";
				case 2594:
					return "한기의 시계";
				case 2595:
					return "리자드 시계";
				case 2596:
					return "생나무 시계";
				case 2597:
					return "마호가니 시계";
				case 2598:
					return "살덩이 시계";
				case 2599:
					return "버섯 시계";
				case 2600:
					return "흑요석 시계";
				case 2601:
					return "야자수 시계";
				case 2602:
					return "진주나무 시계";
				case 2603:
					return "호박 시계";
				case 2604:
					return "귀신들린 나무 시계";
				case 2605:
					return "으스스한 시계";
				case 2606:
					return "태양판 시계";
				case 2607:
					return "거미 송곳니";
				case 2608:
					return "팔콘 블레이드";
				case 2609:
					return "피시론의 날개";
				case 2610:
					return "슬라임 총";
				case 2611:
					return "플레이론";
				case 2612:
					return "녹색 던전 상자";
				case 2613:
					return "분홍색 던전 상자";
				case 2614:
					return "파란색 던전 상자";
				case 2615:
					return "뼈 상자";
				case 2616:
					return "선인장 상자";
				case 2617:
					return "살덩이 상자";
				case 2618:
					return "흑요석 상자";
				case 2619:
					return "호박 상자";
				case 2620:
					return "으스스한 상자";
				case 2621:
					return "거센 폭풍의 지팡이";
				case 2622:
					return "칼날의 태풍";
				case 2623:
					return "비눗방울 총";
				case 2624:
					return "쓰나미";
				case 2625:
					return "조개";
				case 2626:
					return "불가사리";
				case 2627:
					return "스팀펑크 플랫폼";
				case 2628:
					return "하늘의 플랫폼";
				case 2629:
					return "생나무 플랫폼";
				case 2630:
					return "꿀 플랫폼";
				case 2631:
					return "하늘의 작업대";
				case 2632:
					return "유리 작업대";
				case 2633:
					return "생나무 작업대";
				case 2634:
					return "살덩이 소파";
				case 2635:
					return "한기의 소파";
				case 2636:
					return "생나무 소파";
				case 2637:
					return "호박 옷장";
				case 2638:
					return "스팀펑크 옷장";
				case 2639:
					return "유리 옷장";
				case 2640:
					return "살덩이 옷장";
				case 2641:
					return "호박 랜턴";
				case 2642:
					return "흑요석 랜턴";
				case 2643:
					return "호박 램프";
				case 2644:
					return "흑요석 램프";
				case 2645:
					return "파란색 던전 램프";
				case 2646:
					return "녹색 던전 램프";
				case 2647:
					return "분홍색 던전 램프";
				case 2648:
					return "꿀 양초";
				case 2649:
					return "스팀펑크 양초";
				case 2650:
					return "으스스한 양초";
				case 2651:
					return "흑요석 양초";
				case 2652:
					return "파란색 던전 샹들리에";
				case 2653:
					return "녹색 던전 샹들리에";
				case 2654:
					return "분홍색 던전 샹들리에";
				case 2655:
					return "스팀펑크 샹들리에";
				case 2656:
					return "호박 샹들리에";
				case 2657:
					return "흑요석 샹들리에";
				case 2658:
					return "파란색 던전 욕조";
				case 2659:
					return "녹색 던전 욕조";
				case 2660:
					return "분홍색 던전 욕조";
				case 2661:
					return "호박 욕조";
				case 2662:
					return "흑요석 욕조";
				case 2663:
					return "황금 욕조";
				case 2664:
					return "파란색 던전 촛대";
				case 2665:
					return "녹색 던전 촛대";
				case 2666:
					return "분홍색 던전 촛대";
				case 2667:
					return "흑요석 촛대";
				case 2668:
					return "호박 촛대";
				case 2669:
					return "호박 침대";
				case 2670:
					return "호박 책장";
				case 2671:
					return "호박 피아노";
				case 2672:
					return "상어 동상";
				case 2673:
					return "송로버섯 지렁이";
				case 2674:
					return "견습생 미끼";
				case 2675:
					return "숙련자 미끼";
				case 2676:
					return "마스터 미끼";
				case 2677:
					return "호박 스파크 벽면";
				case 2678:
					return "전원 끊긴 호박 스파크 벽면";
				case 2679:
					return "아메디스트 스파크 벽면";
				case 2680:
					return "전원 끊긴 아메디스트 스파크 벽면";
				case 2681:
					return "다이아몬드 스파크 벽면";
				case 2682:
					return "전원 끊긴 다이아몬드 스파크 벽면";
				case 2683:
					return "에메랄드 스파크 벽면";
				case 2684:
					return "전원 끊긴 에메랄드 스파크 벽면";
				case 2685:
					return "루비 스파크 벽면";
				case 2686:
					return "전원 끊긴 루비 스파크 벽면";
				case 2687:
					return "사파이어 스파크 벽면";
				case 2688:
					return "전원 끊긴 사파이어 스파크 벽면";
				case 2689:
					return "토파즈 스파크 벽면";
				case 2690:
					return "전원 끊긴 토파즈 스파크 벽면";
				case 2691:
					return "주석 도금 벽면";
				case 2692:
					return "주석 도금";
				case 2693:
					return "폭포 블럭";
				case 2694:
					return "용암폭포 블럭";
				case 2695:
					return "색종이 블럭";
				case 2696:
					return "색종이 벽면";
				case 2697:
					return "한밤중의 색종이 블럭";
				case 2698:
					return "한밤중의 색종이 벽면";
				case 2699:
					return "무기 선반";
				case 2700:
					return "불꽃놀이 상자";
				case 2701:
					return "살아있는 불 블럭";
				case 2702:
					return "'0' 동상";
				case 2703:
					return "'1' 동상";
				case 2704:
					return "'2' 동상";
				case 2705:
					return "'3' 동상";
				case 2706:
					return "'4' 동상";
				case 2707:
					return "'5' 동상";
				case 2708:
					return "'6' 동상";
				case 2709:
					return "'7' 동상";
				case 2710:
					return "'8' 동상";
				case 2711:
					return "'9' 동상";
				case 2712:
					return "'A' 동상";
				case 2713:
					return "'B' 동상";
				case 2714:
					return "'C' 동상";
				case 2715:
					return "'D' 동상";
				case 2716:
					return "'E' 동상";
				case 2717:
					return "'F' 동상";
				case 2718:
					return "'G' 동상";
				case 2719:
					return "'H' 동상";
				case 2720:
					return "'I' 동상";
				case 2721:
					return "'J' 동상";
				case 2722:
					return "'K' 동상";
				case 2723:
					return "'L' 동상";
				case 2724:
					return "'M' 동상";
				case 2725:
					return "'N' 동상";
				case 2726:
					return "'O' 동상";
				case 2727:
					return "'P' 동상";
				case 2728:
					return "'Q' 동상";
				case 2729:
					return "'R' 동상";
				case 2730:
					return "'S' 동상";
				case 2731:
					return "'T' 동상";
				case 2732:
					return "'U' 동상";
				case 2733:
					return "'V' 동상";
				case 2734:
					return "'W' 동상";
				case 2735:
					return "'X' 동상";
				case 2736:
					return "'Y' 동상";
				case 2737:
					return "'Z' 동상";
				case 2738:
					return "불꽃놀이 분수";
				case 2739:
					return "부스터 선로";
				case 2740:
					return "메뚜기";
				case 2741:
					return "메뚜기 우리";
				case 2742:
					return "음악 상자 (Underground Crimson)";
				case 2743:
					return "선인장 탁자";
				case 2744:
					return "선인장 플랫폼";
				case 2745:
					return "아한대 나무 검";
				case 2746:
					return "아한대 나무 망치";
				case 2747:
					return "아한대 나무 활";
				case 2748:
					return "유리 상자";
				#endregion
				#region 2749 ~ 3000 (1.3~)
				case 2749:
					return "제노 스태프";
				case 2750:
					return "메테오 스태프";
				case 2751:
					return "타오르는 저주받은 불 블록";
				case 2752:
					return "타오르는 악마의 불 블록";
				case 2753:
					return "타오르는 냉기의 불 블록";
				case 2754:
					return "타오르는 이코르 불 블록";
				case 2755:
					return "타오르는 매우 밝은 불 블록";
				case 2756:
					return "성전환 물약";
				case 2757:
					return "소용돌이 투구";
				case 2758:
					return "소용돌이 흉갑";
				case 2759:
					return "소용돌이 각반";
				case 2760:
					return "성운 투구";
				case 2761:
					return "성운 흉갑";
				case 2762:
					return "성운 각반";
				case 2763:
					return "태양풍 헬멧";
				case 2764:
					return "태양풍 흉갑";
				case 2765:
					return "태양풍 각반";
				case 2766:
					return "Solar Tablet Fragment";
				case 2767:
					return "Solar Tablet";
				case 2768:
					return "Drill Containment Unit";
				case 2769:
					return "Cosmic Car Key";
				case 2770:
					return "Mothron Wings";
				case 2771:
					return "두뇌 분쇄기";
				case 2772:
					return "소용돌이 도끼";
				case 2773:
					return "소용돌이 전기톱";
				case 2774:
					return "소용돌이 드릴";
				case 2775:
					return "소용돌이 망치";
				case 2776:
					return "소용돌이 곡괭이";
				case 2777:
					return "성운 도끼";
				case 2778:
					return "성운 전기톱";
				case 2779:
					return "Nebula Drill";
				case 2780:
					return "Nebula Hammer";
				case 2781:
					return "Nebula Pickaxe";
				case 2782:
					return "Solar Flare Axe";
				case 2783:
					return "Solar Flare Chainsaw";
				case 2784:
					return "Solar Flare Drill";
				case 2785:
					return "Solar Flare Hammer";
				case 2786:
					return "Solar Flare Pickaxe";
				case 2787:
					return "Honeyfall Block";
				case 2788:
					return "Honeyfall Wall";
				case 2789:
					return "Chlorophyte Brick Wall";
				case 2790:
					return "Crimtane Brick Wall";
				case 2791:
					return "Shroomite Plating Wall";
				case 2792:
					return "녹조류 벽돌";
				case 2793:
					return "Crimtane Brick";
				case 2794:
					return "Shroomite Plating";
				case 2795:
					return "레이저 기관총";
				case 2796:
					return "Electrosphere Launcher";
				case 2797:
					return "제노포퍼";
				case 2798:
					return "레이저 드릴";
				case 2799:
					return "Mechanical Ruler";
				case 2800:
					return "반중력 갈고리";
				case 2801:
					return "달의 가면";
				case 2802:
					return "해의 가면";
				case 2803:
					return "Martian Costume Mask";
				case 2804:
					return "Martian Costume Shirt";
				case 2805:
					return "Martian Costume Pants";
				case 2806:
					return "Martian Uniform Helmet";
				case 2807:
					return "Martian Uniform Torso";
				case 2808:
					return "Martian Uniform Pants";
				case 2809:
					return "Martian Astro Clock";
				case 2810:
					return "Martian Bathtub";
				case 2811:
					return "Martian Bed";
				case 2812:
					return "Martian Hover Chair";
				case 2813:
					return "Martian Chandelier";
				case 2814:
					return "Martian Chest";
				case 2815:
					return "Martian Door";
				case 2816:
					return "Martian Dresser";
				case 2817:
					return "Martian Holobookcase";
				case 2818:
					return "Martian Hover Candle";
				case 2819:
					return "Martian Lamppost";
				case 2820:
					return "Martian Lantern";
				case 2821:
					return "Martian Piano";
				case 2822:
					return "Martian Platform";
				case 2823:
					return "Martian Sofa";
				case 2824:
					return "Martian Table";
				case 2825:
					return "Martian Table Lamp";
				case 2826:
					return "Martian Work Bench";
				case 2827:
					return "Wooden Sink";
				case 2828:
					return "Ebonwood Sink";
				case 2829:
					return "Rich Mahogany Sink";
				case 2830:
					return "Pearlwood Sink";
				case 2831:
					return "Bone Sink";
				case 2832:
					return "Flesh Sink";
				case 2833:
					return "Living Wood Sink";
				case 2834:
					return "Skyware Sink";
				case 2835:
					return "Shadewood Sink";
				case 2836:
					return "Lihzahrd Sink";
				case 2837:
					return "Blue Dungeon Sink";
				case 2838:
					return "Green Dungeon Sink";
				case 2839:
					return "Pink Dungeon Sink";
				case 2840:
					return "Obsidian Sink";
				case 2841:
					return "Metal Sink";
				case 2842:
					return "Glass Sink";
				case 2843:
					return "Golden Sink";
				case 2844:
					return "Honey Sink";
				case 2845:
					return "Steampunk Sink";
				case 2846:
					return "Pumpkin Sink";
				case 2847:
					return "Spooky Sink";
				case 2848:
					return "Frozen Sink";
				case 2849:
					return "Dynasty Sink";
				case 2850:
					return "Palm Wood Sink";
				case 2851:
					return "Mushroom Sink";
				case 2852:
					return "Boreal Wood Sink";
				case 2853:
					return "Slime Sink";
				case 2854:
					return "Cactus Sink";
				case 2855:
					return "Martian Sink";
				case 2856:
					return "Solar Cultist Hood";
				case 2857:
					return "Lunar Cultist Hood";
				case 2858:
					return "Solar Cultist Robe";
				case 2859:
					return "Lunar Cultist Robe";
				case 2860:
					return "Martian Conduit Plating";
				case 2861:
					return "Martian Conduit Wall";
				case 2862:
					return "HiTek Sunglasses";
				case 2863:
					return "Martian Hair Dye";
				case 2864:
					return "Martian Dye";
				case 2865:
					return "Castle Marsberg";
				case 2866:
					return "Martia Lisa";
				case 2867:
					return "The Truth Is Up There";
				case 2868:
					return "Smoke Block";
				case 2869:
					return "Living Flame Dye";
				case 2870:
					return "Living Rainbow Dye";
				case 2871:
					return "Shadow Dye";
				case 2872:
					return "Negative Dye";
				case 2873:
					return "Living Ocean Dye";
				case 2874:
					return "Brown Dye";
				case 2875:
					return "Brown and Black Dye";
				case 2876:
					return "Bright Brown Dye";
				case 2877:
					return "Brown and Silver Dye";
				case 2878:
					return "Wisp Dye";
				case 2879:
					return "Pixie Dye";
				case 2880:
					return "Influx Waver";
				case 2881:
					return "Phasic Warp Ejector";
				case 2882:
					return "Charged Blaster Cannon";
				case 2883:
					return "Chlorophyte Dye";
				case 2884:
					return "Unicorn Wisp Dye";
				case 2885:
					return "Infernal Wisp Dye";
				case 2886:
					return "Vicious Powder";
				case 2887:
					return "Vicious Mushroom";
				case 2888:
					return "The Bee's Knees";
				case 2889:
					return "황금 새";
				case 2890:
					return "황금 토끼";
				case 2891:
					return "황금 나비";
				case 2892:
					return "황금 개구리";
				case 2893:
					return "황금 메뚜기";
				case 2894:
					return "황금 쥐";
				case 2895:
					return "황금 벌레";
				case 2896:
					return "점착 다이너마이트";
				case 2897:
					return "Angry Trapper Banner";
				case 2898:
					return "Armored Viking Banner";
				case 2899:
					return "Black Slime Banner";
				case 2900:
					return "Blue Armored Bones Banner";
				case 2901:
					return "Blue Cultist Archer Banner";
				case 2902:
					return "Blue Cultist Caster Banner";
				case 2903:
					return "Blue Cultist Fighter Banner";
				case 2904:
					return "Bone Lee Banner";
				case 2905:
					return "Clinger Banner";
				case 2906:
					return "Cochineal Beetle Banner";
				case 2907:
					return "Corrupt Penguin Banner";
				case 2908:
					return "Corrupt Slime Banner";
				case 2909:
					return "Corruptor Banner";
				case 2910:
					return "Crimslime Banner";
				case 2911:
					return "Cursed Skull Banner";
				case 2912:
					return "Cyan Beetle Banner";
				case 2913:
					return "Devourer Banner";
				case 2914:
					return "Diabolist Banner";
				case 2915:
					return "Doctor Bones Banner";
				case 2916:
					return "Dungeon Slime Banner";
				case 2917:
					return "Dungeon Spirit Banner";
				case 2918:
					return "Elf Archer Banner";
				case 2919:
					return "Elf Copter Banner";
				case 2920:
					return "Eyezor Banner";
				case 2921:
					return "Flocko Banner";
				case 2922:
					return "Ghost Banner";
				case 2923:
					return "Giant Bat Banner";
				case 2924:
					return "Giant Cursed Skull Banner";
				case 2925:
					return "Giant Flying Fox Banner";
				case 2926:
					return "Gingerbread Man Banner";
				case 2927:
					return "Goblin Archer Banner";
				case 2928:
					return "Green Slime Banner";
				case 2929:
					return "Headless Horseman Banner";
				case 2930:
					return "Hell Armored Bones Banner";
				case 2931:
					return "Hellhound Banner";
				case 2932:
					return "Hoppin' Jack Banner";
				case 2933:
					return "Ice Bat Banner";
				case 2934:
					return "Ice Golem Banner";
				case 2935:
					return "Ice Slime Banner";
				case 2936:
					return "Ichor Sticker Banner";
				case 2937:
					return "Illuminant Bat Banner";
				case 2938:
					return "Illuminant Slime Banner";
				case 2939:
					return "Jungle Bat Banner";
				case 2940:
					return "Jungle Slime Banner";
				case 2941:
					return "Krampus Banner";
				case 2942:
					return "Lac Beetle Banner";
				case 2943:
					return "Lava Bat Banner";
				case 2944:
					return "Lava Slime Banner";
				case 2945:
					return "Martian Brainscrambler Banner";
				case 2946:
					return "Martian Drone Banner";
				case 2947:
					return "Martian Engineer Banner";
				case 2948:
					return "Martian Gigazapper Banner";
				case 2949:
					return "Martian Gray Grunt Banner";
				case 2950:
					return "Martian Officer Banner";
				case 2951:
					return "Martian Ray Gunner Banner";
				case 2952:
					return "Martian Scutlix Gunner Banner";
				case 2953:
					return "Martian Tesla Turret Banner";
				case 2954:
					return "Mister Stabby Banner";
				case 2955:
					return "Mother Slime Banner";
				case 2956:
					return "Necromancer Banner";
				case 2957:
					return "Nutcracker Banner";
				case 2958:
					return "Paladin Banner";
				case 2959:
					return "Penguin Banner";
				case 2960:
					return "Pinky Banner";
				case 2961:
					return "Poltergeist Banner";
				case 2962:
					return "Possessed Armor Banner";
				case 2963:
					return "Present Mimic Banner";
				case 2964:
					return "Purple Slime Banner";
				case 2965:
					return "Ragged Caster Banner";
				case 2966:
					return "Rainbow Slime Banner";
				case 2967:
					return "Raven Banner";
				case 2968:
					return "Red Slime Banner";
				case 2969:
					return "Rune Wizard Banner";
				case 2970:
					return "Rusty Armored Bones Banner";
				case 2971:
					return "Scarecrow Banner";
				case 2972:
					return "Scutlix Banner";
				case 2973:
					return "Skeleton Archer Banner";
				case 2974:
					return "Skeleton Commando Banner";
				case 2975:
					return "Skeleton Sniper Banner";
				case 2976:
					return "Slimer Banner";
				case 2977:
					return "Snatcher Banner";
				case 2978:
					return "Snow Balla Banner";
				case 2979:
					return "Snowman Gangsta Banner";
				case 2980:
					return "Spiked Ice Slime Banner";
				case 2981:
					return "Spiked Jungle Slime Banner";
				case 2982:
					return "Splinterling Banner";
				case 2983:
					return "Squid Banner";
				case 2984:
					return "Tactical Skeleton Banner";
				case 2985:
					return "The Groom Banner";
				case 2986:
					return "Tim Banner";
				case 2987:
					return "Undead Miner Banner";
				case 2988:
					return "Undead Viking Banner";
				case 2989:
					return "White Cultist Archer Banner";
				case 2990:
					return "White Cultist Caster Banner";
				case 2991:
					return "White Cultist Fighter Banner";
				case 2992:
					return "Yellow Slime Banner";
				case 2993:
					return "Yeti Banner";
				case 2994:
					return "Zombie Elf Banner";
				case 2995:
					return "Sparky";
				case 2996:
					return "Vine Rope";
				case 2997:
					return "Wormhole Potion";
				case 2998:
					return "Summoner Emblem";
				case 2999:
					return "Bewitching Table";
				case 3000:
					return "연금술 테이블";
				#endregion
				#region 3001 ~ xxxx (1.3~)
				case 3001:
					return "Strange Brew";
				case 3002:
					return "Spelunker Glowstick";
				case 3003:
					return "뼈 화살";
				case 3004:
					return "뼈 횃불";
				case 3005:
					return "Vine Rope Coil";
				case 3006:
					return "Life Drain";
				case 3007:
					return "Dart Pistol";
				case 3008:
					return "Dart Rifle";
				case 3009:
					return "Crystal Dart";
				case 3010:
					return "Cursed Dart";
				case 3011:
					return "Ichor Dart";
				case 3012:
					return "Chain Guillotines";
				case 3013:
					return "Fetid Baghnakhs";
				case 3014:
					return "Clinger Staff";
				case 3015:
					return "Putrid Scent";
				case 3016:
					return "Flesh Knuckles";
				case 3017:
					return "Flower Boots";
				case 3018:
					return "Seedler";
				case 3019:
					return "Hellwing Bow";
				case 3020:
					return "Tendon Hook";
				case 3021:
					return "Thorn Hook";
				case 3022:
					return "Illuminant Hook";
				case 3023:
					return "Worm Hook";
				case 3024:
					return "Skiphs's Blood";
				case 3025:
					return "Purple Ooze Dye";
				case 3026:
					return "Reflective Silver Dye";
				case 3027:
					return "Reflective Gold Dye";
				case 3028:
					return "Blue Acid Dye";
				case 3029:
					return "Daedalus Stormbow";
				case 3030:
					return "Flying Knife";
				case 3031:
					return "Bottomless Water Bucket";
				case 3032:
					return "Super Absorbant Sponge";
				case 3033:
					return "Gold Ring";
				case 3034:
					return "Coin Ring";
				case 3035:
					return "Greedy Ring";
				case 3036:
					return "Fish Finder";
				case 3037:
					return "Weather Radio";
				case 3038:
					return "Hades Dye";
				case 3039:
					return "Twilight Dye";
				case 3040:
					return "Acid Dye";
				case 3041:
					return "Glowing Mushroom Dye";
				case 3042:
					return "Phase Dye";
				case 3043:
					return "Magic Lantern";
				case 3044:
					return "Music Box (Lunar Boss)";
				case 3045:
					return "무지개 횃불";
				case 3046:
					return "Cursed Campfire";
				case 3047:
					return "Demon Campfire";
				case 3048:
					return "Frozen Campfire";
				case 3049:
					return "Ichor Campfire";
				case 3050:
					return "Rainbow Campfire";
				case 3051:
					return "Crystal Vile Shard";
				case 3052:
					return "Shadowflame Bow";
				case 3053:
					return "Shadowflame Hex Doll";
				case 3054:
					return "Shadowflame Knife";
				case 3055:
					return "Acorns";
				case 3056:
					return "Cold Snap";
				case 3057:
					return "Cursed Saint";
				case 3058:
					return "Snowfellas";
				case 3059:
					return "The Season";
				case 3060:
					return "Bone Rattle";
				case 3061:
					return "Architect Gizmo Pack";
				case 3062:
					return "핏빛 심장";
				case 3063:
					return "Meowmere";
				case 3064:
					return "Enchanted Sundial";
				case 3065:
					return "Star Wrath";
				case 3066:
					return "Smooth Marble Block";
				case 3067:
					return "Hellstone Brick Wall";
				case 3068:
					return "Guide to Plant Fiber Cordage";
				case 3069:
					return "Wand of Sparking";
				case 3070:
					return "Gold Bird Cage";
				case 3071:
					return "Gold Bunny Cage";
				case 3072:
					return "Gold Butterfly Jar";
				case 3073:
					return "Gold Frog Cage";
				case 3074:
					return "Gold Grasshopper Cage";
				case 3075:
					return "Gold Mouse Cage";
				case 3076:
					return "Gold Worm Cage";
				case 3077:
					return "실크 로프";
				case 3078:
					return "거미줄 로프";
				case 3079:
					return "실크 로프 뭉치";
				case 3080:
					return "거미줄 로프 뭉치";
				case 3081:
					return "대리석 블록";
				case 3082:
					return "대리석 벽";
				case 3083:
					return "부드러운 대리석 벽";
				case 3084:
					return "레이더";
				case 3085:
					return "잠긴 황금 상자";
				case 3086:
					return "화강암 블록";
				case 3087:
					return "부드러운 화강암 블록";
				case 3088:
					return "화강암 벽";
				case 3089:
					return "부드러운 화강암 벽";
				case 3090:
					return "로열 젤리";
				case 3091:
					return "밤의 열쇠";
				case 3092:
					return "빛의 열쇠";
				case 3093:
					return "허브 가방";
				case 3094:
					return "투창";
				case 3095:
					return "Tally Counter";
				case 3096:
					return "Sextant";
				case 3097:
					return "크툴후의 방패";
				case 3098:
					return "도살자의 전기톱";
				case 3099:
					return "스톱워치";
				case 3100:
					return "Meteorite Brick";
				case 3101:
					return "Meteorite Brick Wall";
				case 3102:
					return "금속 탐지기";
				case 3103:
					return "Endless Quiver";
				case 3104:
					return "Endless Musket Pouch";
				case 3105:
					return "독성 플라스크";
				case 3106:
					return "사이코의 칼";
				case 3107:
					return "네일 건";
				case 3108:
					return "못";
				case 3109:
					return "야간 투시 헬멧";
				case 3110:
					return "Celestial Shell";
				case 3111:
					return "분홍 젤";
				case 3112:
					return "Bouncy Glowstick";
				case 3113:
					return "분홍 슬라임 블록";
				case 3114:
					return "분홍 횃불";
				case 3115:
					return "Bouncy Bomb";
				case 3116:
					return "Bouncy Grenade";
				case 3117:
					return "평화의 촛불";
				case 3118:
					return "Lifeform Analyzer";
				case 3119:
					return "DPS 측정기";
				case 3120:
					return "Fisherman's Pocket Guide";
				case 3121:
					return "Goblin Tech";
				case 3122:
					return "R.E.K. 3000";
				case 3123:
					return "PDA";
				case 3124:
					return "휴대전화";
				case 3125:
					return "화강암 상자";
				case 3126:
					return "운석 시계";
				case 3127:
					return "대리석 시계";
				case 3128:
					return "화강암 시계";
				case 3129:
					return "운석 문";
				case 3130:
					return "대리석 문";
				case 3131:
					return "화강암 문";
				case 3132:
					return "Meteorite Dresser";
				case 3133:
					return "Marble Dresser";
				case 3134:
					return "Granite Dresser";
				case 3135:
					return "운석 램프";
				case 3136:
					return "대리석 램프";
				case 3137:
					return "화강암 램프";
				case 3138:
					return "운석 랜턴";
				case 3139:
					return "대리석 랜턴";
				case 3140:
					return "화강암 랜턴";
				case 3141:
					return "운석 피아노";
				case 3142:
					return "대리석 피아노";
				case 3143:
					return "화강암 피아노";
				case 3144:
					return "운석 플랫폼";
				case 3145:
					return "대리석 플랫폼";
				case 3146:
					return "화강암 플랫폼";
				case 3147:
					return "Meteorite Sink";
				case 3148:
					return "Marble Sink";
				case 3149:
					return "Granite Sink";
				case 3150:
					return "운석 소파";
				case 3151:
					return "대리석 소파";
				case 3152:
					return "화강암 소파";
				case 3153:
					return "운석 테이블";
				case 3154:
					return "대리석 테이블";
				case 3155:
					return "화강암 테이블";
				case 3156:
					return "운석 작업대";
				case 3157:
					return "대리석 작업대";
				case 3158:
					return "화강암 작업대";
				case 3159:
					return "운석 욕조";
				case 3160:
					return "대리석 욕조";
				case 3161:
					return "화강암 욕조";
				case 3162:
					return "Meteorite Bed";
				case 3163:
					return "Marble Bed";
				case 3164:
					return "Granite Bed";
				case 3165:
					return "Meteorite Bookcase";
				case 3166:
					return "Marble Bookcase";
				case 3167:
					return "Granite Bookcase";
				case 3168:
					return "Meteorite Candelabra";
				case 3169:
					return "Marble Candelabra";
				case 3170:
					return "Granite Candelabra";
				case 3171:
					return "Meteorite Candle";
				case 3172:
					return "Marble Candle";
				case 3173:
					return "Granite Candle";
				case 3174:
					return "Meteorite Chair";
				case 3175:
					return "Marble Chair";
				case 3176:
					return "Granite Chair";
				case 3177:
					return "Meteorite Chandelier";
				case 3178:
					return "Marble Chandelier";
				case 3179:
					return "Granite Chandelier";
				case 3180:
					return "Meteorite Chest";
				case 3181:
					return "Marble Chest";
				case 3182:
					return "Magic Water Dropper";
				case 3183:
					return "Golden Bug Net";
				case 3184:
					return "Magic Lava Dropper";
				case 3185:
					return "Magic Honey Dropper";
				case 3186:
					return "Empty Dropper";
				case 3187:
					return "Gladiator Helmet";
				case 3188:
					return "Gladiator Breastplate";
				case 3189:
					return "Gladiator Leggings";
				case 3190:
					return "Reflective Dye";
				case 3191:
					return "Enchanted Nightcrawler";
				case 3192:
					return "Grubby";
				case 3193:
					return "Sluggy";
				case 3194:
					return "Buggy";
				case 3195:
					return "Grub Soup";
				case 3196:
					return "Bomb Fish";
				case 3197:
					return "Frost Daggerfish";
				case 3198:
					return "Sharpening Station";
				case 3199:
					return "Ice Mirror";
				case 3200:
					return "Sailfish Boots";
				case 3201:
					return "Tsunami in a Bottle";
				case 3202:
					return "Target Dummy";
				case 3203:
					return "Corrupt Crate";
				case 3204:
					return "Crimson Crate";
				case 3205:
					return "Dungeon Crate";
				case 3206:
					return "Sky Crate";
				case 3207:
					return "Hallowed Crate";
				case 3208:
					return "Jungle Crate";
				case 3209:
					return "Crystal Serpent";
				case 3210:
					return "Toxikarp";
				case 3211:
					return "Bladetongue";
				case 3212:
					return "Shark Tooth Necklace";
				case 3213:
					return "Money Trough";
				case 3214:
					return "Bubble";
				case 3215:
					return "Daybloom Planter Box";
				case 3216:
					return "Moonglow Planter Box";
				case 3217:
					return "Deathweed Planter Box";
				case 3218:
					return "Deathweed Planter Box";
				case 3219:
					return "Blinkroot Planter Box";
				case 3220:
					return "Waterleaf Planter Box";
				case 3221:
					return "Shiverthorn Planter Box";
				case 3222:
					return "Fireblossom Planter Box";
				case 3223:
					return "Brain of Confusion";
				case 3224:
					return "Worm Scarf";
				case 3225:
					return "Balloon Pufferfish";
				case 3226:
					return "Lazure's Valkyrie Circlet";
				case 3227:
					return "Lazure's Valkyrie Cloak";
				case 3228:
					return "Lazure's Barrier Platform";
				case 3229:
					return "Golden Cross Grave Marker";
				case 3230:
					return "Golden Tombstone";
				case 3231:
					return "Golden Grave Marker";
				case 3232:
					return "Golden Gravestone";
				case 3233:
					return "Golden Headstone";
				case 3234:
					return "Crystal Block";
				case 3235:
					return "Music Box (Martian Madness)";
				case 3236:
					return "Music Box (Pirate Invasion)";
				case 3237:
					return "Music Box (Hell)";
				case 3238:
					return "Crystal Block Wall";
				case 3239:
					return "Trap Door";
				case 3240:
					return "Tall Gate";
				case 3241:
					return "Sharkron Balloon";
				case 3242:
					return "Tax Collector's Hat";
				case 3243:
					return "Tax Collector's Suit";
				case 3244:
					return "Tax Collector's Pants";
				case 3245:
					return "Bone Glove";
				case 3246:
					return "Clothier's Jacket";
				case 3247:
					return "Clothier's Pants";
				case 3248:
					return "Dye Trader's Turban";
				case 3249:
					return "Deadly Sphere Staff";
				case 3250:
					return "Green Horseshoe Balloon";
				case 3251:
					return "Amber Horseshoe Balloon";
				case 3252:
					return "Pink Horseshoe Balloon";
				case 3253:
					return "Lava Lamp";
				case 3254:
					return "Enchanted Nightcrawler Cage";
				case 3255:
					return "Buggy Cage";
				case 3256:
					return "Grubby Cage";
				case 3257:
					return "Sluggy Cage";
				case 3258:
					return "Slap Hand";
				case 3259:
					return "Twilight Hair Dye";
				case 3260:
					return "Blessed Apple";
				case 3261:
					return "Spectre Bar";
				case 3262:
					return "Code 1";
				case 3263:
					return "Buccaneer Bandana";
				case 3264:
					return "Buccaneer Tunic";
				case 3265:
					return "Buccaneer Pantaloons";
				case 3266:
					return "Obsidian Outlaw Hat";
				case 3267:
					return "Obsidian Longcoat";
				case 3268:
					return "Obsidian Pants";
				case 3269:
					return "Medusa Head";
				case 3270:
					return "Item Frame";
				case 3271:
					return "Sandstone Block";
				case 3272:
					return "Hardened Sand Block";
				case 3273:
					return "Sandstone Wall";
				case 3274:
					return "Hardened Ebonsand Block";
				case 3275:
					return "Hardened Crimsand Block";
				case 3276:
					return "Ebonsandstone Block";
				case 3277:
					return "Crimsandstone Block";
				case 3278:
					return "Wooden Yoyo";
				case 3279:
					return "Malaise";
				case 3280:
					return "Artery";
				case 3281:
					return "Amazon";
				case 3282:
					return "Cascade";
				case 3283:
					return "Chik";
				case 3284:
					return "Code 2";
				case 3285:
					return "Rally";
				case 3286:
					return "Yelets";
				case 3287:
					return "Red's Throw";
				case 3288:
					return "Valkyrie Yoyo";
				case 3289:
					return "Amarok";
				case 3290:
					return "Hel-Fire";
				case 3291:
					return "Kraken";
				case 3292:
					return "The Eye of Cthulhu";
				case 3293:
					return "Red String";
				case 3294:
					return "Orange String";
				case 3295:
					return "Yellow String";
				case 3296:
					return "Lime String";
				case 3297:
					return "Green String";
				case 3298:
					return "Teal String";
				case 3299:
					return "Cyan String";
				case 3300:
					return "Sky Blue String";
				case 3301:
					return "Blue String";
				case 3302:
					return "Purple String";
				case 3303:
					return "Violet String";
				case 3304:
					return "Pink String";
				case 3305:
					return "Brown String";
				case 3306:
					return "White String";
				case 3307:
					return "Rainbow String";
				case 3308:
					return "Black String";
				case 3309:
					return "Black Counterweight";
				case 3310:
					return "Blue Counterweight";
				case 3311:
					return "Green Counterweight";
				case 3312:
					return "Purple Counterweight";
				case 3313:
					return "Red Counterweight";
				case 3314:
					return "Yellow Counterweight";
				case 3315:
					return "Format:C";
				case 3316:
					return "Gradient";
				case 3317:
					return "Valor";
				case 3318:
					return "Treasure Bag";
				case 3319:
					return "Treasure Bag";
				case 3320:
					return "Treasure Bag";
				case 3321:
					return "Treasure Bag";
				case 3322:
					return "Treasure Bag";
				case 3323:
					return "Treasure Bag";
				case 3324:
					return "Treasure Bag";
				case 3325:
					return "Treasure Bag";
				case 3326:
					return "Treasure Bag";
				case 3327:
					return "Treasure Bag";
				case 3328:
					return "Treasure Bag";
				case 3329:
					return "Treasure Bag";
				case 3330:
					return "Treasure Bag";
				case 3331:
					return "Treasure Bag";
				case 3332:
					return "Treasure Bag";
				case 3333:
					return "Hive Pack";
				case 3334:
					return "Yoyo Glove";
				case 3335:
					return "Demon Heart";
				case 3336:
					return "Spore Sac";
				case 3337:
					return "Shiny Stone";
				case 3338:
					return "Hardened Pearlsand Block";
				case 3339:
					return "Pearlsandstone Block";
				case 3340:
					return "Hardened Sand Wall";
				case 3341:
					return "Hardened Ebonsand Wall";
				case 3342:
					return "Hardened Crimsand Wall";
				case 3343:
					return "Hardened Pearlsand Wall";
				case 3344:
					return "Ebonsandstone Wall";
				case 3345:
					return "Crimsandstone Wall";
				case 3346:
					return "Pearlsandstone Wall";
				case 3347:
					return "Desert Fossil";
				case 3348:
					return "Desert Fossil Wall";
				case 3349:
					return "Exotic Scimitar";
				case 3350:
					return "Paintball Gun";
				case 3351:
					return "Classy Cane";
				case 3352:
					return "Stylish Scissors";
				case 3353:
					return "Mechanical Cart";
				case 3354:
					return "Mechanical Wheel Piece";
				case 3355:
					return "Mechanical Wagon Piece";
				case 3356:
					return "Mechanical Battery Piece";
				case 3357:
					return "Ancient Cultist Trophy";
				case 3358:
					return "Martian Saucer Trophy";
				case 3359:
					return "Flying Dutchman Trophy";
				case 3360:
					return "Living Mahogany Wand";
				case 3361:
					return "Rich Mahogany Leaf Wand";
				case 3362:
					return "Fallen Tuxedo Shirt";
				case 3363:
					return "Fallen Tuxedo Pants";
				case 3364:
					return "Fireplace";
				case 3365:
					return "Chimney";
				case 3366:
					return "Yoyo Bag";
				case 3367:
					return "Shrimpy Truffle";
				case 3368:
					return "Arkhalis";
				case 3369:
					return "Confetti Cannon";
				case 3370:
					return "Music Box (The Towers)";
				case 3371:
					return "Music Box (Goblin Invasion)";
				case 3372:
					return "Ancient Cultist Mask";
				case 3373:
					return "Moon Lord Mask";
				case 3374:
					return "Fossil Helmet";
				case 3375:
					return "Fossil Plate";
				case 3376:
					return "Fossil Greaves";
				case 3377:
					return "Amber Staff";
				case 3378:
					return "Bone Javelin";
				case 3379:
					return "Bone Throwing Knife";
				case 3380:
					return "Sturdy Fossil";
				case 3381:
					return "Stardust Helmet";
				case 3382:
					return "Stardust Plate";
				case 3383:
					return "Stardust Leggings";
				case 3384:
					return "Portal Gun";
				case 3385:
				case 3386:
				case 3387:
				case 3388:
					return "Strange Plant";
				case 3389:
					return "Terrarian";
				case 3390:
					return "Goblin Summoner Banner";
				case 3391:
					return "Salamander Banner";
				case 3392:
					return "Giant Shelly Banner";
				case 3393:
					return "Crawdad Banner";
				case 3394:
					return "Fritz Banner";
				case 3395:
					return "Creature From The Deep Banner";
				case 3396:
					return "Dr. Man Fly Banner";
				case 3397:
					return "Mothron Banner";
				case 3398:
					return "Severed Hand Banner";
				case 3399:
					return "The Possessed Banner";
				case 3400:
					return "Butcher Banner";
				case 3401:
					return "Psycho Banner";
				case 3402:
					return "Deadly Sphere Banner";
				case 3403:
					return "Nailhead Banner";
				case 3404:
					return "Poisonous Spore Banner";
				case 3405:
					return "Medusa Banner";
				case 3406:
					return "Hoplite Banner";
				case 3407:
					return "Granite Elemental Banner";
				case 3408:
					return "Grolem Banner";
				case 3409:
					return "Blood Zombie Banner";
				case 3410:
					return "Drippler Banner";
				case 3411:
					return "Tomb Crawler Banner";
				case 3412:
					return "Dune Splicer Banner";
				case 3413:
					return "Antlion Swarmer Banner";
				case 3414:
					return "Antlion Charger Banner";
				case 3415:
					return "Ghoul Banner";
				case 3416:
					return "Lamia Banner";
				case 3417:
					return "Desert Spirit Banner";
				case 3418:
					return "Basilisk Banner";
				case 3419:
					return "Ravager Scorpion Banner";
				case 3420:
					return "Stargazer Banner";
				case 3421:
					return "Milkyway Weaver Banner";
				case 3422:
					return "Flow Invader Banner";
				case 3423:
					return "Twinkle Popper Banner";
				case 3424:
					return "Small Star Cell Banner";
				case 3425:
					return "Star Cell Banner";
				case 3426:
					return "Corite Banner";
				case 3427:
					return "Sroller Banner";
				case 3428:
					return "Crawltipede Banner";
				case 3429:
					return "Drakomire Rider Banner";
				case 3430:
					return "Drakomire Banner";
				case 3431:
					return "Selenian Banner";
				case 3432:
					return "Predictor Banner";
				case 3433:
					return "Brain Suckler Banner";
				case 3434:
					return "Nebula Floater Banner";
				case 3435:
					return "Evolution Beast Banner";
				case 3436:
					return "Alien Larva Banner";
				case 3437:
					return "Alien Queen Banner";
				case 3438:
					return "Alien Hornet Banner";
				case 3439:
					return "Vortexian Banner";
				case 3440:
					return "Storm Diver Banner";
				case 3441:
					return "Pirate Captain Banner";
				case 3442:
					return "Pirate Deadeye Banner";
				case 3443:
					return "Pirate Corsair Banner";
				case 3444:
					return "Pirate Crossbower Banner";
				case 3445:
					return "Martian Walker Banner";
				case 3446:
					return "Red Devil Banner";
				case 3447:
					return "Pink Jellyfish Banner";
				case 3448:
					return "Green Jellyfish Banner";
				case 3449:
					return "Dark Mummy Banner";
				case 3450:
					return "Light Mummy Banner";
				case 3451:
					return "Angry Bones Banner";
				case 3452:
					return "Ice Tortoise Banner";
				case 3453:
					return "Damage Booster";
				case 3454:
					return "Life Booster";
				case 3455:
					return "Mana Booster";
				case 3456:
					return "Vortex Fragment";
				case 3457:
					return "Nebula Fragment";
				case 3458:
					return "Solar Fragment";
				case 3459:
					return "Stardust Fragment";
				case 3460:
					return "Luminite";
				case 3461:
					return "Luminite Brick";
				case 3462:
					return "Stardust Axe";
				case 3463:
					return "Stardust Chainsaw";
				case 3464:
					return "Stardust Drill";
				case 3465:
					return "Stardust Hammer";
				case 3466:
					return "Stardust Pickaxe";
				case 3467:
					return "Luminite Bar";
				case 3468:
					return "Solar Wings";
				case 3469:
					return "Vortex Booster";
				case 3470:
					return "Nebula Mantle";
				case 3471:
					return "Stardust Wings";
				case 3472:
					return "Luminite Brick Wall";
				case 3473:
					return "Solar Eruption";
				case 3474:
					return "Stardust Cell Staff";
				case 3475:
					return "Vortex Beater";
				case 3476:
					return "Nebula Arcanum";
				case 3477:
					return "Blood Water";
				case 3478:
					return "Wedding Veil";
				case 3479:
					return "Wedding Dress";
				case 3480:
					return "Platinum Bow";
				case 3481:
					return "Platinum Hammer";
				case 3482:
					return "Platinum Axe";
				case 3483:
					return "Platinum Shortsword";
				case 3484:
					return "Platinum Broadsword";
				case 3485:
					return "Platinum Pickaxe";
				case 3486:
					return "Tungsten Bow";
				case 3487:
					return "Tungsten Hammer";
				case 3488:
					return "Tungsten Axe";
				case 3489:
					return "Tungsten Shortsword";
				case 3490:
					return "Tungsten Broadsword";
				case 3491:
					return "Tungsten Pickaxe";
				case 3492:
					return "Lead Bow";
				case 3493:
					return "Lead Hammer";
				case 3494:
					return "Lead Axe";
				case 3495:
					return "Lead Shortsword";
				case 3496:
					return "Lead Broadsword";
				case 3497:
					return "Lead Pickaxe";
				case 3498:
					return "Tin Bow";
				case 3499:
					return "Tin Hammer";
				case 3500:
					return "Tin Axe";
				case 3501:
					return "Tin Shortsword";
				case 3502:
					return "Tin Broadsword";
				case 3503:
					return "Tin Pickaxe";
				case 3504:
					return "Copper Bow";
				case 3505:
					return "Copper Hammer";
				case 3506:
					return "Copper Axe";
				case 3507:
					return "Copper Shortsword";
				case 3508:
					return "Copper Broadsword";
				case 3509:
					return "Copper Pickaxe";
				case 3510:
					return "Silver Bow";
				case 3511:
					return "Silver Hammer";
				case 3512:
					return "Silver Axe";
				case 3513:
					return "Silver Shortsword";
				case 3514:
					return "Silver Broadsword";
				case 3515:
					return "Silver Pickaxe";
				case 3516:
					return "Gold Bow";
				case 3517:
					return "Gold Hammer";
				case 3518:
					return "Gold Axe";
				case 3519:
					return "Gold Shortsword";
				case 3520:
					return "Gold Broadsword";
				case 3521:
					return "Gold Pickaxe";
				case 3522:
					return "Solar Flare Hamaxe";
				case 3523:
					return "Vortex Hamaxe";
				case 3524:
					return "Nebula Hamaxe";
				case 3525:
					return "Stardust Hamaxe";
				case 3526:
					return "Solar Dye";
				case 3527:
					return "Nebula Dye";
				case 3528:
					return "Vortex Dye";
				case 3529:
					return "Stardust Dye";
				case 3530:
					return "Void Dye";
				case 3531:
					return "Stardust Dragon Staff";
				case 3532:
					return "Bacon";
				case 3533:
					return "Shifting Sands Dye";
				case 3534:
					return "Mirage Dye";
				case 3535:
					return "Shifting Pearlsands Dye";
				case 3536:
					return "Vortex Monolith";
				case 3537:
					return "Nebula Monolith";
				case 3538:
					return "Stardust Monolith";
				case 3539:
					return "Solar Monolith";
				case 3540:
					return "Phantasm";
				case 3541:
					return "Last Prism";
				case 3542:
					return "Nebula Blaze";
				case 3543:
					return "Daybreak";
				case 3544:
					return "Super Healing Potion";
				case 3545:
					return "Detonator";
				case 3546:
					return "Celebration";
				case 3547:
					return "Bouncy Dynamite";
				case 3548:
					return "Happy Grenade";
				case 3549:
					return "Ancient Manipulator";
				case 3550:
					return "Flame and Silver Dye";
				case 3551:
					return "Green Flame and Silver Dye";
				case 3552:
					return "Blue Flame and Silver Dye";
				case 3553:
					return "Reflective Copper Dye";
				case 3554:
					return "Reflective Obsidian Dye";
				case 3555:
					return "Reflective Metal Dye";
				case 3556:
					return "Midnight Rainbow Dye";
				case 3557:
					return "Black and White Dye";
				case 3558:
					return "Bright Silver Dye";
				case 3559:
					return "Silver and Black Dye";
				case 3560:
					return "Red Acid Dye";
				case 3561:
					return "Gel Dye";
				case 3562:
					return "Pink Gel Dye";
				case 3563:
					return "Red Squirrel";
				case 3564:
					return "Gold Squirrel";
				case 3565:
					return "Red Squirrel Cage";
				case 3566:
					return "Gold Squirrel Cage";
				case 3567:
					return "Luminite Bullet";
				case 3568:
					return "Luminite Arrow";
				case 3569:
					return "Lunar Portal Staff";
				case 3570:
					return "Lunar Flare";
				case 3571:
					return "Rainbow Crystal Staff";
				case 3572:
					return "Lunar Hook";
				case 3573:
					return "Solar Fragment Block";
				case 3574:
					return "Vortex Fragment Block";
				case 3575:
					return "Nebula Fragment Block";
				case 3576:
					return "Stardust Fragment Block";
				case 3577:
					return "Suspicious Looking Tentacle";
				case 3578:
					return "Yoraiz0r's Uniform";
				case 3579:
					return "Yoraiz0r's Skirt";
				case 3580:
					return "Yoraiz0r's Spell";
				case 3581:
					return "Yoraiz0r's Scowl";
				case 3582:
					return "Jim's Wings";
				case 3583:
					return "Yoraiz0r's Recolored Goggles";
				case 3584:
					return "Living Leaf Wall";
				case 3585:
					return "Skiphs's Mask";
				case 3586:
					return "Skiphs's Skin";
				case 3587:
					return "Skiphs's Bear Butt";
				case 3588:
					return "Skiphs's Paws";
				case 3589:
					return "Loki's Helmet";
				case 3590:
					return "Loki's Breastplate";
				case 3591:
					return "Loki's Greaves";
				case 3592:
					return "Loki's Wings";
				case 3593:
					return "Sand Slime Banner";
				case 3594:
					return "Sea Snail Banner";
				case 3595:
					return "Moon Lord Trophy";
				case 3596:
					return "Not a Kid, nor a Squid";
				case 3597:
					return "Burning Hades Dye";
				case 3598:
					return "Grim Dye";
				case 3599:
					return "Loki's Dye";
				case 3600:
					return "Shadowflame Hades Dye";
				case 3601:
					return "Celestial Sigil";
				default:
					return "";
				#endregion
			}

			return "";
		}

		public static string titleText(int l)
		{
			int num = Main.rand.Next(54);

			switch (num)
			{
				case 0:
					return "테라리아 : 삽질해 호구야 삽질!";
				case 1:
					return "테라리아 : 좀 쩌는 흙";
				case 2:
					return "테라리아 : 녹-조류!";
				case 3:
					return "테라리아 : 압도적인 모래";
				case 4:
					return "테라리아 3 장 : 도우미의 귀환";
				case 5:
					return "테라리아 : 토끼 이야기";
				case 6:
					return "테라리아 : 닥터 본즈와 적월의 신전";
				case 7:
					return "테라리아 : 슬라이기 공원";
				case 8:
					return "테라리아 : 이쪽 풀이 저쪽 풀 보다 더 푸르다";
				case 9:
					return "테라리아 : 이 작은 블럭들은 5세 미만을 위한 것이 아닙니다.";
				case 10:
					return "테라리아 : 삽질마스터 T의 블럭";
				case 11:
					return "테라리아 : 젖소를 위한 레이어는 없습니다.";
				case 12:
					return "테라리아 : 수상해 보이는 눈깔들";
				case 13:
					return "테라리아 : 보라색 잔디!";
				case 14:
					return "테라리아 : 내 뒤에서 땅 파지 마아아아아아";
				case 15:
					return "테라리아 : 폭포도 포함되어 있습니다.";
				case 16:
					return "테라리아 : 어스바운드";
				case 17:
					return "테라리아 : 거기, 아무것도 없는데 정말 삽질을 하는군 그래.";
				case 18:
					return "테라리아 : 광물 단계의 끝은 음... 글쎄 음...";
				case 19:
					return "테라리아 : 심판의 진흙";
				case 20:
					return "테라리아 : 끔찍한 문제";
				case 21:
					return "테라리아 : 강압적인 모의 실험";
				case 22:
					return "테라리아 : 개발자 Red를 구속했습니다.";
				case 23:
					return "테라리아 : 슬라임들, 한물 가다.";
				case 24:
					return "테라리아 : 생각보다 많은 것들이 당신을 죽이려 할 겁니다.";
				case 25:
					return "테라리아 : 도우미가 죽었다는게 좀 과장되지 않았어?";
				case 26:
					return "테라리아 : 불쌍한 도구";
				case 27:
					return "테라리아 : 저기, 잘 못 들었지 말입니다?";
				case 28:
					return "테라리아 : 그들은 내게 '컴퓨터를 새로 장만해' 라고 하지...";
				case 29:
					return "테라리아 : 블럭들이 당신과 함께 하기를";
				case 30:
					return "테라리아 : 좀 더 나은 삶";
				case 31:
					return "테라리아 : 테라리아 : 테라리아 :";
				case 32:
					return "테라리아 : 지금은 1차원 입니다.";
				case 33:
					return "테라리아 : 곧 컴퓨터로 출시 예정";
				case 34:
					return "테라리아 : 0으로 나누기";
				case 35:
					return "테라리아 : 지금은 소리와 함께 하고 있습니다.";
				case 36:
					return "테라리아 : Alt와 F4를 동시에 눌러 보세요.";
				case 37:
					return "테라리아 : 난 불쌍한 도구야";
				case 38:
					return "테라리아 : 모래 동생입니까?";
				case 39:
					return "테라리아 : 삽질하기 좋은 날!";
				case 40:
					return "테라리아 : 너 다시-땅-팔수있어?";
				case 41:
					return "테라리아 : 나 그거 몰라아아아아아---!";
				case 42:
					return "테라리아 : 저 보라색 가시를 뭐라고 생각해?";
				case 43:
					return "테라리아 : 나는 가이드가 되고 싶어요";
				case 44:
					return "테라리아 : 크툴후는 미치광이에 눈을 잃어버렸습니다.";
				case 45:
					return "테라리아 : 제발 벌만은!";
				case 46:
					return "테라리아 : 막스의 전설";
				case 47:
					return "테라리아 : 제닉스의 신화";
				case 48:
					return "테라리아 2 : 짜릿한 부가루";
				case 49:
					return "테라리아 : 마인크래프트도 해봐!";
				case 50:
					return "테라리아 : 에지 오브 스페이스도 해봐!";
				case 51:
					return "테라리아 : 난 금이 어디에 있는지 알고 싶은데...";
				case 52:
					return "테라리아 : 언제 죽을 지 모릅니다.";
				case 53:
					return "테라리아 : 닥치고 땅을 파!";
				case 54:
					return "테라리아 : 스타바운드도 해봐!";
				default:
					return "";
			}
		}

		public void setLang(int l)
		{
			Lang.misc[0] = "고블린 군대를 물리쳤습니다!";
			Lang.misc[1] = "고블린 군대가 서쪽으로 접근하고 있습니다!";
			Lang.misc[2] = "고블린 군대가 동쪽으로 접근하고 있습니다!";
			Lang.misc[3] = "고블린 군대가 도착했습니다!";
			Lang.misc[4] = "한기의 군단을 물리쳤습니다!";
			Lang.misc[5] = "한기의 군단이 서쪽으로 접근하고 있습니다!";
			Lang.misc[6] = "한기의 군단이 동쪽으로 접근하고 있습니다!";
			Lang.misc[7] = "한기의 군단이 도착했습니다!";
			Lang.misc[8] = "붉은 달이 떠오릅니다...";
			Lang.misc[9] = "당신은 악의 존재가 지켜보고 있는걸 느끼고 있습니다...";
			Lang.misc[10] = "무서운 냉기로 인해 등골이 오싹해지고 있습니다...";
			Lang.misc[11] = "비명 소리가 당신 주위에 울려퍼집니다...";
			Lang.misc[12] = "당신의 세계는 코발트로 축복되었습니다!";
			Lang.misc[13] = "당신의 세계는 미스릴로 축복되었습니다!";
			Lang.misc[14] = "당신의 세계는 아다만타이트로 축복되었습니다";
			Lang.misc[15] = "빛과 어둠의 고대 영혼이 풀려났습니다.";
			Lang.misc[16] = "이(가) 깨어났습니다!";
			Lang.misc[17] = "을(를) 물리쳤습니다!";
			Lang.misc[18] = "이(가) 도착했습니다!";
			Lang.misc[19] = "이(가) 살해되었습니다...";
			Lang.misc[20] = "일식이 일어났습니다!";
			Lang.misc[21] = "당신의 세계는 팔라듐으로 축복되었습니다!";
			Lang.misc[22] = "당신의 세계는 오리칼쿰으로 축복되었습니다!";
			Lang.misc[23] = "당신의 세계는 티타늄으로 축복되었습니다!";
			Lang.misc[24] = "해적들을 물리쳤습니다!";
			Lang.misc[25] = "해적들이 서쪽으로 접근하고 있습니다!";
			Lang.misc[26] = "해적들이 동쪽으로 접근하고 있습니다!";
			Lang.misc[27] = "해적들이 도착했습니다!";
			Lang.misc[28] = "당신은 지하 깊은 곳으로부터 진동을 느꼈습니다...";
			Lang.misc[29] = "끔찍한 밤이 될 것입니다...";
			Lang.misc[30] = "당신을 둘러싼 공기가 차가워지고 있습니다...";
			Lang.misc[31] = "호박 달이 떠오릅니다...";
			Lang.misc[32] = "정글이 끊임없이 자라고 있습니다...";
			Lang.misc[33] = "던전에서부터 비명이 울려퍼집니다...";
			Lang.misc[34] = "얼어붙은 달이 떠오릅니다...";
			Lang.misc[35] = "이(가) 출발했습니다!";
			Lang.misc[36] = "이(가) 떠났습니다!";
			Lang.misc[37] = "아무 종류의 ";
			Lang.misc[38] = "압력판";
			Lang.misc[39] = " and increased life regeneration";
			Lang.misc[40] = "Increases life regeneration";
			Lang.misc[41] = "Martians are invading!";
			Lang.misc[42] = "The martians have been defeated!";
			Lang.misc[43] = "Celestial creatures are invading!";
			Lang.misc[44] = "Your mind goes numb...";
			Lang.misc[45] = "You are overwhelmed with pain...";
			Lang.misc[46] = "Otherworldly voices linger around you...";
			Lang.misc[47] = "The Moon Lord has awoken!";
			Lang.misc[48] = "The Twins have awoken!";
			Lang.misc[49] = "You wake up from a strange dream...";
			Lang.misc[50] = "have been defeated!";
			Lang.misc[51] = "Lunar Fragment";
			Lang.misc[52] = "Impending doom approaches...";
			Lang.menu[0] = "테라리아의 새로운 시작에 참여하세요!";
			Lang.menu[1] = "포트가 사용 중입니다.";
			Lang.menu[2] = "연결해제";
			Lang.menu[3] = "서버 비밀번호가 필요합니다 : ";
			Lang.menu[4] = "수락";
			Lang.menu[5] = "뒤로";
			Lang.menu[6] = "취소";
			Lang.menu[7] = "서버 비밀번호 입력 :";
			Lang.menu[8] = "서버를 시작합니다...";
			Lang.menu[9] = "불러오기 실패!";
			Lang.menu[10] = "백업을 읽습니다";
			Lang.menu[11] = "백업을 찾을 수 없습니다";
			Lang.menu[12] = "혼자 하기";
			Lang.menu[13] = "함께 하기";
			Lang.menu[14] = "설정";
			Lang.menu[15] = "나가기";
			Lang.menu[16] = "캐릭터 만들기";
			Lang.menu[17] = "삭제";
			Lang.menu[18] = "머리";
			Lang.menu[19] = "눈";
			Lang.menu[20] = "피부";
			Lang.menu[21] = "옷";
			Lang.menu[22] = "남성";
			Lang.menu[23] = "여성";
			Lang.menu[24] = "매우 어려움";
			Lang.menu[25] = "조금 어려움";
			Lang.menu[26] = "일반적인";
			Lang.menu[27] = "무작위";
			Lang.menu[28] = "생성";
			Lang.menu[29] = "우훗, 매우 어려움 하지 않겠는가.";
			Lang.menu[30] = "조금 어려움을 선택한 캐릭터는 죽게 되면 모든 아이템을 잃고 부활하게 됩니다.";
			Lang.menu[31] = "일반적인 캐릭터는 죽게 되면 절반정도의 돈을 잃고 부활하게 됩니다.";
			Lang.menu[32] = "난이도를 선택하세요";
			Lang.menu[33] = "상의";
			Lang.menu[34] = "속상의";
			Lang.menu[35] = "하의";
			Lang.menu[36] = "신발";
			Lang.menu[37] = "머리";
			Lang.menu[38] = "머리색";
			Lang.menu[39] = "눈색";
			Lang.menu[40] = "피부색";
			Lang.menu[41] = "상의 색깔";
			Lang.menu[42] = "속상의 색깔";
			Lang.menu[43] = "하의 색깔";
			Lang.menu[44] = "신발 색깔";
			Lang.menu[45] = "캐릭터 이름을 입력하세요 : ";
			Lang.menu[46] = "삭제";
			Lang.menu[47] = "월드 생성";
			Lang.menu[48] = "월드 이름을 입력하세요 : ";
			Lang.menu[49] = "창모드로";
			Lang.menu[50] = "전체화면으로";
			Lang.menu[51] = "해상도";
			Lang.menu[52] = "수직 동기화";
			Lang.menu[53] = "프레임 스킵 : 끄기";
			Lang.menu[54] = "프레임 스킵 : 켜기";
			Lang.menu[55] = "광원효과 : 컬러";
			Lang.menu[56] = "광원효과 : 화이트";
			Lang.menu[57] = "광원효과 : 레트로";
			Lang.menu[58] = "광원효과 : 트리피";
			Lang.menu[59] = "품질 : 자동";
			Lang.menu[60] = "품질 : 높음";
			Lang.menu[61] = "품질 : 중간";
			Lang.menu[62] = "품질 : 낮음";
			Lang.menu[63] = "비디오";
			Lang.menu[64] = "커서 색상";
			Lang.menu[65] = "음량";
			Lang.menu[66] = "조작 설정";
			Lang.menu[67] = "자동저장 : 켜기";
			Lang.menu[68] = "자동저장 : 끄기";
			Lang.menu[69] = "자동멈춤 : 켜기";
			Lang.menu[70] = "자동멈춤 : 끄기";
			Lang.menu[71] = "아이템 줍기 알림 On";
			Lang.menu[72] = "아이템 줍기 알림 Off";
			Lang.menu[73] = "전체화면 해상도";
			Lang.menu[74] = "위				  ";
			Lang.menu[75] = "아래				";
			Lang.menu[76] = "왼쪽				";
			Lang.menu[77] = "오른쪽				";
			Lang.menu[78] = "점프				 ";
			Lang.menu[79] = "던지기			  ";
			Lang.menu[80] = "보관함			   ";
			Lang.menu[81] = "회복물약 단축키	   ";
			Lang.menu[82] = "마나물약 단축키	  ";
			Lang.menu[83] = "버프물약 단축키	   ";
			Lang.menu[84] = "잡기				 ";
			Lang.menu[85] = "자동 선택			 ";
			Lang.menu[86] = "기본설정으로";
			Lang.menu[87] = "참가";
			Lang.menu[88] = "서버 제공 및 플레이";
			Lang.menu[89] = "서버 아이피 주소 : ";
			Lang.menu[90] = "서버 포트 :";
			Lang.menu[91] = "월드 크기 선택 : ";
			Lang.menu[92] = "작음";
			Lang.menu[93] = "중간";
			Lang.menu[94] = "대형";
			Lang.menu[95] = "빨강 : ";
			Lang.menu[96] = "초록 : ";
			Lang.menu[97] = "파랑 : ";
			Lang.menu[98] = "소리 : ";
			Lang.menu[99] = "음악 : ";
			Lang.menu[100] = "배경 이미지 : 켬";
			Lang.menu[101] = "배경 이미지 : 끔";
			Lang.menu[102] = "언어 선택";
			Lang.menu[103] = "언어";
			Lang.menu[104] = "네";
			Lang.menu[105] = "아니오";
			Lang.menu[106] = "맵 형태 전환				";
			Lang.menu[107] = "전체화면 전환				";
			Lang.menu[108] = "확대						   ";
			Lang.menu[109] = "축소							";
			Lang.menu[110] = "투명도 감소					 ";
			Lang.menu[111] = "투명도 증가					 ";
			Lang.menu[112] = "	지도 켜기	   ";
			Lang.menu[113] = "	지도 끄기		";
			Lang.menu[114] = "일반";
			Lang.menu[115] = "맵 설정";
			Lang.menu[116] = "다중코어 광원 :";
			Lang.menu[117] = "끄기";
			Lang.menu[118] = "메뉴 닫기";
			Lang.menu[119] = "환경";
			Lang.menu[120] = "스마트 커서			";
			Lang.menu[121] = "스마트 커서 모드 : 토글";
			Lang.menu[122] = "스마트 커서 모드 : 고정";
			Lang.menu[123] = "이벤트 진행 상황";
			Lang.menu[124] = "끄기";
			Lang.menu[125] = "Timed";
			Lang.menu[126] = "켜기";
			Lang.menu[127] = "Style";
			Lang.menu[128] = "배치 미리보기 켬";
			Lang.menu[129] = "배치 미리보기 끔";
			Lang.menu[130] = "탑승물			 ";
			Lang.menu[131] = "도전 과제";
			Lang.menu[132] = "피와 잔인한 요소를 사용함";
			Lang.menu[133] = "피와 잔인한 요소를 사용하지 않음";
			Lang.menu[134] = "승락";
			Lang.menu[135] = "서버 설정";
			Lang.menu[136] = "스팀 멀티플레이어 : 사용 안함";
			Lang.menu[137] = "스팀 멀티플레이어 : 사용함";
			Lang.menu[138] = "허용할 유저 : 초대만 가능";
			Lang.menu[139] = "허용할 유저 : 친구만 가능";
			Lang.menu[140] = "친구가 초대 가능 : 사용 안함";
			Lang.menu[141] = "친구가 초대 가능 ; 사용함";
			Lang.menu[142] = "친구의 친구 허용 : 허용 안함";
			Lang.menu[143] = "친구의 친구 허용 : 허용함";
			Lang.menu[144] = "시작";
			Lang.menu[145] = "스팀 계정으로 참여합니다";
			Lang.menu[146] = "아이피 주소로 참여합니다";
			Lang.menu[147] = "친구 초대";

			Lang.gen[0] = "월드 지형 생성 중 :";
			Lang.gen[1] = "모래를 넣는 중...";
			Lang.gen[2] = "언덕을 생성하는 중...";
			Lang.gen[3] = "먼지 뒤에 먼지를 두기 :";
			Lang.gen[4] = "흙 속에 돌을 추가하는 중...";
			Lang.gen[5] = "돌 속에 흙을 추가하는 중...";
			Lang.gen[6] = "점토를 추가하는 중...";
			Lang.gen[7] = "구덩이를 무작위로 만드는 중 :";
			Lang.gen[8] = "작은 동굴을 생성하는 중 :";
			Lang.gen[9] = "큰 동굴을 생성하는 중 :";
			Lang.gen[10] = "지면 동굴을 생성하는 중...";
			Lang.gen[11] = "정글을 생성하는 중 :";
			Lang.gen[12] = "하늘 섬을 생성하는 중...";
			Lang.gen[13] = "버섯 배지를 더하는 중...";
			Lang.gen[14] = "흙 속에 진흙을 추가하는 중...";
			Lang.gen[15] = "틈새를 더하는 중...";
			Lang.gen[16] = "반짝임을 더하는 중...";
			Lang.gen[17] = "거미줄을 추가하는 중...";
			Lang.gen[18] = "지하세계를 생성하는 중 :";
			Lang.gen[19] = "물덩이를 더하는 중 :";
			Lang.gen[20] = "지옥을 만드는중 :";
			Lang.gen[21] = "산에 동굴을 생성하는 중...";
			Lang.gen[22] = "해변을 창조하는중...";
			Lang.gen[23] = "보석을 추가하는 중...";
			Lang.gen[24] = "모래에 중력을 적용하는 중 :";
			Lang.gen[25] = "모래 낀 배경을 청소하는 중 :";
			Lang.gen[26] = "제단을 배치하는 중 :";
			Lang.gen[27] = "액체 배치하는 중 :";
			Lang.gen[28] = "생명의 수정을 배치하는 중 :";
			Lang.gen[29] = "동상을 배치하는 중 :";
			Lang.gen[30] = "보물을 숨기는 중 :";
			Lang.gen[31] = "더 많은 보물을 숨기는 중 :";
			Lang.gen[32] = "정글의 보물을 숨기는 중 :";
			Lang.gen[33] = "수중 보물을 숨기는 중 :";
			Lang.gen[34] = "함정을 설치하는중 :";
			Lang.gen[35] = "파괴 가능한 것들을 설치하는 중 :";
			Lang.gen[36] = "지옥대장간을 설치하는 중 :";
			Lang.gen[37] = "잔디를 확산시키는 중...";
			Lang.gen[38] = "선인장이 자라는 중...";
			Lang.gen[39] = "해바라기를 심는 중...";
			Lang.gen[40] = "나무를 심는 중...";
			Lang.gen[41] = "허브를 심는 중...";
			Lang.gen[42] = "잡초를 심는 중...";
			Lang.gen[43] = "덩굴이 자라는 중...";
			Lang.gen[44] = "꽃을 심는 중...";
			Lang.gen[45] = "버섯을 심는 중...";
			Lang.gen[46] = "사용되지 않은 자원을 해제하는 중...";
			Lang.gen[47] = "게임 구조물을 재설정 하는중 :";
			Lang.gen[48] = "하드모드 설정중...";
			Lang.gen[49] = "월드 데이터를 저장하는중 :";
			Lang.gen[50] = "월드 파일을 백업하는중...";
			Lang.gen[51] = "월드 데이터를 불러오는중 :";
			Lang.gen[52] = "타일 정렬을 확인하는 중 :";
			Lang.gen[53] = "불러오기 실패!";
			Lang.gen[54] = "백업을 찾을수 없습니다.";
			Lang.gen[55] = "타일 프레임을 찾는 중 :";
			Lang.gen[56] = "눈을 뿌리는중...";
			Lang.gen[57] = "World";
			Lang.gen[58] = "던전을 만드는중 :";
			Lang.gen[59] = "운석이 떨어졌습니다!";
			Lang.gen[60] = "세계를 다듬는 중 :";
			Lang.gen[61] = "이끼로 덮는 중 :";
			Lang.gen[62] = "보석으로 덮는 중 :";
			Lang.gen[63] = "동굴 벽을 만드는 중 :";
			Lang.gen[64] = "거미들이 번식하는 중 :";
			Lang.gen[65] = "멥 데이터를 정리하는중 :";
			Lang.gen[66] = "맵 데이터를 저장하는중 :";
			Lang.gen[67] = "멥 데이터를 불러오는중 :";
			Lang.gen[68] = "맵 그리는중 :";
			Lang.gen[69] = "폭포를 만드는 중 :";
			Lang.gen[70] = "밀림 폐허를 생성하는 중...";
			Lang.gen[71] = "말벌 둥지를 만드는 중...";
			Lang.gen[72] = "세상을 피투성이로 만드는 중 :";
			Lang.gen[73] = "월드를 저장 중입니다 :";

			Lang.gen[74] = "Slime is falling from the sky!";
			Lang.gen[75] = "Slime has stopped falling from the sky.";
			Lang.gen[76] = "Generating Structures.";
			Lang.gen[77] = "Adding more grass";
			Lang.gen[78] = "Desertification";
			Lang.gen[79] = "Spicing up walls";
			Lang.gen[80] = "Chiseling marble";
			Lang.gen[81] = "Growing granite";

			Lang.inter[0] = "생명:";
			Lang.inter[1] = "호흡량";
			Lang.inter[2] = "마나";
			Lang.inter[3] = "쓰레기통";
			Lang.inter[4] = "소지품";
			Lang.inter[5] = "단축막대 잠김 풀림";
			Lang.inter[6] = "단축막대 잠김";
			Lang.inter[7] = "하우징";
			Lang.inter[8] = "하우징 가능여부";
			Lang.inter[9] = "악세사리";
			Lang.inter[10] = "방어";
			Lang.inter[11] = "의장";
			Lang.inter[12] = "투구";
			Lang.inter[13] = "상의";
			Lang.inter[14] = "하의";
			Lang.inter[15] = "백금";
			Lang.inter[16] = "금";
			Lang.inter[17] = "은";
			Lang.inter[18] = "동";
			Lang.inter[19] = "재가공";
			Lang.inter[20] = "재가공하실 물건을 이곳에 두세요";
			Lang.inter[21] = "가능한 제조법";
			Lang.inter[22] = "필요한 물품:";
			Lang.inter[23] = "없음";
			Lang.inter[24] = "재료를 이곳에 두세요";
			Lang.inter[25] = "제작";
			Lang.inter[26] = "주화";
			Lang.inter[27] = "탄약";
			Lang.inter[28] = "상점";
			Lang.inter[29] = "모두 가져오기";
			Lang.inter[30] = "모두 넣어두기";
			Lang.inter[31] = "빠른 정렬";
			Lang.inter[32] = "돼지 저금통";
			Lang.inter[33] = "금고";
			Lang.inter[34] = "시간";
			Lang.inter[35] = "저장 & 종료";
			Lang.inter[36] = "연결해제";
			Lang.inter[37] = "아이템";
			Lang.inter[38] = "당신은 죽임을 당했습니다...";
			Lang.inter[39] = "이 하우징은 적합합니다.";
			Lang.inter[40] = "유효하지 않은 하우징입니다.";
			Lang.inter[41] = "이 하우징은 이미 사용중입니다.";
			Lang.inter[42] = "이 하우징은 손상되었습니다.";
			Lang.inter[43] = "연결 시간이 초과되었습니다";
			Lang.inter[44] = "타일 데이터를 받고 있습니다";
			Lang.inter[45] = "장비";
			Lang.inter[46] = "소모";
			Lang.inter[47] = "저장";
			Lang.inter[48] = "수정";
			Lang.inter[49] = "상태";
			Lang.inter[50] = "저주";
			Lang.inter[51] = "도움";
			Lang.inter[52] = "닫기";
			Lang.inter[53] = "물";
			Lang.inter[54] = "치료받기";
			Lang.inter[55] = "이 하우징은 다음과 같은 요구 사항이 충족되지 못합니다 : ";
			Lang.inter[56] = "용암";
			Lang.inter[57] = "염료";
			Lang.inter[58] = "꿀";
			Lang.inter[59] = "악세사리 보이기";
			Lang.inter[60] = "악세사리 감추기";
			Lang.inter[61] = "이름 바꾸기";
			Lang.inter[62] = "설정";
			Lang.inter[63] = "취소";
			Lang.inter[64] = "퀘스트";
			Lang.inter[65] = "퀘스트 아이템";

			Lang.inter[66] = "Savings";
			Lang.inter[67] = "Take Snapshot";
			Lang.inter[68] = "Settings";
			Lang.inter[69] = "Pin Frame";
			Lang.inter[70] = "Set Frame";
			Lang.inter[71] = "Close";
			Lang.inter[72] = "On";
			Lang.inter[73] = "Off";
			Lang.inter[74] = "Image Packing";
			Lang.inter[75] = "Capture Entities";
			Lang.inter[76] = "Capture Background";
			Lang.inter[77] = "Biome Pick";
			Lang.inter[78] = "Reset Frame";
			Lang.inter[79] = "Equipment";
			Lang.inter[80] = "Housing";
			Lang.inter[81] = "Camera Mode";
			Lang.inter[82] = "Restock";
			Lang.inter[83] = "Frost Moon";
			Lang.inter[84] = "Pumpkin Moon";
			Lang.inter[85] = "Martian Madness";
			Lang.inter[86] = "Pirate Invasion";
			Lang.inter[87] = "Frost Legion";
			Lang.inter[88] = "Goblin Army";
			Lang.inter[89] = "Collect";
			Lang.inter[90] = "Grappling Hook";
			Lang.inter[91] = "Mount";
			Lang.inter[92] = "Pet";
			Lang.inter[93] = "Minecart";
			Lang.inter[94] = "Light Pet";
			Lang.inter[95] = "Time";
			Lang.inter[96] = "Weather";
			Lang.inter[97] = "Fishing";
			Lang.inter[98] = "Position";
			Lang.inter[99] = "Depth";
			Lang.inter[100] = "Creature Count";
			Lang.inter[101] = "Kill Count";
			Lang.inter[102] = "Moon Phase";
			Lang.inter[103] = "Movement Speed";
			Lang.inter[104] = "Treasure";
			Lang.inter[105] = "Rare Creatures";
			Lang.inter[106] = "Damage Per Second";
			Lang.inter[107] = "Strange Plants";
			Lang.inter[108] = "Open Map";
			Lang.inter[109] = "Close Map";
			Lang.inter[110] = "Open Folder";
			Lang.inter[111] = "Take Screenshot";
			Lang.inter[112] = "You must first set a frame";
			Lang.inter[113] = "Only available in windowed mode";
			Lang.inter[114] = "Only available if map is enabled";
			Lang.inter[115] = "Camera Mode Disabled";
			Lang.inter[116] = "Highlight New Items Off";
			Lang.inter[117] = "Highlight New Items On";

			Lang.tip[0] = "의장 슬롯에 장착";
			Lang.tip[1] = "아이템 능력이 적용되지 않음";
			Lang.tip[2] = " 근접 피해";
			Lang.tip[3] = " 원거리 피해";
			Lang.tip[4] = " 마법 피해";
			Lang.tip[5] = "% 치명타 확률";
			Lang.tip[6] = "미친듯이 빠른 속도";
			Lang.tip[7] = "매우 빠른 속도";
			Lang.tip[8] = "빠른 속도";
			Lang.tip[9] = "보통 속도";
			Lang.tip[10] = "느린 속도";
			Lang.tip[11] = "매우 느린 속도";
			Lang.tip[12] = "엄청 느린 속도";
			Lang.tip[13] = "달팽이같은 속도";
			Lang.tip[14] = "밀치기 없음";
			Lang.tip[15] = "엄청 약한 밀치기";
			Lang.tip[16] = "매우 약한 밀치기";
			Lang.tip[17] = "약한 밀치기";
			Lang.tip[18] = "보통 밀치기";
			Lang.tip[19] = "강한 밀치기";
			Lang.tip[20] = "매우 강한 밀치기";
			Lang.tip[21] = "엄청 강한 밀치기";
			Lang.tip[22] = "미친듯한 밀치기";
			Lang.tip[23] = "착용가능";
			Lang.tip[24] = "치장품";
			Lang.tip[25] = " 방어";
			Lang.tip[26] = "% 곡괭이의 힘";
			Lang.tip[27] = "% 도끼의 힘";
			Lang.tip[28] = "% 망치의 힘";
			Lang.tip[29] = "회복";
			Lang.tip[30] = "생명";
			Lang.tip[31] = "마나";
			Lang.tip[32] = "사용";
			Lang.tip[33] = "배치할 수 있음";
			Lang.tip[34] = "탄약";
			Lang.tip[35] = "소모품";
			Lang.tip[36] = "재료";
			Lang.tip[37] = " 분 동안 지속";
			Lang.tip[38] = " 초 동안 지속";
			Lang.tip[39] = "% 피해";
			Lang.tip[40] = "% 속도";
			Lang.tip[41] = "% 치명타 확률";
			Lang.tip[42] = "% 마나 소모";
			Lang.tip[43] = "% 크기";
			Lang.tip[44] = "% 신속";
			Lang.tip[45] = "% 밀치기";
			Lang.tip[46] = "% 이동 속도";
			Lang.tip[47] = "% 근접 속도";
			Lang.tip[48] = "세트 효과:";
			Lang.tip[49] = "파는 가격:";
			Lang.tip[50] = "사는 가격:";
			Lang.tip[51] = "가치 없음";
			Lang.tip[52] = "소모함 ";
			Lang.tip[53] = " 소환 대미지";
			Lang.tip[54] = " 사정거리";
			Lang.tip[55] = " 대미지";
			Lang.tip[56] = "Marked as favorite";
			Lang.tip[57] = "Quick trash, stacking, and selling will be blocked";
			Lang.tip[58] = " throwing damage";
			Lang.tip[59] = "It has been cursed by a powerful Jungle creature";

			Lang.mp[0] = "수신 : ";
			Lang.mp[1] = "비밀번호가 다릅니다.";
			Lang.mp[2] = "이 상태에서 작업이 잘못되었습니다.";
			Lang.mp[3] = "당신의 캐릭터는 서버에서 추방당했습니다.";
			Lang.mp[4] = "당신은 현재 서버와 동일한 버전을 사용하고 있지 않습니다.";
			Lang.mp[5] = krEnd.End(Main.player[Main.myPlayer].name, 2) + " 이미 서버에 있습니다.";
			Lang.mp[6] = "/playing";
			Lang.mp[7] = "현재 플레이어 : ";
			Lang.mp[8] = "/roll";
			Lang.mp[9] = "주사위를 굴렸습니다. 나온 숫자는 - ";
			Lang.mp[10] = "당신은 파티에 속하지 않습니다!";
			Lang.mp[11] = krEnd.End(Main.player[Main.myPlayer].name, 2) + " 대전을 활성화시켰습니다!";
			Lang.mp[12] = krEnd.End(Main.player[Main.myPlayer].name, 2) + " 대전을 비활성화시켰습니다!";
			Lang.mp[13] = krEnd.End(Main.player[Main.myPlayer].name, 2) + " 파티에서 탈퇴하였습니다.";
			Lang.mp[14] = krEnd.End(Main.player[Main.myPlayer].name, 2) + " [적] 파티에 참여했습니다.";
			Lang.mp[15] = krEnd.End(Main.player[Main.myPlayer].name, 2) + " [녹] 파티에 참여했습니다.";
			Lang.mp[16] = krEnd.End(Main.player[Main.myPlayer].name, 2) + " [청] 파티에 참여했습니다.";
			Lang.mp[17] = krEnd.End(Main.player[Main.myPlayer].name, 2) + " [황] 파티에 참여했습니다.";
			Lang.mp[18] = "환영합니다! ";
			Lang.mp[19] = krEnd.End(Main.player[Main.myPlayer].name, 2) + " 참여했습니다.";
			Lang.mp[20] = krEnd.End(Main.player[Main.myPlayer].name, 2) + " 나갔습니다.";
			Lang.mp[21] = "/players";
			Lang.mp[22] = "has joined the pink party.";
			Lang.the = "the ";
			Lang.dt[0] = krEnd.End(Main.player[Main.myPlayer].name, 0) + " 해독제를 찾지 못했습니다";
			Lang.dt[1] = krEnd.End(Main.player[Main.myPlayer].name, 0) + " 몸에 붙은 불을 끌 수 없었습니다";
			Lang.dt[2] = krEnd.End(Main.player[Main.myPlayer].name, 0) + " 숨을 쉴 수 없습니다";
			Lang.dt[3] = "couldn't contain the watts.";
			Main.buffName[1] = "흑요석 피부";
			Main.buffTip[1] = "용암에 면역";
			Main.buffName[2] = "재생";
			Main.buffTip[2] = "체력 재생 속도 증가";
			Main.buffName[3] = "신속";
			Main.buffTip[3] = "25% 이동 속도 증가";
			Main.buffName[4] = "아가미";
			Main.buffTip[4] = "공기 대신 물로 호흡함";
			Main.buffName[5] = "철피부";
			Main.buffTip[5] = "8 방어 증가";
			Main.buffName[6] = "마나 재생";
			Main.buffTip[6] = "마나 재생률 증가";
			Main.buffName[7] = "마력 강화";
			Main.buffTip[7] = "20% 마법 피해 증가";
			Main.buffName[8] = "가벼움";
			Main.buffTip[8] = "UP 이나 DOWN 키를 눌러 낙하 속도 제어 가능";
			Main.buffName[9] = "동굴탐험가";
			Main.buffTip[9] = "보물이나 광물의 위치를 보여준다";
			Main.buffName[10] = "투명화";
			Main.buffTip[10] = "투명화를 승낙한다!";
			Main.buffName[11] = "발광";
			Main.buffTip[11] = "빛을 발함";
			Main.buffName[12] = "올빼미";
			Main.buffTip[12] = "야간 시야 증가";
			Main.buffName[13] = "전투";
			Main.buffTip[13] = "적 출현 확률 증가";
			Main.buffName[14] = "가시";
			Main.buffTip[14] = "적이 공격하면 적도 피해를 입음";
			Main.buffName[15] = "수상 보행";
			Main.buffTip[15] = "DOWN 키를 눌러 물 아래로 진입";
			Main.buffName[16] = "궁술";
			Main.buffTip[16] = "20% 화살 피해 및 화살 속도 증가";
			Main.buffName[17] = "사냥꾼";
			Main.buffTip[17] = "적의 위치를 보여줌";
			Main.buffName[18] = "중력";
			Main.buffTip[18] = "UP 키를 눌러 중력 반전";
			Main.buffName[19] = "그림자 보주";
			Main.buffTip[19] = "빛을 제공하는 마법의 보주";
			Main.buffName[20] = "중독됨";
			Main.buffTip[20] = "천천히 생명력 감소";
			Main.buffName[21] = "물약 질병";
			Main.buffTip[21] = "어떤 치료 아이템도 소모할 수 없음";
			Main.buffName[22] = "암흑";
			Main.buffTip[22] = "시야 감소";
			Main.buffName[23] = "저주걸림";
			Main.buffTip[23] = "어떤 아이템도 사용 불가";
			Main.buffName[24] = "불타고 있어!";
			Main.buffTip[24] = "천천히 생명력 감소";
			Main.buffName[25] = "기운";
			Main.buffTip[25] = "근접 능력 증가, 방어 감소";
			Main.buffName[26] = "포만감";
			Main.buffTip[26] = "모든 능력이 조금 증가";
			Main.buffName[27] = "페어리";
			Main.buffTip[27] = "페어리가 당신을 따라옵니다";
			Main.buffName[28] = "늑대인간";
			Main.buffTip[28] = "물리적 능력이 상승함";
			Main.buffName[29] = "천리안";
			Main.buffTip[29] = "마법의 힘이 증가함";
			Main.buffName[30] = "출혈";
			Main.buffTip[30] = "생명 회복 불가";
			Main.buffName[31] = "혼란스러움";
			Main.buffTip[31] = "반대로 이동";
			Main.buffName[32] = "느림";
			Main.buffTip[32] = "이동 속도 감소";
			Main.buffName[33] = "약화";
			Main.buffTip[33] = "물리적 능력이 감소됨";
			Main.buffName[34] = "어인";
			Main.buffTip[34] = "물속에서 호흡 및 이동을 쉽게 할 수 있다";
			Main.buffName[35] = "침묵함";
			Main.buffTip[35] = "마나를 요구하는 아이템 사용 불가";
			Main.buffName[36] = "부서진 갑옷";
			Main.buffTip[36] = "방어가 절반으로 깎임";
			Main.buffName[37] = "겁먹음";
			Main.buffTip[37] = "당신은 험상궂은 무언가를 보았다, 더 이상 도망가지 못한다";
			Main.buffName[38] = "혀";
			Main.buffTip[38] = "당신은 입으로 빨려들고 있습니다";
			Main.buffName[39] = "저주받은 지옥";
			Main.buffTip[39] = "생명력을 잃음";
			Main.buffName[40] = "애완용 토끼";
			Main.buffTip[40] = "내가 생각하기에는 당신의 당근을 원하고 있다";
			Main.buffName[41] = "새끼 펭귄";
			Main.buffTip[41] = "내가 생각하기에는 당신의 생선을 원하고 있다";
			Main.buffName[42] = "애완용 거북이";
			Main.buffTip[42] = "행복한 거북이 시간!";
			Main.buffName[43] = "성기사의 방패";
			Main.buffTip[43] = "다른 플레이어가 받는 25% 피해를 받음";
			Main.buffName[44] = "한기의 불꽃";
			Main.buffTip[44] = "이것은 정말 뜨겁거나 정말 차갑습니다. 어느 쪽이던지 정말 아픔!";
			Main.buffName[45] = "아기 포식자";
			Main.buffTip[45] = "영혼을 먹는 자의 새끼가 당신을 따라옵니다";
			Main.buffName[46] = "추움";
			Main.buffTip[46] = "당신의 이동 속도가 감소합니다";
			Main.buffName[47] = "얼어붙음";
			Main.buffTip[47] = "움직일 수 없어!";
			Main.buffName[48] = "꿀";
			Main.buffTip[48] = "생명 재생속도가 증가";
			Main.buffName[49] = "난쟁이";
			Main.buffTip[49] = "난쟁이가 당신을 위해 싸웁니다";
			Main.buffName[50] = "아기 해골의 머리";
			Main.buffTip[50] = "더이상 묻지마...";
			Main.buffName[51] = "새끼 말벌";
			Main.buffTip[51] = "새끼 말벌이 당신을 어미라 생각합니다";
			Main.buffName[52] = "티키의 영혼";
			Main.buffTip[52] = "호의적인 영혼이 당신을 따라옵니다";
			Main.buffName[53] = "애완용 도마뱀";
			Main.buffTip[53] = "파충류처럼 얌전함";
			Main.buffName[54] = "애완용 앵무새";
			Main.buffTip[54] = "폴리는 크래커를 원합니다.";
			Main.buffName[55] = "아기 송로버섯";
			Main.buffTip[55] = "엄청 귀엽지 않나요? ";
			Main.buffName[56] = "애완용 묘목";
			Main.buffTip[56] = "이 작은 묘목이 당신을 따라옵니다";
			Main.buffName[57] = "도깨비불";
			Main.buffTip[57] = "도깨비불이 당신을 따라옵니다";
			Main.buffName[58] = "빠른 회복";
			Main.buffTip[58] = "생명력 회복속도가 엄청나게 상승합니다";
			Main.buffName[59] = "그림자 피하기";
			Main.buffTip[59] = "다음 공격을 피할 수 있습니다";
			Main.buffName[60] = "나뭇잎 수정";
			Main.buffTip[60] = "주변 적에게 수정 잎을 발사함";
			Main.buffName[61] = "아기 공룡";
			Main.buffTip[61] = "아기 공룡이 당신을 따라옵니다";
			Main.buffName[62] = "얼음 보호막";
			Main.buffTip[62] = "방어 30 증가";
			Main.buffName[63] = "혼란!";
			Main.buffTip[63] = "이동 속도가 증가함";
			Main.buffName[64] = "새끼 슬라임";
			Main.buffTip[64] = "새끼 슬라임이 당신을 위해 싸웁니다";
			Main.buffName[65] = "눈알 용수철";
			Main.buffTip[65] = "눈알 용수철이 당신을 따라옵니다";
			Main.buffName[66] = "아기 눈사람";
			Main.buffTip[66] = "아기 눈사람이 당신을 따라옵니다";
			Main.buffName[67] = "불탐";
			Main.buffTip[67] = "생명력을 잃고 이동 속도도 느려짐";
			Main.buffName[68] = "질식";
			Main.buffTip[68] = "생명력을 잃음";
			Main.buffName[69] = "이코르";
			Main.buffTip[69] = "방어가 감소됨";
			Main.buffName[70] = "맹독";
			Main.buffTip[70] = "생명력을 잃음";
			Main.buffName[71] = "무기 주입: 맹독";
			Main.buffTip[71] = "근접 공격시 대상에서 맹독을 가함";
			Main.buffName[72] = "마이더스";
			Main.buffTip[72] = "죽을 때 더 많은 돈을 떨굽니다";
			Main.buffName[73] = "무기 주입: 저주받은 불꽃";
			Main.buffTip[73] = "근접 공격시 대상에게 저주받은 불꽃을 가함";
			Main.buffName[74] = "무기 주입: 불";
			Main.buffTip[74] = "근접 공격시 대상에게 불을 붙임";
			Main.buffName[75] = "무기 주입: 금";
			Main.buffTip[75] = "근접 공격시 적이 더 많은 금을 떨구게 만듬";
			Main.buffName[76] = "무기 주입: 이코르";
			Main.buffTip[76] = "근접 공격시 적의 방어를 낮춤";
			Main.buffName[77] = "무기 주입: 나노머신";
			Main.buffTip[77] = "근접 공격시 적을 혼란";
			Main.buffName[78] = "무기 주입: 색종이";
			Main.buffTip[78] = "근접 공격시 색종이가 날림";
			Main.buffName[79] = "무기 주입: 독";
			Main.buffTip[79] = "근접 공격시 적을 중독";
			Main.buffName[80] = "의식 상실";
			Main.buffTip[80] = "시야가 심하게 감소됨";
			Main.buffName[81] = "애완용 거미";
			Main.buffTip[81] = "거미가 당신을 따라옵니다";
			Main.buffName[82] = "스쿼실링";
			Main.buffTip[82] = "스쿼실링이 당신을 따라옵니다";
			Main.buffName[83] = "까마귀";
			Main.buffTip[83] = "까마귀가 당신을 위해 싸웁니다";
			Main.buffName[84] = "검은 고양이";
			Main.buffTip[84] = "검은 아기고양이가 당신을 따라옵니다";
			Main.buffName[85] = "저주받은 묘목";
			Main.buffTip[85] = "저주받은 묘목이 당신을 따라옵니다";
			Main.buffName[86] = "물 양초";
			Main.buffTip[86] = "몬스터 출현 확률이 증가함";
			Main.buffName[87] = "모닥불";
			Main.buffTip[87] = "생명력 재생이 약간 증가함";
			Main.buffName[88] = "혼돈 상태";
			Main.buffTip[88] = "불화의 지팡이를 사용시 생명력을 소모함";
			Main.buffName[89] = "하트 전등";
			Main.buffTip[89] = "생명력 재생속도가 증가함";
			Main.buffName[90] = "루돌프";
			Main.buffTip[90] = "빨간코의 순록을 탐";
			Main.buffName[91] = "강아지";
			Main.buffTip[91] = "강아지가 당신을 따라옵니다";
			Main.buffName[92] = "아기 그린치";
			Main.buffTip[92] = "아기 그린치가 당신을 따라옵니다";
			Main.buffName[93] = "탄약 상자";
			Main.buffTip[93] = "20% 확률로 탄약을 소모하지 않음";
			Main.buffName[94] = "마나 질병";
			Main.buffTip[94] = "마법 피해 감소 ";
			Main.buffName[95] = "딱정벌레의 인내";
			Main.buffTip[95] = "피해를 15% 감소됨";
			Main.buffName[96] = "딱정벌레의 인내";
			Main.buffTip[96] = "피해를 30% 감소됨";
			Main.buffName[97] = "딱정벌레의 인내";
			Main.buffTip[97] = "피해를 45% 감소됨";
			Main.buffName[98] = "딱정벌레의 힘";
			Main.buffTip[98] = "근접 피해 및 속도를 10% 증가";
			Main.buffName[99] = "딱정벌레의 힘";
			Main.buffTip[99] = "근접 피해 및 속도를 20% 증가";
			Main.buffName[100] = "딱정벌레의 힘";
			Main.buffTip[100] = "근접 피해 및 속도를 30% 증가";
			Main.buffName[101] = "페어리";
			Main.buffTip[101] = "페어리가 당신을 따라옵니다";
			Main.buffName[102] = "페어리";
			Main.buffTip[102] = "페어리가 당신을 따라옵니다";
			Main.buffName[103] = "젖음";
			Main.buffTip[103] = "물이 뚝뚝 떨어집니다";
			Main.buffName[104] = "채굴";
			Main.buffTip[104] = "25% 채굴 속도 증가";
			Main.buffName[105] = "생명 습득";
			Main.buffTip[105] = "하트를 습득할 수 있는 범위 증가";
			Main.buffName[106] = "평온함";
			Main.buffTip[106] = "적의 적대성 감소";
			Main.buffName[107] = "건축가";
			Main.buffTip[107] = "설치 속도 및 범위 증가";
			Main.buffName[108] = "거인";
			Main.buffTip[108] = "밀치기 증가";
			Main.buffName[109] = "물갈퀴";
			Main.buffTip[109] = "물에서 평상시 처럼 이동";
			Main.buffName[110] = "소환술";
			Main.buffTip[110] = "소환수의 최대 수 증가";
			Main.buffName[111] = "위협 감지";
			Main.buffTip[111] = "근처 위험지역을 볼 수 있음";
			Main.buffName[112] = "탄약 반환";
			Main.buffTip[112] = "20% 확률로 탄약을 소모하지 않음";
			Main.buffName[113] = "생명력";
			Main.buffTip[113] = "20% 최대 생명 증가";
			Main.buffName[114] = "인내";
			Main.buffTip[114] = "10% 피해 감소";
			Main.buffName[115] = "격노";
			Main.buffTip[115] = "10% 치명타 확률 증가";
			Main.buffName[116] = "지옥불";
			Main.buffTip[116] = "근처 적에게 불이 붙음";
			Main.buffName[117] = "분노";
			Main.buffTip[117] = "10% 피해 증가";
			Main.buffName[118] = "광산수레";
			Main.buffTip[118] = "광산수레를 탐";
			Main.buffName[119] = "사랑에 빠짐";
			Main.buffTip[119] = "사랑에 빠졌군요!";
			Main.buffName[120] = "악취";
			Main.buffTip[120] = "끔찍한 냄새가 납니다";
			Main.buffName[121] = "낚시";
			Main.buffTip[121] = "낚시 레벨 증가";
			Main.buffName[122] = "수중탐지";
			Main.buffTip[122] = "낚시 바늘에 무엇이 물고 있는지 볼 수 있습니다";
			Main.buffName[123] = "아이템 낚시 확률 증가";
			Main.buffTip[123] = "상자를 낚아올릴 큰 기회";
			Main.buffName[124] = "온기";
			Main.buffTip[124] = "차가운 것으로부터 피해 감소";
			Main.buffName[125] = "말벌";
			Main.buffTip[125] = "말벌이 당신을 위해 싸웁니다";
			Main.buffName[126] = "임프";
			Main.buffTip[126] = "임프가 당신을 위해 싸웁니다";
			Main.buffName[127] = "산들바람 물고기";
			Main.buffTip[127] = "당신 주변에서 수영하는 것을 좋아합니다";
			Main.buffName[128] = "토끼 탈 것";
			Main.buffTip[128] = "당신은 당근을 갈망한다";
			Main.buffName[129] = "돼지용 탈 것";
			Main.buffTip[129] = "살찌지 않았다 꿀";
			Main.buffName[130] = "슬라임 탈 것";
			Main.buffTip[130] = "뿌잉!";
			Main.buffName[131] = "거북이 탈 것";
			Main.buffTip[131] = "육지에서 느리다면, 바다에서 한 번 확인해보세요";
			Main.buffName[132] = "꿀벌 탈 것";
			Main.buffTip[132] = "부우웅부우웅부우우우웅부우웅";
			Main.buffName[133] = "거미";
			Main.buffTip[133] = "거미가 당신을 위해 싸웁니다";
			Main.buffName[134] = "쌍둥이";
			Main.buffTip[134] = "쌍둥이가 당신을 위해 싸웁니다";
			Main.buffName[135] = "해적";
			Main.buffTip[135] = "해적이 당신을 위해 싸웁니다";
			Main.buffName[136] = "작은 미노타우르스";
			Main.buffTip[136] = "어떻게 작은 미노타우르스를 물리친거야?";
			Main.buffName[137] = "슬라임";
			Main.buffTip[137] = "당신은 끈적끈적합니다.";
			Main.buffName[138] = "광산수레";
			Main.buffTip[138] = "광산수레를 탐";
			Main.buffName[139] = "샤크네이도";
			Main.buffTip[139] = "샤크네이도가 당신을 위해 싸웁니다";
			Main.buffName[140] = "UFO";
			Main.buffTip[140] = "UFO가 당신을 위해 싸웁니다";
			Main.buffName[141] = "UFO 탑승";
			Main.buffTip[141] = "It's a good thing you had a MAC";
			Main.buffName[142] = "Drill Mount";
			Main.buffTip[142] = "Riding in a flying drill";
			Main.buffName[143] = "Scutlix Mount";
			Main.buffTip[143] = "Pew Pew";
			Main.buffName[144] = "Electrified";
			Main.buffTip[144] = "You cannot move";
			Main.buffName[145] = "Moon Bite";
			Main.buffTip[145] = "You are unable to absorb healing effects";
			Main.buffName[146] = "Happy!";
			Main.buffTip[146] = "Movement speed increased and monster spawns reduced";
			Main.buffName[147] = "Banner";
			Main.buffTip[147] = "Increased damage and defense from the following:";
			Main.buffName[148] = "Feral Bite";
			Main.buffTip[148] = "Increased damage, Decreased life regen, Causes status effects";
			Main.buffName[149] = "Webbed";
			Main.buffTip[149] = "You are stuck";
			Main.buffName[150] = "Bewitched";
			Main.buffTip[150] = "Increased max number of minions";
			Main.buffName[151] = "Life Drain";
			Main.buffTip[151] = "Increased life regeneration";
			Main.buffName[152] = "Magic Lantern";
			Main.buffTip[152] = "An enchanted lantern is lighting your way";
			Main.buffName[153] = "Shadowflame";
			Main.buffTip[153] = "Losing life";
			Main.buffName[155] = "Crimson Heart";
			Main.buffTip[155] = "A magical heart that provides light";
			Main.buffName[154] = "Baby Face Monster";
			Main.buffTip[154] = "A baby face monster is following you";
			Main.buffName[169] = "Penetrated";
			Main.buffTip[169] = "Bleeding Out";
			Main.buffName[182] = "Stardust Cell";
			Main.buffTip[182] = "The stardust cell will fight for you";
			Main.buffName[183] = "Celled";
			Main.buffTip[183] = "being eaten by cells";
			Main.buffName[186] = "Dryad's Bane";
			Main.buffTip[186] = "The power of nature compells you";
			Main.buffName[187] = "Stardust Guardian";
			Main.buffTip[187] = "The stardust guardian will protect you";
			Main.buffName[188] = "Stardust Dragon";
			Main.buffTip[188] = "The stardust dragon will protect you";
			Main.buffName[189] = "Daybroken";
			Main.buffTip[189] = "Incenerated by solar rays";
			Main.buffName[190] = "Suspicious Looking Eye";
			Main.buffTip[190] = "A suspicious looking eye that provides light";
			Main.buffName[156] = "Stoned";
			Main.buffTip[156] = "You are completely petrified!";
			Main.buffName[158] = "Star in a Bottle";
			Main.buffTip[158] = "Increased mana regeneration";
			Main.buffName[159] = "Sharpened";
			Main.buffTip[159] = "Melee weapons have armor penetration";
			Main.buffName[160] = "Dazed";
			Main.buffTip[160] = "Movement is greatly slowed";
			Main.buffName[161] = "Deadly Sphere";
			Main.buffTip[161] = "The Deadly Sphere will fight for you";
			Main.buffName[163] = "Obstructed";
			Main.buffTip[163] = "You can't see!";
			Main.buffName[164] = "Distorted";
			Main.buffTip[164] = "Gravity around you is distorted";
			Main.buffName[165] = "Dryad's Blessing";
			Main.buffTip[165] = "The power of nature protects you";
			Main.buffName[166] = "Minecart";
			Main.buffTip[166] = "Riding in a minecart";
			Main.buffName[167] = "Minecart";
			Main.buffTip[167] = "Riding in a minecart";
			Main.buffName[185] = "Minecart";
			Main.buffTip[185] = "Riding in a minecart";
			Main.buffName[184] = "Minecart";
			Main.buffTip[184] = "Riding in a minecart";
			Main.buffName[170] = "Solar Blaze";
			Main.buffTip[170] = "Damage taken reduced by 30%, repel enemies when taking damage";
			Main.buffName[171] = "Solar Blaze";
			Main.buffTip[171] = "Damage taken reduced by 30%, repel enemies when taking damage";
			Main.buffName[172] = "Solar Blaze";
			Main.buffTip[172] = "Damage taken reduced by 30%, repel enemies when taking damage";
			Main.buffName[179] = "Damage Nebula";
			Main.buffTip[179] = "15% increased damage";
			Main.buffName[180] = "Damage Nebula";
			Main.buffTip[180] = "30% increased damage";
			Main.buffName[181] = "Damage Nebula";
			Main.buffTip[181] = "45% increased damage";
			Main.buffName[173] = "Life Nebula";
			Main.buffTip[173] = "Increased life regeneration";
			Main.buffName[174] = "Life Nebula";
			Main.buffTip[174] = "Increased life regeneration";
			Main.buffName[175] = "Life Nebula";
			Main.buffTip[175] = "Increased life regeneration";
			Main.buffName[176] = "Mana Nebula";
			Main.buffTip[176] = "Increased mana regeneration";
			Main.buffName[177] = "Mana Nebula";
			Main.buffTip[177] = "Increased mana regeneration";
			Main.buffName[178] = "Mana Nebula";
			Main.buffTip[178] = "Increased mana regeneration";
			Main.buffName[162] = "Unicorn Mount";
			Main.buffTip[162] = "Charge ahead... fabulously!";
			Main.buffName[168] = "Cute Fishron Mount";
			Main.buffTip[168] = "Just don't make it crawl.";
			Main.buffName[71] = "Weapon Imbue: Venom";
			Main.buffTip[71] = "Melee attacks inflict venom on your targets";
			Main.buffName[73] = "Weapon Imbue: Cursed Flames";
			Main.buffTip[73] = "Melee attacks inflict enemies with cursed flames";
			Main.buffName[74] = "Weapon Imbue: Fire";
			Main.buffTip[74] = "Melee attacks set enemies on fire";
			Main.buffName[75] = "Weapon Imbue: Gold";
			Main.buffTip[75] = "Melee attacks make enemies drop more gold";
			Main.buffName[76] = "Weapon Imbue: Ichor";
			Main.buffTip[76] = "Melee attacks decrease enemies defense";
			Main.buffName[77] = "Weapon Imbue: Nanites";
			Main.buffTip[77] = "Melee attacks confuse enemies";
			Main.buffName[78] = "Weapon Imbue: Confetti";
			Main.buffTip[78] = "Melee attacks cause confetti to appear";
			Main.buffName[79] = "Weapon Imbue: Poison";
			Main.buffTip[79] = "Melee attacks poison enemies";
			if (Lang.mapLegend == null)
			{
				Lang.mapLegend = new string[MapHelper.LookupCount()];
			}
			Lang.mapLegend[MapHelper.TileToLookup(4, 0)] = "Torch";
			Lang.mapLegend[MapHelper.TileToLookup(4, 1)] = "Torch";
			Lang.mapLegend[MapHelper.TileToLookup(5, 0)] = "Tree";
			Lang.mapLegend[MapHelper.TileToLookup(6, 0)] = "Iron";
			Lang.mapLegend[MapHelper.TileToLookup(7, 0)] = "Copper";
			Lang.mapLegend[MapHelper.TileToLookup(8, 0)] = "Gold";
			Lang.mapLegend[MapHelper.TileToLookup(9, 0)] = "Silver";
			Lang.mapLegend[MapHelper.TileToLookup(10, 0)] = "Door";
			Lang.mapLegend[MapHelper.TileToLookup(11, 0)] = "Door";
			Lang.mapLegend[MapHelper.TileToLookup(12, 0)] = "Life Crystal";
			Lang.mapLegend[MapHelper.TileToLookup(13, 0)] = "Bottle";
			Lang.mapLegend[MapHelper.TileToLookup(14, 0)] = "Table";
			Lang.mapLegend[MapHelper.TileToLookup(15, 0)] = "Chair";
			Lang.mapLegend[MapHelper.TileToLookup(16, 0)] = "Anvil";
			Lang.mapLegend[MapHelper.TileToLookup(17, 0)] = "Furnace";
			Lang.mapLegend[MapHelper.TileToLookup(18, 0)] = "Work Bench";
			Lang.mapLegend[MapHelper.TileToLookup(20, 0)] = "Sapling";
			Lang.mapLegend[MapHelper.TileToLookup(21, 0)] = "Chest";
			Lang.mapLegend[MapHelper.TileToLookup(22, 0)] = "Demonite";
			Lang.mapLegend[MapHelper.TileToLookup(26, 0)] = "Demon Altar";
			Lang.mapLegend[MapHelper.TileToLookup(26, 1)] = "Crimson Altar";
			Lang.mapLegend[MapHelper.TileToLookup(27, 0)] = Main.itemName[63];
			Lang.mapLegend[MapHelper.TileToLookup(407, 0)] = "Fossil";
			Lang.mapLegend[MapHelper.TileToLookup(412, 0)] = "Ancient Manipulator";
			for (int i = 0; i < 9; i++)
			{
				Lang.mapLegend[MapHelper.TileToLookup(28, i)] = "Pot";
			}
			Lang.mapLegend[MapHelper.TileToLookup(37, 0)] = "Meteorite";
			Lang.mapLegend[MapHelper.TileToLookup(29, 0)] = Main.itemName[87];
			Lang.mapLegend[MapHelper.TileToLookup(31, 0)] = "Shadow Orb";
			Lang.mapLegend[MapHelper.TileToLookup(31, 1)] = "Crimson Heart";
			Lang.mapLegend[MapHelper.TileToLookup(32, 0)] = "Thorns";
			Lang.mapLegend[MapHelper.TileToLookup(33, 0)] = "Candle";
			Lang.mapLegend[MapHelper.TileToLookup(34, 0)] = "Chandelier";
			Lang.mapLegend[MapHelper.TileToLookup(35, 0)] = "Jack 'O Lantern";
			Lang.mapLegend[MapHelper.TileToLookup(36, 0)] = "Present";
			Lang.mapLegend[MapHelper.TileToLookup(42, 0)] = "Lantern";
			Lang.mapLegend[MapHelper.TileToLookup(48, 0)] = "Spike";
			Lang.mapLegend[MapHelper.TileToLookup(49, 0)] = Main.itemName[148];
			Lang.mapLegend[MapHelper.TileToLookup(50, 0)] = "Book";
			Lang.mapLegend[MapHelper.TileToLookup(51, 0)] = "Web";
			Lang.mapLegend[MapHelper.TileToLookup(55, 0)] = "Sign";
			Lang.mapLegend[MapHelper.TileToLookup(63, 0)] = "Sapphire";
			Lang.mapLegend[MapHelper.TileToLookup(64, 0)] = "Ruby";
			Lang.mapLegend[MapHelper.TileToLookup(65, 0)] = "Emerald";
			Lang.mapLegend[MapHelper.TileToLookup(66, 0)] = "Topaz";
			Lang.mapLegend[MapHelper.TileToLookup(67, 0)] = "Amethyst";
			Lang.mapLegend[MapHelper.TileToLookup(68, 0)] = "Diamond";
			Lang.mapLegend[MapHelper.TileToLookup(69, 0)] = "Thorn";
			Lang.mapLegend[MapHelper.TileToLookup(72, 0)] = "Giant Mushroom";
			Lang.mapLegend[MapHelper.TileToLookup(77, 0)] = "Hellforge";
			Lang.mapLegend[MapHelper.TileToLookup(78, 0)] = "Clay Pot";
			Lang.mapLegend[MapHelper.TileToLookup(79, 0)] = "Bed";
			Lang.mapLegend[MapHelper.TileToLookup(80, 0)] = "Cactus";
			Lang.mapLegend[MapHelper.TileToLookup(81, 0)] = "Coral";
			Lang.mapLegend[MapHelper.TileToLookup(82, 0)] = Main.itemName[313];
			Lang.mapLegend[MapHelper.TileToLookup(82, 1)] = Main.itemName[314];
			Lang.mapLegend[MapHelper.TileToLookup(82, 2)] = Main.itemName[315];
			Lang.mapLegend[MapHelper.TileToLookup(82, 3)] = Main.itemName[316];
			Lang.mapLegend[MapHelper.TileToLookup(82, 4)] = Main.itemName[317];
			Lang.mapLegend[MapHelper.TileToLookup(82, 5)] = Main.itemName[318];
			Lang.mapLegend[MapHelper.TileToLookup(82, 6)] = Main.itemName[2358];
			Lang.mapLegend[MapHelper.TileToLookup(83, 0)] = Main.itemName[313];
			Lang.mapLegend[MapHelper.TileToLookup(83, 1)] = Main.itemName[314];
			Lang.mapLegend[MapHelper.TileToLookup(83, 2)] = Main.itemName[315];
			Lang.mapLegend[MapHelper.TileToLookup(83, 3)] = Main.itemName[316];
			Lang.mapLegend[MapHelper.TileToLookup(83, 4)] = Main.itemName[317];
			Lang.mapLegend[MapHelper.TileToLookup(83, 5)] = Main.itemName[318];
			Lang.mapLegend[MapHelper.TileToLookup(83, 6)] = Main.itemName[2358];
			Lang.mapLegend[MapHelper.TileToLookup(84, 0)] = Main.itemName[313];
			Lang.mapLegend[MapHelper.TileToLookup(84, 1)] = Main.itemName[314];
			Lang.mapLegend[MapHelper.TileToLookup(84, 2)] = Main.itemName[315];
			Lang.mapLegend[MapHelper.TileToLookup(84, 3)] = Main.itemName[316];
			Lang.mapLegend[MapHelper.TileToLookup(84, 4)] = Main.itemName[317];
			Lang.mapLegend[MapHelper.TileToLookup(84, 5)] = Main.itemName[318];
			Lang.mapLegend[MapHelper.TileToLookup(84, 6)] = Main.itemName[2358];
			Lang.mapLegend[MapHelper.TileToLookup(85, 0)] = "Tombstone";
			Lang.mapLegend[MapHelper.TileToLookup(86, 0)] = "Loom";
			Lang.mapLegend[MapHelper.TileToLookup(87, 0)] = "Piano";
			Lang.mapLegend[MapHelper.TileToLookup(88, 0)] = "Dresser";
			Lang.mapLegend[MapHelper.TileToLookup(89, 0)] = "Bench";
			Lang.mapLegend[MapHelper.TileToLookup(90, 0)] = "Bathtub";
			Lang.mapLegend[MapHelper.TileToLookup(91, 0)] = "Banner";
			Lang.mapLegend[MapHelper.TileToLookup(92, 0)] = "Lamp Post";
			Lang.mapLegend[MapHelper.TileToLookup(93, 0)] = "Floor Lamp";
			Lang.mapLegend[MapHelper.TileToLookup(94, 0)] = "Keg";
			Lang.mapLegend[MapHelper.TileToLookup(95, 0)] = "Chinese Lantern";
			Lang.mapLegend[MapHelper.TileToLookup(96, 0)] = "Cooking Pot";
			Lang.mapLegend[MapHelper.TileToLookup(97, 0)] = "Safe";
			Lang.mapLegend[MapHelper.TileToLookup(98, 0)] = "Skull Lantern";
			Lang.mapLegend[MapHelper.TileToLookup(100, 0)] = "Candelabra";
			Lang.mapLegend[MapHelper.TileToLookup(101, 0)] = "Bookcase";
			Lang.mapLegend[MapHelper.TileToLookup(102, 0)] = "Throne";
			Lang.mapLegend[MapHelper.TileToLookup(103, 0)] = "Bowl";
			Lang.mapLegend[MapHelper.TileToLookup(104, 0)] = "Grandfather Clock";
			Lang.mapLegend[MapHelper.TileToLookup(105, 0)] = "Statue";
			Lang.mapLegend[MapHelper.TileToLookup(105, 2)] = "Vase";
			Lang.mapLegend[MapHelper.TileToLookup(106, 0)] = "Sawmill";
			Lang.mapLegend[MapHelper.TileToLookup(107, 0)] = "Cobalt";
			Lang.mapLegend[MapHelper.TileToLookup(108, 0)] = "Mythril";
			Lang.mapLegend[MapHelper.TileToLookup(111, 0)] = "Adamantite";
			Lang.mapLegend[MapHelper.TileToLookup(114, 0)] = "Tinkerer's Workshop";
			Lang.mapLegend[MapHelper.TileToLookup(125, 0)] = "Crystal Ball";
			Lang.mapLegend[MapHelper.TileToLookup(128, 0)] = "Mannequin";
			Lang.mapLegend[MapHelper.TileToLookup(129, 0)] = "Crystal Shard";
			Lang.mapLegend[MapHelper.TileToLookup(132, 0)] = "Lever";
			Lang.mapLegend[MapHelper.TileToLookup(411, 0)] = "Detonator";
			Lang.mapLegend[MapHelper.TileToLookup(133, 0)] = "Adamantite Forge";
			Lang.mapLegend[MapHelper.TileToLookup(133, 1)] = "Titanium Forge";
			Lang.mapLegend[MapHelper.TileToLookup(134, 0)] = "Mythril Anvil";
			Lang.mapLegend[MapHelper.TileToLookup(134, 1)] = "Orichalcum Anvil";
			Lang.mapLegend[MapHelper.TileToLookup(136, 0)] = "Switch";
			Lang.mapLegend[MapHelper.TileToLookup(137, 0)] = "Trap";
			Lang.mapLegend[MapHelper.TileToLookup(138, 0)] = "Boulder";
			Lang.mapLegend[MapHelper.TileToLookup(139, 0)] = "Music Box";
			Lang.mapLegend[MapHelper.TileToLookup(142, 0)] = "Inlet Pump";
			Lang.mapLegend[MapHelper.TileToLookup(143, 0)] = "Outlet Pump";
			Lang.mapLegend[MapHelper.TileToLookup(144, 0)] = "Timer";
			Lang.mapLegend[MapHelper.TileToLookup(149, 0)] = "Christmas Light";
			Lang.mapLegend[MapHelper.TileToLookup(166, 0)] = "Tin";
			Lang.mapLegend[MapHelper.TileToLookup(167, 0)] = "Lead";
			Lang.mapLegend[MapHelper.TileToLookup(168, 0)] = "Tungsten";
			Lang.mapLegend[MapHelper.TileToLookup(169, 0)] = "Platinum";
			Lang.mapLegend[MapHelper.TileToLookup(170, 0)] = "Pine Tree";
			Lang.mapLegend[MapHelper.TileToLookup(171, 0)] = "Christmas Tree";
			Lang.mapLegend[MapHelper.TileToLookup(172, 0)] = "Sink";
			Lang.mapLegend[MapHelper.TileToLookup(173, 0)] = "Candelabra";
			Lang.mapLegend[MapHelper.TileToLookup(174, 0)] = "Platinum Candle";
			Lang.mapLegend[MapHelper.TileToLookup(178, 0)] = Main.itemName[181];
			Lang.mapLegend[MapHelper.TileToLookup(178, 1)] = Main.itemName[180];
			Lang.mapLegend[MapHelper.TileToLookup(178, 2)] = Main.itemName[177];
			Lang.mapLegend[MapHelper.TileToLookup(178, 3)] = Main.itemName[179];
			Lang.mapLegend[MapHelper.TileToLookup(178, 4)] = Main.itemName[178];
			Lang.mapLegend[MapHelper.TileToLookup(178, 5)] = Main.itemName[182];
			Lang.mapLegend[MapHelper.TileToLookup(178, 6)] = Main.itemName[999];
			Lang.mapLegend[MapHelper.TileToLookup(191, 0)] = "Living Wood";
			Lang.mapLegend[MapHelper.TileToLookup(204, 0)] = "Crimtane";
			Lang.mapLegend[MapHelper.TileToLookup(207, 0)] = "Water Fountain";
			Lang.mapLegend[MapHelper.TileToLookup(209, 0)] = "Cannon";
			Lang.mapLegend[MapHelper.TileToLookup(211, 0)] = "Chlorophyte";
			Lang.mapLegend[MapHelper.TileToLookup(212, 0)] = "Turret";
			Lang.mapLegend[MapHelper.TileToLookup(213, 0)] = "Rope";
			Lang.mapLegend[MapHelper.TileToLookup(214, 0)] = "Chain";
			Lang.mapLegend[MapHelper.TileToLookup(215, 0)] = "Campfire";
			Lang.mapLegend[MapHelper.TileToLookup(216, 0)] = "Rocket";
			Lang.mapLegend[MapHelper.TileToLookup(217, 0)] = "Blend-O-Matic";
			Lang.mapLegend[MapHelper.TileToLookup(218, 0)] = "Meat Grinder";
			Lang.mapLegend[MapHelper.TileToLookup(219, 0)] = "Silt Extractinator";
			Lang.mapLegend[MapHelper.TileToLookup(220, 0)] = "Solidifier";
			Lang.mapLegend[MapHelper.TileToLookup(221, 0)] = "Palladium";
			Lang.mapLegend[MapHelper.TileToLookup(222, 0)] = "Orichalcum";
			Lang.mapLegend[MapHelper.TileToLookup(223, 0)] = "Titanium";
			Lang.mapLegend[MapHelper.TileToLookup(227, 0)] = Main.itemName[1107];
			Lang.mapLegend[MapHelper.TileToLookup(227, 1)] = Main.itemName[1108];
			Lang.mapLegend[MapHelper.TileToLookup(227, 2)] = Main.itemName[1109];
			Lang.mapLegend[MapHelper.TileToLookup(227, 3)] = Main.itemName[1110];
			Lang.mapLegend[MapHelper.TileToLookup(227, 4)] = Main.itemName[1111];
			Lang.mapLegend[MapHelper.TileToLookup(227, 5)] = Main.itemName[1112];
			Lang.mapLegend[MapHelper.TileToLookup(227, 6)] = Main.itemName[1113];
			Lang.mapLegend[MapHelper.TileToLookup(227, 7)] = Main.itemName[1114];
			Lang.mapLegend[MapHelper.TileToLookup(227, 8)] = Main.itemName[3385];
			Lang.mapLegend[MapHelper.TileToLookup(227, 9)] = Main.itemName[3386];
			Lang.mapLegend[MapHelper.TileToLookup(227, 10)] = Main.itemName[3387];
			Lang.mapLegend[MapHelper.TileToLookup(227, 11)] = Main.itemName[3388];
			Lang.mapLegend[MapHelper.TileToLookup(228, 0)] = "Dye Vat";
			Lang.mapLegend[MapHelper.TileToLookup(231, 0)] = "Larva";
			Lang.mapLegend[MapHelper.TileToLookup(232, 0)] = "Wooden Spike";
			Lang.mapLegend[MapHelper.TileToLookup(235, 0)] = "Teleporter";
			Lang.mapLegend[MapHelper.TileToLookup(236, 0)] = "Life Fruit";
			Lang.mapLegend[MapHelper.TileToLookup(237, 0)] = "Lihzahrd Altar";
			Lang.mapLegend[MapHelper.TileToLookup(238, 0)] = "Plantera's Bulb";
			Lang.mapLegend[MapHelper.TileToLookup(239, 0)] = "Metal Bar";
			Lang.mapLegend[MapHelper.TileToLookup(240, 0)] = "Trophy";
			Lang.mapLegend[MapHelper.TileToLookup(240, 2)] = Main.npcName[21];
			Lang.mapLegend[MapHelper.TileToLookup(240, 3)] = "Item Rack";
			Lang.mapLegend[MapHelper.TileToLookup(240, 4)] = Main.itemName[2442];
			Lang.mapLegend[MapHelper.TileToLookup(241, 0)] = Main.itemName[1417];
			Lang.mapLegend[MapHelper.TileToLookup(242, 0)] = "Painting";
			Lang.mapLegend[MapHelper.TileToLookup(242, 1)] = "Animal Skin";
			Lang.mapLegend[MapHelper.TileToLookup(243, 0)] = "Imbuing Station";
			Lang.mapLegend[MapHelper.TileToLookup(244, 0)] = "Bubble Machine";
			Lang.mapLegend[MapHelper.TileToLookup(245, 0)] = "Picture";
			Lang.mapLegend[MapHelper.TileToLookup(246, 0)] = "Picture";
			Lang.mapLegend[MapHelper.TileToLookup(247, 0)] = "Autohammer";
			Lang.mapLegend[MapHelper.TileToLookup(254, 0)] = "Pumpkin";
			Lang.mapLegend[MapHelper.TileToLookup(269, 0)] = "Womannequin";
			Lang.mapLegend[MapHelper.TileToLookup(270, 0)] = "Firefly in a Bottle";
			Lang.mapLegend[MapHelper.TileToLookup(271, 0)] = "Lightning Bug in a Bottle";
			Lang.mapLegend[MapHelper.TileToLookup(275, 0)] = "Bunny Cage";
			Lang.mapLegend[MapHelper.TileToLookup(276, 0)] = "Squirrel Cage";
			Lang.mapLegend[MapHelper.TileToLookup(277, 0)] = "Mallard Duck Cage";
			Lang.mapLegend[MapHelper.TileToLookup(278, 0)] = "Duck Cage";
			Lang.mapLegend[MapHelper.TileToLookup(279, 0)] = "Bird Cage";
			Lang.mapLegend[MapHelper.TileToLookup(280, 0)] = "Blue Jay Cage";
			Lang.mapLegend[MapHelper.TileToLookup(281, 0)] = "Cardinal Cage";
			Lang.mapLegend[MapHelper.TileToLookup(282, 0)] = "Fish Bowl";
			Lang.mapLegend[MapHelper.TileToLookup(413, 0)] = "Orange Squirrel Cage";
			Lang.mapLegend[MapHelper.TileToLookup(283, 0)] = "Heavy Work Bench";
			Lang.mapLegend[MapHelper.TileToLookup(285, 0)] = "Snail Cage";
			Lang.mapLegend[MapHelper.TileToLookup(286, 0)] = "Glowing Snail Cage";
			Lang.mapLegend[MapHelper.TileToLookup(287, 0)] = "Ammo Box";
			Lang.mapLegend[MapHelper.TileToLookup(288, 0)] = "Monarch Butterfly Jar";
			Lang.mapLegend[MapHelper.TileToLookup(289, 0)] = "Purple Emperor Butterfly Jar";
			Lang.mapLegend[MapHelper.TileToLookup(290, 0)] = "Red Admiral Butterfly Jar";
			Lang.mapLegend[MapHelper.TileToLookup(291, 0)] = "Ulysses Butterfly Jar";
			Lang.mapLegend[MapHelper.TileToLookup(292, 0)] = "Sulphur Butterfly Jar";
			Lang.mapLegend[MapHelper.TileToLookup(293, 0)] = "Tree Nymph Butterfly Jar";
			Lang.mapLegend[MapHelper.TileToLookup(294, 0)] = "Zebra Swallowtail Butterfly Jar";
			Lang.mapLegend[MapHelper.TileToLookup(295, 0)] = "Julia Butterfly Jar";
			Lang.mapLegend[MapHelper.TileToLookup(296, 0)] = "Scorpion Cage";
			Lang.mapLegend[MapHelper.TileToLookup(297, 0)] = "Black Scorpion Cage";
			Lang.mapLegend[MapHelper.TileToLookup(298, 0)] = "Frog Cage";
			Lang.mapLegend[MapHelper.TileToLookup(299, 0)] = "Mouse Cage";
			Lang.mapLegend[MapHelper.TileToLookup(300, 0)] = "Bone Welder";
			Lang.mapLegend[MapHelper.TileToLookup(301, 0)] = "Flesh Cloning Vat";
			Lang.mapLegend[MapHelper.TileToLookup(302, 0)] = "Glass Kiln";
			Lang.mapLegend[MapHelper.TileToLookup(303, 0)] = "Lihzahrd Furnace";
			Lang.mapLegend[MapHelper.TileToLookup(304, 0)] = "Living Loom";
			Lang.mapLegend[MapHelper.TileToLookup(305, 0)] = "Sky Mill";
			Lang.mapLegend[MapHelper.TileToLookup(306, 0)] = "Ice Machine";
			Lang.mapLegend[MapHelper.TileToLookup(307, 0)] = "Steampunk Boiler";
			Lang.mapLegend[MapHelper.TileToLookup(308, 0)] = "Honey Dispenser";
			Lang.mapLegend[MapHelper.TileToLookup(309, 0)] = "Penguin Cage";
			Lang.mapLegend[MapHelper.TileToLookup(310, 0)] = "Worm Cage";
			Lang.mapLegend[MapHelper.TileToLookup(316, 0)] = "Blue Jellyfish Bowl";
			Lang.mapLegend[MapHelper.TileToLookup(317, 0)] = "Green Jellyfish Bowl";
			Lang.mapLegend[MapHelper.TileToLookup(318, 0)] = "Pink Jellyfish Bowl";
			Lang.mapLegend[MapHelper.TileToLookup(319, 0)] = "Ship in a Bottle";
			Lang.mapLegend[MapHelper.TileToLookup(320, 0)] = "Seaweed Planter";
			Lang.mapLegend[MapHelper.TileToLookup(323, 0)] = "Palm Tree";
			Lang.mapLegend[MapHelper.TileToLookup(314, 0)] = "Minecart Track";
			Lang.mapLegend[MapHelper.TileToLookup(353, 0)] = "Vine Rope";
			Lang.mapLegend[MapHelper.TileToLookup(354, 0)] = "Bewitching Table";
			Lang.mapLegend[MapHelper.TileToLookup(355, 0)] = "Alchemy Table";
			Lang.mapLegend[MapHelper.TileToLookup(356, 0)] = "Enchanted Sundial";
			Lang.mapLegend[MapHelper.TileToLookup(365, 0)] = "Silk Rope";
			Lang.mapLegend[MapHelper.TileToLookup(366, 0)] = "Web Rope";
			Lang.mapLegend[MapHelper.TileToLookup(373, 0)] = "Dripping Water";
			Lang.mapLegend[MapHelper.TileToLookup(374, 0)] = "Dripping Lava";
			Lang.mapLegend[MapHelper.TileToLookup(375, 0)] = "Dripping Honey";
			Lang.mapLegend[MapHelper.TileToLookup(377, 0)] = "Sharpening Station";
			Lang.mapLegend[MapHelper.TileToLookup(372, 0)] = Main.itemName[3117];
			for (int j = 0; j < Lang.mapLegend.Length; j++)
			{
				if (Lang.mapLegend[j] == null)
				{
					Lang.mapLegend[j] = string.Empty;
				}
			}
			Lang.chestType[0] = "상자";
			Lang.chestType[1] = "황금 상자";
			Lang.chestType[2] = "잠긴 황금 상자";
			Lang.chestType[3] = "그림자 상자";
			Lang.chestType[4] = "잠긴 그림자 상자";
			Lang.chestType[5] = "통";
			Lang.chestType[6] = "쓰레기통";
			Lang.chestType[7] = "흑단나무 상자";
			Lang.chestType[8] = "마호가니 상자";
			Lang.chestType[9] = "진주나무 상자";
			Lang.chestType[10] = "담쟁이 덩굴 상자";
			Lang.chestType[11] = "얼음 상자";
			Lang.chestType[12] = "생나무 상자";
			Lang.chestType[13] = "하늘의 상자";
			Lang.chestType[14] = "그늘나무 상자";
			Lang.chestType[15] = "거미줄 덮힌 상자";
			Lang.chestType[16] = "리자드 상자";
			Lang.chestType[17] = "물의 상자";
			Lang.chestType[18] = "정글 상자";
			Lang.chestType[19] = "부패된 상자";
			Lang.chestType[20] = "진홍의 상자";
			Lang.chestType[21] = "신성한 상자";
			Lang.chestType[22] = "얼어붙은 상자";
			Lang.chestType[23] = "잠긴 정글 상자";
			Lang.chestType[24] = "잠긴 부패한 상자";
			Lang.chestType[25] = "잠긴 진홍의 상자";
			Lang.chestType[26] = "잠긴 신성한 상자";
			Lang.chestType[27] = "잠긴 얼어붙은 상자";
			Lang.chestType[28] = "왕조의 상자";
			Lang.chestType[29] = "꿀 상자";
			Lang.chestType[30] = "스팀펑크 상자";
			Lang.chestType[31] = "야자수 상자";
			Lang.chestType[32] = "버섯 상자";
			Lang.chestType[33] = "아한대 나무 상자";
			Lang.chestType[34] = "슬라임 상자";
			Lang.chestType[35] = "녹색 던전 상자";
			Lang.chestType[36] = "잠긴 녹색 던전 상자";
			Lang.chestType[37] = "분홍색 던전 상자";
			Lang.chestType[38] = "잠긴 분홍색 던전 상자";
			Lang.chestType[39] = "파란색 던전 상자";
			Lang.chestType[40] = "잠긴 파란색 던전 상자";
			Lang.chestType[41] = "뼈 상자";
			Lang.chestType[42] = "선인장 상자";
			Lang.chestType[43] = "살덩이 상자";
			Lang.chestType[44] = "흑요석 상자";
			Lang.chestType[45] = "호박 상자";
			Lang.chestType[46] = "으스스한 상자";
			Lang.chestType[47] = "유리 상자";
			Lang.chestType[48] = "마티안 상자";
			Lang.chestType[49] = "운석 상자";
			Lang.chestType[50] = "Granite Chest";
			Lang.chestType[51] = "Marble Chest";

			Lang.dresserType[0] = "Dresser";
			Lang.dresserType[1] = "Ebonwood Dresser";
			Lang.dresserType[2] = "Rich Mahogany Dresser";
			Lang.dresserType[3] = "Pearlwood Dresser";
			Lang.dresserType[4] = "Shadewood Dresser";
			Lang.dresserType[5] = "Blue Dungeon Dresser";
			Lang.dresserType[6] = "Green Dungeon Dresser";
			Lang.dresserType[7] = "Pink Dungeon Dresser";
			Lang.dresserType[8] = "Golden Dresser";
			Lang.dresserType[9] = "Obsidian Dresser";
			Lang.dresserType[10] = "Bone Dresser";
			Lang.dresserType[11] = "Cactus Dresser";
			Lang.dresserType[12] = "Spooky Dresser";
			Lang.dresserType[13] = "Skyware Dresser";
			Lang.dresserType[14] = "Honey Dresser";
			Lang.dresserType[15] = "Lihzahrd Dresser";
			Lang.dresserType[16] = "Palm Wood Dresser";
			Lang.dresserType[17] = "Mushroom Dresser";
			Lang.dresserType[18] = "Boreal Wood Dresser";
			Lang.dresserType[19] = "Slime Dresser";
			Lang.dresserType[20] = "Pumpkin Dresser";
			Lang.dresserType[21] = "Steampunk Dresser";
			Lang.dresserType[22] = "Glass Dresser";
			Lang.dresserType[23] = "Flesh Dresser";
			Lang.dresserType[24] = "Martian Dresser";
			Lang.dresserType[25] = "Meteorite Dresser";
			Lang.dresserType[26] = "Granite Dresser";
			Lang.dresserType[27] = "Marble Dresser";

			Lang.prefix[1] = "큰";
			Lang.prefix[2] = "커다란";
			Lang.prefix[3] = "위험한";
			Lang.prefix[4] = "야만적인";
			Lang.prefix[5] = "날카로운";
			Lang.prefix[6] = "뾰족한";
			Lang.prefix[7] = "난쟁이의";
			Lang.prefix[8] = "끔찍한";
			Lang.prefix[9] = "작은";
			Lang.prefix[10] = "무뎌진";
			Lang.prefix[11] = "불행한";
			Lang.prefix[12] = "뚱뚱한";
			Lang.prefix[13] = "수치스런";
			Lang.prefix[14] = "무거운";
			Lang.prefix[15] = "가벼운";
			Lang.prefix[16] = "노려보는";
			Lang.prefix[17] = "빠른";
			Lang.prefix[18] = "급한";
			Lang.prefix[19] = "위협적인";
			Lang.prefix[20] = "데들리";
			Lang.prefix[21] = "신뢰의";
			Lang.prefix[22] = "두려운";
			Lang.prefix[23] = "힘빠지는";
			Lang.prefix[24] = "힘든";
			Lang.prefix[25] = "강한";
			Lang.prefix[58] = "격정의";
			Lang.prefix[26] = "신비의";
			Lang.prefix[27] = "숙련자의";
			Lang.prefix[28] = "달인의";
			Lang.prefix[29] = "초심자의";
			Lang.prefix[30] = "무식한";
			Lang.prefix[31] = "혼란의";
			Lang.prefix[32] = "강렬한";
			Lang.prefix[33] = "금단의";
			Lang.prefix[34] = "천상의";
			Lang.prefix[35] = "분노한";
			Lang.prefix[52] = "성급한";
			Lang.prefix[36] = "예리한";
			Lang.prefix[37] = "우수한";
			Lang.prefix[38] = "강력한";
			Lang.prefix[53] = "피해의";
			Lang.prefix[54] = "단단한";
			Lang.prefix[55] = "소름끼치는";
			Lang.prefix[39] = "단절된";
			Lang.prefix[40] = "파손된";
			Lang.prefix[56] = "약해보이는";
			Lang.prefix[41] = "가식적인";
			Lang.prefix[57] = "무자비한";
			Lang.prefix[42] = "빠른";
			Lang.prefix[43] = "데들리";
			Lang.prefix[44] = "민첩한";
			Lang.prefix[45] = "재빠른";
			Lang.prefix[46] = "흉측한";
			Lang.prefix[47] = "감속하는";
			Lang.prefix[48] = "둔한";
			Lang.prefix[49] = "게으른";
			Lang.prefix[50] = "짜증나는";
			Lang.prefix[51] = "고약한";
			Lang.prefix[59] = "신성한";
			Lang.prefix[60] = "악마같은";
			Lang.prefix[61] = "열광하는";
			Lang.prefix[62] = "단단한";
			Lang.prefix[63] = "방어의";
			Lang.prefix[64] = "무장의";
			Lang.prefix[65] = "수호의";
			Lang.prefix[66] = "신비한";
			Lang.prefix[67] = "정확한";
			Lang.prefix[68] = "행운의";
			Lang.prefix[69] = "가시의";
			Lang.prefix[70] = "가시박힌";
			Lang.prefix[71] = "화난";
			Lang.prefix[72] = "위협적인";
			Lang.prefix[73] = "상쾌한";
			Lang.prefix[74] = "일시적인";
			Lang.prefix[75] = "급한";
			Lang.prefix[76] = "재빠른";
			Lang.prefix[77] = "야생의";
			Lang.prefix[78] = "성급한";
			Lang.prefix[79] = "대담한";
			Lang.prefix[80] = "난폭한";
			Lang.prefix[81] = "전설의";
			Lang.prefix[82] = "환상의";
			Lang.prefix[83] = "신화의";
		}

		public static string projectileName(int l)
		{
			switch (Main.projectile[l].type)
			{
				#region 1 - 10
				case 1:
					return "나무 화살";
				case 2:
					return "불화살";
				case 3:
					return "수리검";
				case 4:
					return "저주받은 화살";
				case 5:
					return "광대의 화살";
				case 6:
					return "마법의 부메랑";
				case 7:
				case 8:
					return "치명적인 가시";
				case 9:
					return "별똥별";
				case 10:
					return "정화 가루";
				#endregion
				#region 11 - 20
				case 11:
					return "오염 가루";
				case 12:
					return "별똥별";
				case 13:
					return "갈고리";
				case 14:
					return "총알";
				case 15:
					return "화염의 구체";
				case 16:
					return "매직 미사일";
				case 17:
					return "흙 덩어리";
				case 18:
					return "그림자 보구";
				case 19:
					return "불메랑";
				case 20:
					return "녹색 레이저";
				#endregion
				#region 21 - 30
				case 21:
					return "뼈";
				case 22:
					return "물의 흐름";
				case 23:
					return "죽창";
				case 24:
					return "가시공";
				case 25:
					return "가격의 철퇴";
				case 26:
					return "푸른 달";
				case 27:
					return "워터 볼트";
				case 28:
					return "폭탄";
				case 29:
					return "다이너마이트";
				case 30:
					return "갓-그레네이드";
				#endregion
				#region 31 - 40
				case 31:
					return "모래 덩어리";
				case 32:
					return "덩굴 채찍";
				case 33:
					return "가시 챠크람";
				case 34:
					return "화염탄";
				case 35:
					return "태양의 분노";
				case 36:
					return "운석 총알";
				case 37:
					return "접착식 폭탄";
				case 38:
					return "하피의 깃털";
				case 39:
					return "진흙 덩어리";
				case 40:
					return "화산재 덩어리";
				#endregion
				#region 41 - 50
				case 41:
					return "지옥불 화살";
				case 42:
					return "모래 덩어리";
				case 43:
					return "비석";
				case 44:
				case 45:
					return "악마의 낫";
				case 46:
					return "어둠의 창";
				case 47:
					return "삼지창";
				case 48:
					return "투검";
				case 49:
					return "창";
				case 50:
					return "형광봉";
				#endregion
				#region 51 - 60
				case 51:
					return "씨앗";
				case 52:
					return "나무 부메랑";
				case 53:
					return "접착식 형광봉";
				case 54:
					return "독이 발라진 투검";
				case 55:
					return "가시";
				case 56:
					return "흑단모래 덩어리";
				case 57:
					return "코발트 전기톱";
				case 58:
					return "미스릴 전기톱";
				case 59:
					return "코발트 드릴";
				case 60:
					return "미스릴 드릴";
				#endregion
				#region 61 - 70
				case 61:
					return "아다만타이트 전기톱";
				case 62:
					return "아다만타이트 드릴";
				case 63:
					return "음양의 철퇴";
				case 64:
					return "미스릴 미늘창";
				case 65:
					return "흑단모래 덩어리";
				case 66:
					return "아다만타이트 검날창";
				case 67:
					return "신성모래 덩어리";
				case 68:
					return "신성모래 덩어리";
				case 69:
					return "축복의 물";
				case 70:
					return "저주의 물";
				#endregion
				#region 71 - 80
				case 71:
					return "실트 덩어리";
				case 72:
					return "요정 (청)";
				case 73:
					return "갈고리 (청)";
				case 74:
					return "갈고리 (적)";
				case 75:
					return "웃지마 황달새끼야";
				case 76:
					return "음표";
				case 77:
					return "음표";
				case 78:
					return "음표";
				case 79:
					return "무지개";
				case 80:
					return "얼음 블럭";
				#endregion
				#region 81 - 90
				case 81:
					return "나무 화살";
				case 82:
					return "불화살";
				case 83:
					return "눈광선";
				case 84:
					return "분홍 레이저";
				case 85:
					return "화염";
				case 86:
					return "요정 (자)";
				case 87:
					return "요정 (녹)";
				case 88:
					return "보라색 레이저";
				case 89:
					return "수정 총알";
				case 90:
					return "수정 파편";
				#endregion
				#region 91 - 100
				case 91:
					return "성스러운 화살";
				case 92:
					return "성스러운 별";
				case 93:
					return "마법의 단검";
				case 94:
					return "수정 폭풍";
				case 95:
					return "저주받은 불꽃";
				case 96:
					return "저주받은 화염";
				case 97:
					return "코발트 나기나타";
				case 98:
					return "맹독 다트";
				case 99:
					return "함정 돌멩이";
				case 100:
					return "죽음의 레이저";
				#endregion
				#region 101 - 110
				case 101:
					return "눈의 화염";
				case 102:
					return "폭탄";
				case 103:
					return "저주받은 화살";
				case 104:
					return "저주받은 총알";
				case 105:
					return "궁니르";
				case 106:
					return "빛의 원반";
				case 107:
					return "드렉스";
				case 108:
					return "폭발물";
				case 109:
					return "눈덩이";
				case 110:
					return "총알";
				#endregion
				#region 111 - 120
				case 111:
					return "토끼";
				case 112:
					return "펭귄";
				case 113:
					return "얼음 부메랑";
				case 114:
					return "저주받은 삼지창";
				case 115:
					return "저주받은 삼지창";
				case 116:
					return "검기";
				case 117:
					return "뼈화살";
				case 118:
					return "얼음 구체";
				case 119:
					return "한기의 구체";
				case 120:
					return "한기의 화살";
				#endregion
				#region 121 - 130
				case 121:
					return "아메디스트 구체";
				case 122:
					return "토파즈 구체";
				case 123:
					return "사파이어 구체";
				case 124:
					return "에메랄드 구체";
				case 125:
					return "루비 구체";
				case 126:
					return "다이아몬드 구체";
				case 127:
					return "거북이";
				case 128:
					return "프로스트 블레스트";
				case 129:
					return "룬 블레스트";
				case 130:
					return "버섯창";
				#endregion
				#region 131 - 140
				case 131:
					return "버섯";
				case 132:
					return "테라 빔";
				case 133:
					return "로켓 I 류탄";
				case 134:
					return "로켓 I";
				case 135:
					return "로켓 I 지뢰";
				case 136:
					return "로켓 II 류탄";
				case 137:
					return "로켓 II";
				case 138:
					return "로켓 II 지뢰";
				case 139:
					return "로켓 III 류탄";
				case 140:
					return "로켓 III";
				#endregion
				#region 141 - 150
				case 141:
					return "로켓 III 지뢰";
				case 142:
					return "로켓 IV 류탄";
				case 143:
					return "로켓 IV";
				case 144:
					return "로켓 IV 지뢰";
				case 145:
					return "정화용액";
				case 146:
					return "신성화용액";
				case 147:
					return "오염용액";
				case 148:
					return "버섯용액";
				case 149:
					return "피의용액";
				case 150:
					return "가시 블러스트";
				#endregion
				#region 151 - 160
				case 151:
					return "가시 블러스트";
				case 152:
					return "가시 블러스트";
				case 153:
					return "썩은 고기";
				case 154:
					return "고기 완자";
				case 155:
					return "비치볼";
				case 156:
					return "빛의 광선";
				case 157:
					return "밤의 광선";
				case 158:
					return "동화";
				case 159:
					return "은화";
				case 160:
					return "금화";
				#endregion
				#region 161 - 170
				case 161:
					return "백금화";
				case 162:
					return "포탄";
				case 163:
					return "조명탄";
				case 164:
					return "지뢰";
				case 165:
					return "거미줄";
				case 166:
					return "눈덩이";
				case 167:
					return "로켓 (적)";
				case 168:
					return "로켓 (녹)";
				case 169:
					return "로켓 (청)";
				case 170:
					return "로켓 (황)";
				#endregion
				#region 171 - 180
				case 171:
					return "밧줄 뭉치";
				case 172:
					return "한기의 화염 화살";
				case 173:
					return "마법 광선";
				case 174:
					return "얼음 가시";
				case 175:
					return "아기 포식자";
				case 176:
					return "정글 가시";
				case 177:
					return "빙수 가시";
				case 178:
					return "축하 색종이";
				case 179:
					return "슬러시 덩어리";
				case 180:
					return "총알";
				#endregion
				#region 181 - 190
				case 181:
					return "꿀벌";
				case 182:
					return "귀신들린 손도끼";
				case 183:
					return "꿀벌류탄";
				case 184:
					return "독바른 다트";
				case 185:
					return "가시 공";
				case 186:
					return "창";
				case 187:
					return "화염방사기";
				case 188:
					return "화염";
				case 189:
					return "Wasp";
				case 190:
					return "기계 피라니아";
				#endregion
				#region 191 - 200
				case 191:
					return "피그미(청)";
				case 192:
					return "피그미(자)";
				case 193:
					return "피그미(적)";
				case 194:
					return "피그미(황)";
				case 195:
					return "피그미";
				case 196:
					return "연막탄";
				case 197:
					return "아기 스켈레트론 머리";
				case 198:
					return "아기 말벌";
				case 199:
					return "티키 영혼";
				case 200:
					return "애완 도마뱀";
				#endregion
				#region 201 - 210
				case 201:
					return "";
				case 202:
					return "";
				case 203:
					return "";
				case 204:
					return "";
				case 205:
					return "";
				case 206:
					return "나뭇잎";
				case 207:
					return "녹조류 총알";
				case 208:
					return "앵무새";
				case 209:
					return "트러플";
				case 210:
					return "묘목";
				#endregion
				#region 211 - 220
				case 211:
					return "위습";
				case 212:
					return "팔라듐 파이크";
				case 213:
					return "팔라듐 드릴";
				case 214:
					return "팔라듐 전기톱";
				case 215:
					return "오리칼쿰 미늘창";
				case 216:
					return "오리칼쿰 드릴";
				case 217:
					return "오리칼쿰 전기톱";
				case 218:
					return "티타늅 삼지창";
				case 219:
					return "티타늄 드릴";
				case 220:
					return "티타튬 전기톱";
				#endregion
				#region 221 - 230
				case 221:
					return "꽃의 조각";
				case 222:
					return "녹조류 파티산";
				case 223:
					return "녹조류 드릴";
				case 224:
					return "녹조류 전기톱";
				case 225:
					return "녹조류 화살";
				case 226:
					return "수정나뭇잎";
				case 227:
					return "수정나뭇잎";
				case 228:
					return "포자구름";
				case 229:
					return "녹조류 보구";
				case 230:
					return "";
				#endregion
				#region 231 - 240
				case 231:
					return "";
				case 232:
					return "";
				case 233:
					return "";
				case 234:
					return "";
				case 235:
					return "";
				case 236:
					return "아기 공룡";
				case 237:
					return "비구름";
				case 238:
					return "비구름";
				case 239:
					return "비";
				case 240:
					return "포탄";
				#endregion
				#region 241 - 250
				case 241:
					return "핏빛모래 덩어리";
				case 242:
					return "피구름";
				case 243:
					return "피구름";
				case 244:
					return "피의 비";
				case 245:
					return "스틴저";
				case 246:
					return "꽃의 철퇴";
				case 247:
					return "꽃의 철퇴";
				case 248:
					return "스틴저";
				case 249:
					return "무지개";
				case 250:
					return "무지개";
				#endregion
				#region 251 - 260
				case 251:
					return "무지개";
				case 252:
					return "녹조류 잭해머";
				case 253:
					return "한기의 구체";
				case 254:
					return "자력 구체";
				case 255:
					return "자력 구체";
				case 256:
					return "스켈레트론 팔";
				case 257:
					return "한기의 광선";
				case 258:
					return "파이어볼";
				case 259:
					return "눈깔빔";
				case 260:
					return "가열 광선";
				#endregion
				#region 261 - 270
				case 261:
					return "함정 돌멩이";
				case 262:
					return "골렘 피스트";
				case 263:
					return "얼음 낫";
				case 264:
					return "비";
				case 265:
					return "포이즌 팡";
				case 266:
					return "아기 슬라임";
				case 267:
					return "독바른 다트";
				case 268:
					return "";
				case 269:
					return "아기 눈사람";
				case 270:
					return "해골";
				#endregion
				#region 271 - 280
				case 271:
					return "권투 글러브";
				case 272:
					return "바나나랑";
				case 273:
					return "사슬 칼날";
				case 274:
					return "죽음의 낫";
				case 275:
					return "씨앗";
				case 276:
					return "독성 씨앗";
				case 277:
					return "가시 공";
				case 278:
					return "이코르 화살";
				case 279:
					return "이코르 총알";
				case 280:
					return "골든 샤워";
				#endregion
				#region 281 - 290
				case 281:
					return "폭발성 토끼";
				case 282:
					return "맹독 화살";
				case 283:
					return "맹독 총알";
				case 284:
					return "파티 총알";
				case 285:
					return "나노 총알";
				case 286:
					return "폭발성 총알";
				case 287:
					return "황금 총알";
				case 288:
					return "골든 샤워";
				case 289:
					return "색종이";
				case 290:
					return "그림자 광선";
				#endregion
				#region 291 - 300
				case 291:
					return "인페르노";
				case 292:
					return "인페르노";
				case 294:
					return "그림자 광선";
				case 295:
					return "인페르노";
				case 296:
					return "인페르노";
				case 297:
					return "잃어버린 영혼";
				case 300:
					return "성기사의 망치";
				#endregion
				#region 301 - 310
				case 301:
					return "성기사의 망치";
				case 302:
					return "스나이퍼 총알";
				case 303:
					return "로켓";
				case 304:
					return "흡혈귀의 칼날";
				case 305:
					return "흡혈";
				case 306:
					return "포식자의 아귀";
				case 307:
					return "작은 포식자";
				case 308:
					return "한기의 히드라";
				case 309:
					return "프로스트 블래스트";
				case 310:
					return "푸른 조명탄";
				#endregion
				#region 311 - 320
				case 311:
					return "캔디 콘";
				case 312:
					return "호박 등불";
				case 313:
					return "거미";
				case 314:
					return "스쿼실링";
				case 315:
					return "박쥐 갈고리";
				case 316:
					return "박쥐";
				case 317:
					return "까마귀";
				case 318:
					return "썩은 달걀";
				case 319:
					return "검은 고양이";
				case 320:
					return "피의 푸줏칼";
				#endregion
				#region 321 - 330
				case 321:
					return "";
				case 322:
					return "으스스한 갈고리";
				case 323:
					return "말뚝";
				case 324:
					return "저주밭은 가지";
				case 325:
				case 326:
				case 327:
					return "그리스 화염";
				case 328:
					return "그리스 화염";
				case 329:
					return "불타는 낫";
				case 330:
					return "별 아니스";
				#endregion
				#region 331 - 340
				case 331:
					return "막대사탕 갈고리";
				case 332:
					return "크리스마스 갈고리";
				case 333:
					return "과일케익 챠크람";
				case 334:
					return "강아지";
				case 335:
					return "트리 장식";
				case 336:
					return "소나무 바늘";
				case 337:
					return "블리자드";
				case 338:
					return "로켓 I";
				case 339:
					return "로켓 II";
				case 340:
					return "로켓 III";
				#endregion
				#region 341 - 350
				case 341:
					return "로켓 IV";
				case 342:
					return "북극 창";
				case 343:
					return "북극 창";
				case 344:
					return "북극 창";
				case 345:
					return "소나무 가시";
				case 346:
					return "트리 장식";
				case 347:
					return "트리 장식";
				case 348:
					return "한기의 파동";
				case 349:
					return "한기의 비늘";
				case 350:
					return "미사일";
				#endregion
				#region 351 - 360
				case 351:
					return "선물";
				case 352:
					return "가시";
				case 353:
					return "";
				case 354:
					return "핏빛모래 덩어리";
				case 355:
					return "맹독의 팡";
				case 356:
					return "스펙터 레이스";
				case 357:
					return "파동의 구체";
				case 358:
					return "물총";
				case 359:
					return "한기의 구체";
				case 360:
					return "";
				#endregion
				#region 361 - 370
				case 361:
					return "";
				case 362:
					return "";
				case 363:
					return "";
				case 364:
					return "";
				case 365:
					return "";
				case 366:
					return "";
				case 367:
					return "흑요석 청새치";
				case 368:
					return "냉동 청새치(!!)";
				case 369:
					return "톱니 상어";
				case 370:
					return "사랑의 묘약";
				#endregion
				#region 371 - 380
				case 371:
					return "악취의 물약";
				case 372:
					return "";
				case 373:
					return "말벌";
				case 374:
					return "말벌 침";
				case 375:
					return "비행 임프";
				case 376:
					return "임프의 화염구";
				case 377:
					return "거미 둥지";
				case 378:
					return "거미 알";
				case 379:
					return "새끼 거미";
				case 380:
					return "제피어 물고기";
				#endregion
				#region 381 - 390
				case 383:
					return "닻";
				case 384:
					return "샤크네이도";
				case 385:
					return "샤크네이도 볼트";
				case 386:
					return "크툴네이도";
				case 387:
					return "레타니미니";
				case 388:
					return "스파즈마미니";
				case 389:
					return "미니 레티나 레이저";
				case 390:
					return "맹독 거미";
				#endregion
				#region 391 - 400
				case 391:
					return "뛰는 거미";
				case 392:
					return "위험한 거미";
				case 393:
					return "애꾸눈 해적";
				case 394:
					return "영혼없는 해적";
				case 395:
					return "해적 선장";
				case 396:
					return "";
				case 397:
					return "끈적이는 갓-그레네이드";
				case 398:
					return "미니 미노타우";
				case 399:
					return "화염병 칵테일";
				case 400:
					return "화염병 화염";
				#endregion
				#region 401 - 410
				case 401:
					return "화염병 화염";
				case 402:
					return "화염병 화염";
				case 403:
					return "추적 갈고리";
				case 404:
					return "플레이론";
				case 405:
					return "플레이론의 거품";
				case 406:
					return "슬라임 총";
				case 407:
					return "템페스트";
				case 408:
					return "미니 샤크론";
				case 409:
					return "태풍";
				case 410:
					return "거품 총";
				#endregion
				#region 411 - 420
				case 411:
					return "동화";
				case 412:
					return "은화";
				case 413:
					return "금화";
				case 414:
					return "백금화";
				case 415:
					return "폭죽";
				case 416:
					return "폭죽";
				case 417:
					return "폭죽";
				case 418:
					return "폭죽";
				case 419:
					return "폭죽 지지대";
				case 420:
					return "폭죽 지지대";
				#endregion 421 - 430
				case 421:
					return "폭죽 지지대";
				case 422:
					return "폭죽 지지대";

				default:
					return "";
			}
		}

		public static string deathMsg(int plr = -1, int npc = -1, int proj = -1, int other = -1)
		{
			string result = "";
			int num = Main.rand.Next(26);
			string text = "";
			if (num == 0)
			{
				text = " 죽을 수 밖에 없었습니다.";
			}
			else if (num == 1)
			{
				text = " 탈장되어 사망했습니다.";
			}
			else if (num == 2)
			{
				text = " 살해 당했습니다.";
			}
			else if (num == 3)
			{
				text = " 얼굴이 찢어졌습니다.";
			}
			else if (num == 4)
			{
				text = " 복부가 분해되었습니다.";
			}
			else if (num == 5)
			{
<<<<<<< HEAD
			case 0:
				array2[0] = "어! 내가 말한 물고기네? 고마워, 이제 가버려!";
				break;
			case 1:
				array2[0] = "정말 멋져! 계획대로 되 가는군! 헤헤헤!";
				break;
			case 2:
				array2[0] = "넌 정말 좋은 심부름꾼이야! 이제 가!";
				break;
			case 3:
				array2[0] = "음하하하하하! 너 해냈잖아! 근데 다친곳 하나없네? 재미없어!";
				break;
			case 4:
				array2[0] = "뭐어!? 정말 내가 말한걸 해냈잖아! 그리고 살아남았어! 좋아, 그거 빨리 주고 저리가!";
				break;
=======
				text = " 분쇄되었습니다.";
>>>>>>> origin/master
			}
			else if (num == 6)
			{
<<<<<<< HEAD
			case 0:
				array[0] = "지금은 시킬 일이 없는데...";
				break;
			case 1:
				array[0] = "오늘 충분히 날 즐겁게 했어! 가도 좋아.";
				break;
			case 2:
				array[0] = "오늘은 끝이야, 터키의 황제 " + str + " 은(는) 널 해고하노라!";
				break;
			case 3:
				array[0] = "하루에 물고기 하나만, 제발 저리좀 가!";
				break;
			case 4:
				array[0] = "너가 마지막으로 잡아준 물고기도 다 못 썼어. 더 이상은 필요없어.";
				break;
=======
				text = " 얼굴을 알아볼 수 없게 되었습니다.";
>>>>>>> origin/master
			}
			else if (num == 7)
			{
<<<<<<< HEAD
			case 2450:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "나나나나나나나나 배트피쉬!";
					array[num2++] = "무슨 뜻인지 알아? 땅파 들어가서 잡아오라구!";
					flag = true;
					text = "\n(지하와 동굴에서 잡을 수 있습니다)";
				}
				break;
			case 2451:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = Main.worldName + "의 정글 지하에는 정말 이상한게 있더라고!";
					array[num2++] = "그러니까, 물고긴데 큰 호박벌같이 생긴거야!";
					array[num2++] = "난 벌 알레르기가 있거든, 그러니까 네가 잡아와줘! 꿀 !";
					flag = true;
					text = "\n(꿀에서 잡을 수 있습니다)";
				}
				break;
			case 2452:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "드디어 물을 좋아하는 정글 고양이를 찾았어! 내생각엔 그게 물고기이기도 해서 그런거 같아.";
					array[num2++] = "왜 그런 물고기가 생겼는지는 몰라, 알고싶지도 않고.";
					array[num2++] = "그냥 내 수중에 있으면 좋겠어, 빨리!";
					flag = true;
					text = "\n(정글 지표면에서 잡을 수 있습니다)";
				}
				break;
			case 2453:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "하늘에도 섬이 있는 소문이 돌고 있더라고, 멋진 보물도 함께 있다는걸 말야!";
					array[num2++] = "근데 누가 그걸 신경이나 쓰겠어, 더 멋진게 뭐냐면 구름 속에 연못이 생긴다는거야, 그리고 그 연못엔 구름으로 만들어진 물고기가 있대!";
					array[num2++] = "맛이 어떨지 정말 궁금해, 그러니까 가서 잡아와!";
					flag = true;
					text = "\n(하늘 연못에서 잡을 수 있습니다)";
				}
				break;
			case 2454:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "깊은 타락한 땅에는 저주받은 물고기가 산다더라고!";
					array[num2++] = "그 깊은곳을 돌아다니는 타락한 공포들의 저주받은 불꽃으로 만들어진건데.";
					array[num2++] = "사람들이 말하기를 물도 그 불은 못끈다더라고, 그래서 무한히 탄데.";
					array[num2++] = "그 물고기라면 멋진 일을 할 수 있을꺼야! 가서 잡아와!";
					flag = true;
					text = "\n(타락한 지형에서 잡을 수 있습니다)";
				}
				break;
			case 2455:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "있지, 숲속 연못에서 낚시를 하다 월척을 잡은줄 알았는데 갑자기 좀비가 나오더라고! 그리고는 흙으로 만들어진 특별한 물고기 얘기를 시작하는데";
					array[num2++] = "자기 몸보다 열배는 더 클수..있다..했던가, 뭐 그런거였는데... 나 그거 가지고싶어! 당장!";
					flag = true;
					text = "\n(지표면과 지하, 동굴에서 잡을 수 있습니다)";
				}
				break;
			case 2456:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "숲 속의 연못에서 폭탄상인이 지팡이를 들다 다이너마이트를 하나 떨어뜨렸거든. 근데 그 사람한테 다이너마이트가 만잖아,하나가 무슨상관이냐고?";
					array[num2++] = "듣자하니 지느러미가 생겨서 도망갔다 하더라고! 도데체 그런걸 왜 만들었는진 모르겠지만, 분명 그건 뭔가 씌인게 분명해!";
					array[num2++] = "잡아서 가져와, 평소에도 자폭하는 물고기가 가지고 싶었거든! 왠지는 묻지마...";
					flag = true;
					text = "\n(지표면에서 잡을 수 있습니다)";
				}
				break;
			case 2457:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "내가 장담하건데, 넌 분명히 플랭크톤을 먹는 자를 잡아올 용기가 없을꺼야.";
					array[num2++] = "타락한 물고기인데, 세상을 먹는자의 한 부분으로 진화를 했거든!";
					array[num2++] = "잡아서 가져와봐, 그리구 쪼다가 아니라는걸 증명해봐!";
					flag = true;
					text = "\n(타락한 지역에서 잡을 수 있습니다)";
				}
				break;
			case 2458:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "하늘에서 떨어지는 노란 별을 모으는게 좋아! 다른사람 머리로 떨어지면 더 그렇구!";
					array[num2++] = "하지만..하지만.. 연못에 떨어져서 물고기로 변하는것보다 멋진건 없어!";
					array[num2++] = "완전 멋지지 않아? 그리고 넌 그걸 나한테 가져올 만큼 멋지고!";
					flag = true;
					text = "\n(하늘 연못에서 잡을 수 있습니다)";
				}
				break;
			case 2459:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "듣자하니, 악마의 눈은 수륙양용이더라고. 날지 않으면, 헤엄을 친데!";
					array[num2++] = "그런걸 욕조에 넣어놓으면 사람들 표정이 어떨지 정말 궁금해!";
					array[num2++] = "걔내들은 비슷한곳에서 나타난데. 뭔소리냐면 잡아오라는 소리지!";
					flag = true;
					text = "\n(하늘 연못과 지표면에서 잡을 수 있습니다)";
				}
				break;
			case 2460:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "뭐가 더 안좋은건지 모르겠어, 뼈생선 아니면 '손이 있는' 뼈 생선. 이 피쇼트론을 깊은 동굴에서 발견했는데 난 정말 놀랬어!";
					array[num2++] = "던젼 근처의 노인을 홀린 영혼이 이 물고기도 홀린게 분명해!";
					array[num2++] = "얼렁 가서 잡아야해!";
					flag = true;
					text = "\n(동굴에서 잡을 수 있습니다)";
				}
				break;
			case 2461:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "호수 근처 언덕에서 잘려고하는데 물고기가 위에서 급강하하더라고! 날고 있었단 말야!";
					array[num2++] = "어떤 아가씨의 얼굴도 있고 깃털도 있더라고! 그ㄴ...그 물고기보다 내가 더 크게 소리를 지른거 같아!";
					array[num2++] = "나를 놀래킨 댓가를 그녀...그 물고기한테서 받아와!";
					flag = true;
					text = "\n(하늘 호수와 지표면에서 잡을 수 있습니다)";
				}
				break;
			case 2462:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "육체의 벽에서 떨어져 나온것 중에, 물고기처럼 생긴게 나와서 지하를 해집고 다니고 있어, 정말 징그럽고 구역질나고 난 그걸 원해!";
					flag = true;
					text = "\n(동굴에서 잡을 수 있습니다)";
				}
				break;
			case 2463:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "그거 알아? 깊은 피투성이 땅에 사는 생명채들이 징그러운 노란 물체를 만드는거?";
					array[num2++] = "어디서 들은 바보같은 소린데 그게 물고기 같이 뭉쳐져서 헤엄도 치고 다 하는다는거야!";
					array[num2++] = "잡아와줘, 누군가의 화장실에 붙이게!";
					flag = true;
					text = "\n(피투성이 땅에서 잡을 수 있습니다)";
				}
				break;
			case 2464:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "오오오오...  난 부자가 될꺼야! 동굴 깊은곳에 보석들로 만들어진 물고기가 있어!";
					array[num2++] = "어떻게 그런게 있는지 묻지마, 나도모르고, 내가 아는건 그건 정말 멋지고 네가 잡아올거라는 거야!";
					flag = true;
					text = "\n(지하와 동굴에서 잡을 수 있습니다)";
				}
				break;
			case 2465:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "깊은 신성의 땅에 재미있는 생물이 있어, 말해줄게!";
					array[num2++] = "내 눈을 어지럽히는 보랏빛깔로 빛나는 생물이야!";
					array[num2++] = "정말 야생스러워, 그러니까 잡아와!";
					flag = true;
					text = "\n(신성한 땅 지하에서 잡을 수 있습니다)";
				}
				break;
			case 2466:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "하얗고 갈색이고 털이 많고 얼어붙은 땅속 연못에 사는게 뭔지 알아? 돌연변이 플링스핀이야!";
					array[num2++] = "농담아냐, 진짜야, 플링스의 돌연변이는 몇가지가 있고 수중에서 사는데 더 적응되있어!";
					array[num2++] = "내 어항에도 적응시키고 싶어, 내 소원이 진짜로 일어나게 해줘!";
					flag = true;
					text = "\n(툰드라 지하에서 잡을 수 있습니다)";
				}
				break;
			case 2467:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "아냐 고래야! 아냐 돌고래야! 아니야, 그건 펭귄물고기야! 오, 이게 누구야, 너잖아!";
					array[num2++] = "하나 가져와! 차가운 물을 좋아하는거 알지, 그렇지?";
					flag = true;
					text = "\n(툰드라에서 잡을 수 있습니다)";
				}
				break;
			case 2468:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "픽시중에 정말 정말 희귀한 종이 있는데, 날개가 너무 많아서 날수 없는 거야!";
					array[num2++] = "근처에 파란 풀이 있는 연못 에서 다른 물고기와 헤엄을 친대.";
					array[num2++] = "내 어항은 광원이 필요하거든, 그래서 그 픽시를 잡아오면 좋겠어!";
					flag = true;
					text = "\n(신성한 땅에서 잡을 수 있습니다)";
				}
				break;
			case 2469:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "다리가 8개 있는 물고기를 봤어! 아냐! 그건 정말 아닐꺼야!";
					array[num2++] = "잡아와, 내가 낚시할땐 더이상 살아있지 않도록!";
					array[num2++] = "그걸 본 이후론 내가 깊은 동굴론 안가는거 알지?";
					flag = true;
					text = "\n(지하와 동굴에서 잡을 수 있습니다)";
				}
				break;
			case 2470:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "왜" + Main.worldName + " 세계의 눈덮인 곳의 연못은 얼지 않는지 궁금하지 않아? 난 안궁금해.";
					array[num2++] = "근데, 물고기는 얼어!얼음으로 만들어진 물고기는 분명 고결하고 엄청난 " + str + "에게 도움이 될꺼야!";
					array[num2++] = "가라, 충성된 종아, 그리고 그 툰드라 송어를 어서 잡아오너라, 빨리!";
					flag = true;
					text = "\n(툰드라 지표면에서 잡을 수 있습니다)";
				}
				break;
			case 2471:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "유니콘과 무지개는 정말 멋져! 어디에나 있어, 심지어 물 속에도 말야.";
					array[num2++] = "아냐, 진짜야, 신성한 땅 연못에서 내가 유니콘 물고기를 봤다니까!";
					array[num2++] = "네 일은 그걸 잡아서 내 애완동물로 만드는거야!";
					flag = true;
					text = "\n(신성한 땅에서 잡을 수 있습니다)";
				}
				break;
			case 2472:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "지하세계의 악마들은 부두인형을 정말 좋아해, 근데 그중 하나는 마법을 너무 많이 먹어서 펑 터져버린게 있어!";
					array[num2++] = "그게 물고기로 변해버렸어. 내려가서 하나 잡아와!";
					array[num2++] = "끓는 용암은 피해주길 바래, 분명히 널 태워버릴꺼고 난 내 물고기를 못받을거 같거든!";
					flag = true;
					text = "\n(동굴에서 잡을 수 있습니다)";
				}
				break;
			case 2473:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "나 너어어가 모르는거 하나 알아! 알았어, 얘기해줄게, 별들 속을 날아다니는 아주 무서운 생명채가 있어! 지어내는거 아냐!";
					array[num2++] = "와이번이라고 불리는 괴물이야! 그치만,그치만 이건 알고있었지, 그치? 글쎄 너가 모르는건 얘내가 원래 올챙이라는거야!";
					array[num2++] = "결국 걔들은 어.... 개구리 같은거야! 뛰어가서 잡아와!";
					flag = true;
					text = "\n(하늘 연못에서 잡을 수 있습니다)";
				}
				break;
			case 2474:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "너 내말을 안믿을껄? 밤에 물고기를 잡았는데, 죽은거였거든, 근데 날 먹으려 들었어! 그래서 난 도망쳣어!";
					array[num2++] = "지금은 그거 누군가의 옷장에 넣고 무슨일이 일어날지 보고 싶어, 날 위해서 다시 잡아올꺼지?!";
					flag = true;
					text = "\n(지표면에서 잡을 수 있습니다)";
				}
				break;
			case 2475:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "파란 나라를 보았니! 모든게 파랗던데! 버섯을 몇개 따다 보니 옆에 파란 연못이 있더라고, 내 뺨을 치고 도망간 버섯이 있는 연못 말야! 매를 번다고, 맛좀 보여주고 싶어 칼빵도 말야! 무슨 뜻이냐면 잡아오라고!";
					flag = true;
					text = "\n(발광버섯 지형에서 잡을 수 있습니다)";
				}
				break;
			case 2476:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "하늘에 마법의 섬이 있는거 알아? 몰랐을껄! 하늘엔 천사들이 산다는데, 난 그 천사들이 지느러미와 아가미가 있을꺼라고 믿어! 한마리 잡아와 줄거라는것도 믿고!";
					flag = true;
					text = "\n(하늘 연못에서 잡을 수 있습니다)";
				}
				break;
			case 2477:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "아우, 가까이 오지마! 피투성이 작은부레관해파리에게 쏘였어! 혹시 충분히 똑똑하지 않을까봐 애기해 주는건데," + Main.worldName + "에서 가장 위험한 해파리야! 할 수 있으면 그 썩은 피투성이 땅에서 잡아봐봐 ! ";
					flag = true;
					text = "\n(피투성이 땅에서 잡을 수 있습니다)";
				}
				break;
			case 2478:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "보통이라면 지하 연못에 떠있는 생선가시를 무시했겟지만, 내가 본건 헤엄치고 있었어! 왜, 사람 뼈만 " + Main.worldName + "에서 움직이는 줄 알았어? 누군가의 침대에 넣어보고 싶어, 잡아와!";
					flag = true;
					text = "\n(지하와 동굴에서 잡을 수 있습니다)";
				}
				break;
			case 2479:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "숲에 있었는데 낚시를 하고 있었거든? 무슨일이 일어났는지 알아? 토끼가 뛰어왔어! 또 한마리, 또한마리... 갑자기 토끼들한테 둘러싸인거야! 한마리는 수영해오더라고, 근데 다리가 없었어! 난 놀라서 의자에서 떨어졌고 토끼들은 총총거리며 도망갔어! 그래서 잡아 왔어면 좋겠어! 프로도!";
					flag = true;
					text = "\n(중간계 지표면에서 잡을 수 있습니다)";
				}
				break;
			case 2480:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "야알! 떨어라 나무꾼들! 비켜 겁쟁이들! 한 해적이 있었는데 애완용 물고기가 캡틴 참치수염이였데, 근데 폭풍우때 그만 도망쳣다지 뭐야! 꼬리로는 갈고리가 있고, 눈가리개도 있고 다 있어! 잡아와 나도 멋진 해적이 되게! 물론 바다 어딘가 있겟지!";
					flag = true;
					text = "\n(바다에서 잡을 수 있습니다)";
				}
				break;
			case 2481:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "밝은 주황색의 알락달록한 물고기를 바다에서 봤어, 꼭 잃어버린 가족을 찾아서 돌아다니는것 같더라고! 가서 잡아와, 그럼 다른 하나가 분명 나타날꺼야!";
					flag = true;
					text = "\n(니모를 찾아 바다로 가면 잡을 수 있습니다)";
				}
				break;
			case 2482:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "지하세계에서는 악마들의 왕은 사실 물고기래! 네가 한마리 잡아준다면 생길 내 절대적인 힘을 상상해봐!";
					flag = true;
					text = "\n(동굴에서 잡을 수 있습니다)";
				}
				break;
			case 2483:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "내가 본것중 더플링들은 가장 무서운 괴물이야! 좋은 소식은, 가끔은 걔들이 다리가 없다는거야! 걔내들은 물 속에 살고 덜 무서워! 반쯤 죽을만큼 무섭지 않으니 걔내들 맛 보고싶어!";
					flag = true;
					text = "\n(정글 지표면에서 잡을 수 있습니다)";
				}
				break;
			case 2484:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "전설의 존재 피시론을 알아? 한부분은 돼지고 한부분은 용이고 한부분은 물고기야! 아주 추운곳 지하에서 잡힌다는데! 난 안갈꺼야 그러니까, 잡아서 내 손에 가져다 줘! 정말 신나!";
					flag = true;
					text = "\n(툰드라 지하에서 잡을 수 있습니다)";
				}
				break;
			case 2485:
				if (gotFish)
				{
					array = array2;
				}
				else
				{
					array[num2++] = "긴 칼처럼 생긴 긴 물고기가 타락한 땅 흐린 물 속에 산대! 쟃빛 돌처럼 생겼지만 널 속이게 하지마! 어 맞어, 너 말야. 잡아오라고! 내가 잡을거 아냐";
					flag = true;
					text = "\n(타락한 땅에서 잡을 수 있습니다)";
				}
				break;
			case 2486:
				if (gotFish)
				{
					array = array2;
				}
=======
				text = " 학살 당했습니다.";
			}
			else if (num == 8)
			{
				text = " 찔려 죽었습니다.";
			}
			else if (num == 9)
			{
				text = " 반으로 쪼개졌습니다.";
			}
			else if (num == 10)
			{
				text = " 참수되었습니다.";
			}
			else if (num == 11)
			{
				text = " 팔이 날아가 버렸습니다.";
			}
			else if (num == 12)
			{
				text = " 자신의 몸이 찢어지는것을 지켜보았습니다.";
			}
			else if (num == 13)
			{
				text = " 잔인하게 해부되었습니다.";
			}
			else if (num == 14)
			{
				text = " 온 몸이 공중으로 흩날렸습니다.";
			}
			else if (num == 15)
			{
				text = " 몸을 난도질 당했습니다.";
			}
			else if (num == 16)
			{
				text = " 영 좋지 못한 곳을 맞아 죽어버렸습니다.";
			}
			else if (num == 17)
			{
				text = " 맛있는 고기(?)가 되었습니다.";
			}
			else if (num == 18)
			{
				text = " " + Main.worldName + "에서 손실되었습니다.";
			}
			else if (num == 19)
			{
				text = " 절반으로 쪼개졌습니다.";
			}
			else if (num == 20)
			{
				text = " 중앙을 기준으로 나누어졌습니다.";
			}
			else if (num == 21)
			{
				text = " 짓밟혔습니다.";
			}
			else if (num == 22)
			{
				text = " 죽음으로 답하였습니다.";
			}
			else if (num == 23)
			{
				text = " 벼와 쌀이 분리되었습니다.";
			}
			else if (num == 24)
			{
				text = " 처참하게 당해 결국엔 차갑게 식어버렸습니다.";
			}
			else if (num == 25)
			{
				text = " 머리를 찾지 못하게 되었습니다.";
			}

			if (plr >= 0 && plr < 255)
			{
				if (proj >= 0 && Main.projectile[proj].name != "")
					result = krEnd.End(Main.player[Main.myPlayer].name, 0) + " " + Main.player[plr].name + "의 " + projectileName(proj) + krEnd.End(projectileName(proj), 3) + text;
>>>>>>> origin/master
				else
					result = krEnd.End(Main.player[Main.myPlayer].name, 0) + " " + Main.player[plr].name + "의 " + Main.player[plr].inventory[Main.player[plr].selectedItem].name + krEnd.End(Main.player[plr].inventory[Main.player[plr].selectedItem].name, 3) + text;

			}
			else if (npc >= 0 && Main.npc[npc].displayName != "")
			{
				result = krEnd.End(Main.player[Main.myPlayer].name, 0) + " " + Main.npc[npc].displayName + "에게" + text;
			}
			else if (proj >= 0 && Main.projectile[proj].name != "")
			{
				result = krEnd.End(Main.player[Main.myPlayer].name, 0) + " " + projectileName(proj) + "에 의해서" + text;
			}
			else if (other >= 0)
			{
				if (other == 0)
				{
<<<<<<< HEAD
					array[num2++] = "정글 연못을 다닐때는 조심해! 왜냐고? 아냐, 피라냐한테 물리는건 상관없는데. 내가 좋아하는 물고기를 밟는게 싫어, 진흙물고기말야! 하나 잡아서 애완용으로 하면 상관이 있고!";
					flag = true;
					text = "\n(정글에서 잡을 수 있습니다)";
=======
					if (Main.rand.Next(2) == 0)
					{
						result = krEnd.End(Main.player[Main.myPlayer].name, 0) + " 높이를 생각하지 못하고 뛰어내렸습니다.";
					}
					else
					{
						result = krEnd.End(Main.player[Main.myPlayer].name, 0) + " 튀어오를 수 없었습니다.";
					}
>>>>>>> origin/master
				}
				else if (other == 1)
				{
					int num2 = Main.rand.Next(4);
					if (num2 == 0)
					{
						result = krEnd.End(Main.player[Main.myPlayer].name, 0) + " 숨쉬는 것을 잊어버렸습니다.";
					}
					else if (num2 == 1)
					{
						result = krEnd.End(Main.player[Main.myPlayer].name, 0) + " 물고기와 함께 편안히 잠들었습니다.";
					}
					else if (num2 == 2)
					{
						result = krEnd.End(Main.player[Main.myPlayer].name, 0) + " 물에서 헤엄쳐나올 수 없었습니다.";
					}
					else if (num2 == 3)
					{
						result = krEnd.End(Main.player[Main.myPlayer].name, 0) + " 상어밥이 되었습니다.";
					}
				}
				else if (other == 2)
				{
<<<<<<< HEAD
					array[num2++] = "숲속의 슬라임은 징그러워. 슬라임물고기는 더욱 그렇고! 슬라임이랑 수영하기 싫어, 잡아 꺼내!";
					flag = true;
					text = "\n(어디에서든 잡을 수 있습니다)";
=======
					int num3 = Main.rand.Next(4);
					if (num3 == 0)
					{
						result = krEnd.End(Main.player[Main.myPlayer].name, 0) + " 녹아버렸습니다.";
					}
					else if (num3 == 1)
					{
						result = krEnd.End(Main.player[Main.myPlayer].name, 0) + " 소각되어 버렸습니다.";
					}
					else if (num3 == 2)
					{
						result = krEnd.End(Main.player[Main.myPlayer].name, 0) + " 용암에서 헤엄치려 시도했습니다.";
					}
					else if (num3 == 3)
					{
						result = krEnd.End(Main.player[Main.myPlayer].name, 0) + " 용암에서 노는 것을 즐겼습니다.";
					}
>>>>>>> origin/master
				}
				else if (other == 3)
				{
					result = krEnd.End(Main.player[Main.myPlayer].name, 0) + text + ".";
				}
				else if (other == 4)
				{
<<<<<<< HEAD
					array[num2++] = "피라냐와 상어들은 못생겼어! 너어어어무 못생겼어! 예쁘게 생겼고 네 얼굴을 뜯어먹을 수 있는 물고기가 있는거 알아? 그게 정말 일어난다면 백금화 2개를 줘서라도 볼텐... 어쨋든 잡아와! 네 얼굴을 잃기 전에 나한테 보여주는것도 잊지 말고 말야!";
					flag = true;
					text = "\n(정글 지표면에서 잡을 수 있습니다)";
=======
					result = krEnd.End(Main.player[Main.myPlayer].name, 0) + " 죽어버렸시맛타.";
>>>>>>> origin/master
				}
			}

			return result;
		}

		public static string AnglerQuestChat(bool gotFish = false)
		{
			NPC.firstNPCName(18);
			NPC.firstNPCName(17);
			NPC.firstNPCName(19);
			NPC.firstNPCName(20);
			NPC.firstNPCName(38);
			NPC.firstNPCName(54);
			NPC.firstNPCName(22);
			NPC.firstNPCName(108);
			NPC.firstNPCName(107);
			NPC.firstNPCName(124);
			NPC.firstNPCName(160);
			NPC.firstNPCName(178);
			NPC.firstNPCName(207);
			NPC.firstNPCName(208);
			NPC.firstNPCName(209);
			NPC.firstNPCName(227);
			NPC.firstNPCName(228);
			NPC.firstNPCName(229);
			NPC.firstNPCName(353);
			NPC.firstNPCName(368);
			int num = 8;
			int num2 = 0;
			string str = NPC.firstNPCName(369);
			string[] array = new string[num];
			string[] array2 = new string[num];
			string text = "";
			bool flag = false;

			array[0] = "";

			if (gotFish)
			{
				switch (Main.rand.Next(5))
				{
<<<<<<< HEAD
					"살판났군. 저 ",
					text5,
					" 이랑 ",
					text,
					" 이가 싸우는 소리가 여기까지 들리는구만."
				});
			case 14:
				result += "자네 혹시 그걸 본적이 있나?  키툴...시툴.. 채ㅌ...아 아니 그 큰 눈을 말야.";
			case 15:
				result += "어이, 이 집은 안전한거지? 그치? " + Main.player[Main.myPlayer].name + "?";
			case 16:
				result += "혈월도 자본주의를 막지는 못하지! 자 거래를 하자.";
			case 17:
				result += "상품에서 눈을 때지 말게, 렌즈도 사고 말야!";
			case 18:
				result += "코시, 케플렉 모그. 아 미안하네, 방금 그건 클링곤어로 '뭔가 사거나 죽게.' 라는 뜻이야.";
			case 19:
				result += Main.player[Main.myPlayer].name + " 맞지? 자네 이야길 많이 들었어, 친구!";
			case 20:
				result += "숨겨진 보물이 있다던데... 아, 신경쓰지 말게.";
			case 21:
				result += "천사상? 미안하게 됬군, 난 고물상인이 아니거든.";
			case 22:
				result += "자네 전의 사람은 나에게 쓰레ㄱ... 어 그러니까... 귀중품을 팔고 갔지!";
			case 23:
				result += "정말 궁금하군. 달은 치즈로 만들어진걸까?... 어, 뭐라고? 그래 맞아, 물건들좀 보게나!";
			case 24:
				result += "방금 금이라고 했나?  자네에게서 뜯어내고 말겠네 .";
			case 25:
				result += "워우, 저한테 피를 흘리진 마세요.";
			case 26:
				result += "서둘러요, 피좀 그만 흘리구요.";
			case 27:
				result += "죽을거 같으면... 밖에서 죽어요.";
			case 28:
				result += "도데체 그게 무슨 꿍꿍이신 거죠?!";
			case 29:
				result += "당신의 그 말투... 반갑지가 않군요.";
			case 30:
				result += "도데체 여긴 왜 온거에요? 피 흘리는게 아니라면, 여기 있을 필요는 없어요. 나가요.";
			case 31:
				result += "뭐라구요?!";
			case 32:
				result += "던젼 주변의 노인을 본적이 있어요? 불안해 하는 것 같던데.";
			case 33:
				result += "제발 " + str2 + " 님이 좀더 조심스러웠으면 해요. 그 사람 팔을 다시 붙이는것도 지긋지긋해요.";
			case 34:
				result += "저기요, 혹시 " + text2 + " 님이 어떤 이유든 간에 의사가 필요하다 한적 없나요? 그냥 궁금해서요.";
			case 35:
				result += "정말 " + str4 + " 님과 심각한 대화가 필요해요. 이번주만 해도 심각한 용암 화상으로 온게 몇번짼데요?";
			case 36:
				result += "이쪽이 더 나아 보이는군요.";
			case 37:
				result += "으으.... 당신 얼굴에 무슨일이 일어난 거에요?";
			case 38:
				result += "꺄아아아! 나...난 괜찮아요, 근데 당신처럼 괜찮진 않아요...";
			case 39:
				result += "이자리에 우린 지난 친구들에게 마지막 작고를 하기 위하여 모였어요... 어 안녕하세요? 괜찮아요. 당신은 좋아질꺼에요.";
			case 40:
				result += "저기, 팔을 나두고 갔던데요. 잠시만요...";
			case 41:
				result += "애처럼 굴지좀 말아요! 난 더한것도 봤어요.";
			case 42:
				result += "그건 꿰매야 겠는데요!";
			case 43:
				result += "또 그 나쁜 놈들이랑 어울렸나요?";
			case 44:
				result += "잠시만요, 뽀로로 반창고좀 찾아 올게요...";
			case 45:
				result += "남자답게 행동좀 해요, " + Main.player[Main.myPlayer].name + ", 괜찮아 질거에요... 어휴.";
			case 46:
				result += "그곳을 누르면 아픈가요? 그럼 누르질 마요.";
			case 47:
				result += "당신... 반쯤 소화된것 같아요. 슬라임들을 잡으러 다녔나요?";
			case 48:
				result += "제채기는 머리를 돌리고 해요.";
			case 49:
				result += "그 큰 상처는 제가 본것에 비하면 별거 아니에요... 맞아요, 더 큰것도 봤어요. 확실해요.";
			case 50:
				result += "사탕이라도 드릴까요?";
			case 51:
				result += "어디가 아픈지 보여주세요.";
			case 52:
				result += "죄송하지만, 절 고용하기엔...";
			case 53:
				result += "그것보단 돈이 더 필요해요.";
			case 54:
				result += "전 의료봉사원이 아니에요. 모르실까봐.";
			case 55:
				result += "전 행복한 결말따위 좋아하지 않아요.";
			case 56:
				result += "더이상은 안돼요. 성형이라면 모를까.";
			case 57:
				result += "제 시간좀 뺏지 말아요.";
			case 58:
				result += "인형중에 " + str4 + " 녀석과 비슷한 인형이 지하 어딘가 있다더라고. 	그속에다 몇발 쏴 보고 싶군.";
			case 59:
				result += "빨리좀 해! " + text + " 간호사와 데이트 약속이 있단 말야.";
			case 60:
				result += "난 그 간호사, " + text + " 의 상품을 구매하고 싶군... 뭐? 그녀는 파는 상품이 없다고?";
			case 61:
				result += text3 + "? 그녀는 정말 매력적이야!  내숭쟁이라는게 정말 아쉽군.";
			case 62:
				result += str2 + " 녀석이랑은 어울리지도 마. 너한테 필요한건 내가 다 가지고 있어.";
			case 63:
				result += "도데체 " + str2 + " 저놈은 뭐하는 거야? 우리가 서로 다른 물건을 취급하는건 알고는 있는거야??";
			case 64:
				result += "누구랑도 얘기하기 싫은 밤이군. 안그래 " + Main.player[Main.myPlayer].name + "?";
			case 65:
				result += "오늘같은 밤이 좋아.	죽이고 싶은게 모자라지 않거든!";
			case 66:
				result += "이 미니샤크가 그렇게 궁금해?.. 어떻게 만들어졌는진 알고싶지 않을껄?.";
			case 67:
				result += "야 이거 영화 아냐. 탄약은 따로라고.";
			case 68:
				result += "내 물건에서 손때 , 이놈아!";
			case 69:
				result += "혹시 타락한 땅 흑단석에 정화의 가루를  뿌려보셨나요?";
			case 70:
				result += "제발 " + text2 + KRTracker.End(text2, "이가") + " 그만 집적대면 좋겠어요. 내가 500살이 넘었다는건 모르나 보죠?";
			case 71:
				result += "왜 자꾸 " + str + KRTracker.End(str, "이가") + " 나에게 천사상을 팔려는 건가요? 쓸모가 없다는건 모두가 아는 사실인데.";
			case 72:
				result += "던전 근처를 돌아다니는 노인을 보셨나요? 건강이 별로 좋아보이지 않던데...";
			case 73:
				result += "전 팔고싶은 것만 팔아요! 맘에 안드신다면, 안됐네요.";
			case 74:
				result += "왜 하필 이럴때에 대립적이신거죠?";
			case 75:
				result += "저는 당신이 제 물건을 사는걸 바라지 않아요. 당신이 내 물건을 사고 싶어하는걸 바랄 뿐이죠. ";
			case 76:
				result += "저기요, 그냥 기분탓인가요 아님 밖에 좀비가 엄청나게 많은건가요?";
			case 77:
				result += "당신은 타락한 이 세계를 정화해야만 해요.";
			case 78:
				result += "조심하세요! 테라리아는 당신을 필요로 해요!";
			case 79:
				result += "시간의 모래는 흐르고 있어요. 그리고 당신은 나이를 꼴사납게 먹는군요.";
			case 80:
				result += "제가 걱정했던것 만큼 그리 '나쁘지' 않다구요 무슨뜻이에요?";
			case 81:
				result += "두 고블린이 바에 들어갔는데, 한 고블린이 뭐라고 했는질 알아요? '맥주 고블릿으로 한잔 어때?!"; //말장난 '고블린'과 '고블릿'(유리잔) 의 발음이 비슷한 말장난
			case 82:
				result += "내 저주를 풀어주지 않는다면 던전에 들여보내주지 않을꺼요.";
			case 83:
				result += "들어가고 싶다면, 밤에 다시 오시오.";
			case 84:
				result += "내 마스터는 낮의 빛 아래 소환될 수 없소.";
			case 85:
				result += "당신은 내 저주를 풀어주기엔 너무 약하군.	 쓸모가 있어지면 다시 오시오.";
			case 86:
				result += "불쌍한 바보여.  당신이 내 주인을 상대하기엔 희망조차도 못한다오.";
			case 87:
				result += "당신과 실력이 비슷한 사람이 여섯명만 더 있다면 좋겠지만, 당신 혼자인것 같아 보이는군.";
			case 88:
				result += "제발, 하지 마시오 낮선 이여. 당신을 죽이는 일만 될 뿐이라오.";
			case 89:
				result += "당신은 내 저주를 풀어주기에 충분하게 보이는군...";
			case 90:
				result += "낮선 이여, 당신은 내 마스터를 상대할 힘을 소유하고 있소?";
			case 91:
				result += "제발! 내 포획자를 상대하고 날 자유케 해 주시오! 이렇게 빌겠소!";
			case 92:
				result += "내 마스터와 싸워 이긴다면 던전으로 가는 길을 열어주겠소.";
			case 93:
				result += "까만 돌을 뚫고 싶다고, 에?  이 폭발물을 그 돌들에게 소개시켜주는건 어때!";
			case 94:
				result += "혹시 주변에서 광대를 본적이 있어?";
			case 95:
				result += "분명 폭탄을 여기 어디 두었는데, 도데체 찾을 수가 없네...";
			case 96:
				result += "좀비들을 상대할 만한 좋은게 있지!";
			case 97:
				result += text2 + "마저도 내 물건들을 사고싶어 한다고";
			case 98:
				result += "총알이 낫겠어 아님 폭탄이 낫겠어? 그냥 그렇다고.";
			case 99:
				result += "분명" + text + " 간호사가 팔을 붙이는데 도와줄꺼야. 이녀석들한테 당한다면 말야.";
			case 100:
				result += "그냥 날려버리면 되는데 정화를 할 필요가 있을까?";
			case 101:
				result += "이걸 욕조에 넣고 모든 창문을 닫아봐. 당신 코는 물론이고 귀까지 뚫어버릴껄!";
			case 102:
				result += "닭폭탄놀이 어때?";
			case 103:
				result += "저기, 여기에 서명좀 해주겠어? 테러 포기각서 말야";
			case 104:
				result += "담배는 나가서 펴!!";
			case 105:
				result += "폭탄의 인기가 폭발적이라고! .	너도 어서 하나 사!";
			case 106:
				result += "삶을 마감하기 좋은 날이로다!";
			case 107:
				result += "만약 이걸 이렇게 한다면... (펑)... 어이쿠, 미안, 혹시 그 다리가 필요해?";
			case 108:
				result += "다이너마이트, 내 특효약이지, 어떤 고통에도 잘 들어.";
			case 109:
				result += "내 물건들좀 봐줘; 폭탄 세일중이야!";
			case 110:
				result += "희미안 기억이지만 한 소자를 묶어 던전 속으로 던진 기억이 자꾸만 나";
			case 111:
				result += "... 문제가 생겼소, 밖에 혈월이!";
			case 112:
				result += "만약 내가 젊었다면" + text + " 간호사를 불러냈을텐데... 소싯적엔 꾀나 여자를 부렸거든.";
			case 113:
				result += "어! 그 빨간 모자 어디서 본거 같은데";
			case 114:
				result += "다시한번 저주를 풀어준데 의해 감사를 표하지. 꼭 뭔가 뛰어오르며 날 물어뜯는 느낌이였거든.";
			case 115:
				result += "어머니께선 항상 내가 좋은 양복을 만들거라고 했지 .";
			case 116:
				result += "삶은 마치 옷이 가득한 상자와 같아; 뭘 입게 될지 모르지!";
			case 117:
				result += "물론 자수를 놓는건 힘들지! 만약 어렵지 않았다면, 누구도 하지 않았을꺼야! 그게 바로 자수가 멋진 이유지.";
			case 118:
				result += "난 의복 사업이라면 모든것을 꽤고 있지.";
			case 119:
				result += "저주받았을땐 외로웠어, 그래서 가죽으로 친구를 만들었지. 그 친구 이름은 윌슨이야.";
			case 120:
				result += "풀어줘서 고마워 인간. 다른 고블린들에 의해 여기 묶여 버려졌었어.	사이가 안 좋았다고 볼 수 있어.";
			case 121:
				result += "고블린들이 동쪽으로 가고 있지 않다는걸 지적한 이유로 날 여기 버리고 갔다는걸 정말 믿을수가 없어!";
			case 122:
				result += "난 이제 왕따니까, 가시공좀 버려도 되지? 주머니쪽이 아파.";
			case 123:
				result += "도구 전문자를 찾고 있어? 난 너의 고블린이야!";
			case 124:
				result += "도와줘서 고마워. 이제, 하릴없이 이곳을 돌아다녀야겠군. 언젠가 또 만나게 될꺼야.";
			case 125:
				result += "난 너가 키가 더 클줄 알았는데.";
			case 126:
				result += "저기...지금 혹시 " + text5 + KRTracker.End(text5, "은는") + "뭐해? 말...말 나눠 본적 있어? 우연이라도?";
			case 127:
				result += "혹시 너의 모자에 모터가 필요하지 않아? 그 모자에 꼭 맞는 모터를 가지고 있는것 같은데.";
			case 128:
				result += "요, 너 로켓과 운동화를 좋아한다 들엇어,  그래서 로켓을 운동화 속에 넣었지.";
			case 129:
				result += "침묵은 금이야. 덕트 테이프는 은이고.";
			case 130:
				result += "그래 , 금이 철보다 강한지.  도데체 요즘 인간들은 뭘 배우는지.";
			case 131:
				result += "근데말야, 그 채광용-오리발 조합은 종이에서나 좋은 아이디어였어.";
			case 132:
				result += "고블린들은 쉽게 분노를 표하지. 사실, 옷때문에 전쟁이 일어나기도 해!";
			case 133:
				result += "솔직히 모든 고블린들이 로켓 연구가는 아냐. 글쌔, 몇명은.";
			case 134:
				result += "왜 우리가 이 가시공들을 들고 다니는지 알아? 내가 안들고 다니거든.";
			case 135:
				result += "방금 신상품을 개발했지! 이번꺼는 숨을 깊게 쉰다고 격렬하게 터지진 않을꺼야.";
			case 136:
				result += "고블린 도적들은 사실 자기 일을 제데로 하지도 못해. 잠겨있지 않은 창고에서 물건을 훔치지도 못하거든!";
			case 137:
				result += "살려줘서 고맙소 친구!  이 결박이 쓸리기 시작했거든.";
			case 138:
				result += "오! 나의 영웅!";
			case 139:
				result += "정말 영웅적이군! 살려줘서 고맙소, 젊은 아가씨!";
			case 140:
				result += "정말 영웅적이군! 살려줘서 고맙소, 젊은이!";
			case 141:
				result += "이제 서로 알았으니, 나도 너와 함께 살아도 되겠소?";
			case 142:
				result += "오, 안녕하신가, " + str4 + "! 오늘은 무엇을 도와드리면 좋겠소?";
			case 143:
				result += "오, 안녕하신가, " + str2 + "! 오늘은 무엇을 도와드리면 좋겠소?";
			case 144:
				result += "오, 안녕하신가, " + text4 + "! 오늘은 무엇을 도와드리면 좋겠소?";
			case 145:
				result += "오, 안녕하신가, " + text + "! 오늘은 무엇을 도와드리면 좋겠소?";
			case 146:
				result += "오, 안녕하신가, " + text5 + "! 오늘은 무엇을 도와드리면 좋겠소?";
			case 147:
				result += "오, 안녕하신가, " + text3 + "! 오늘은 무엇을 도와드리면 좋겠소?";
			case 148:
				result += "귀 뒤에서 동전 꺼내는 마술 보여줄까? 싫소? 알았소.";
			case 149:
				result += "혹시 마법 사탕은 어떻소? 싫소? 알았소.";
			case 150:
				result += "핫초코를 인챈팅 하는건 어떻...싫소? 알았소.";
			case 151:
				result += "내 수정구를 훔쳐보려고 왔소?";
			case 152:
				result += "혹시 돌을 슬라임으로 바꾸는 인챈트 반지를 가지고 싶은적이 있소? 글쎄, 나도 싫소.";
			case 153:
				result += "누군가 말하더군 우정은 마법이라고. 그렇게 멍청한 말이 또 어딨겠소? 우정으로는 사람들을 개구리로 만들수 없잖소.";
			case 154:
				result += "자네의 미래가 보이는군... 나에게서 많은 아이템을 살 것이란걸 말이오!";
			case 155:
				result += "천사상에게 생명을 불어넣는 시도도 해봣지. 아무일도 안일어나더군.";
			case 156:
				result += "고마워요!	이곳 스켈레톤처럼 끝나는건 시간문제였거든요.";
			case 157:
				result += "길좀 보고 다녀욧! 계속 빙빙 돌기만 하잖아요!";
			case 158:
				result += "잠깐만요, 분명 어디서 와이파이 신호가 잡혔는데...";
			case 159:
				result += "그...그치만 조금만 더하면 반짝전구를 달았는데!";
			case 160:
				result += "꼼짝마요! 컨택트렌즈를 떨어뜨렸어요.";
			case 161:
				result += "전 그저 스위치로...흐흐...... 뭐!";
			case 162:
				result += "제가 하나 맞춰볼까요? 전선을 충분히 안샀죠? 멍청이.";
			case 163:
				result += "그냥... 그냥 좀... 네? 오케이? 오케이. 어휴.";
			case 164:
				result += "그런 눈으로 보지마요. 지금 '일'하잖아요!.";
			case 165:
				result += string.Concat(new string[]
				{
					"저기, ",
					Main.player[Main.myPlayer].name,
					", 혹시  ",
					text4,
					"'의 집에서 오는 길인가요? 그가 우연히라도 제 말을 하던가요?"
				});
			case 166:
				result += text2 + " 님이 자꾸 갑압판이 누르는게 아니냐고 물어봐요. 밟는거라도 그렇게 말을 해도...";
			case 167:
				result += "필요한 전선보다 더 많이 준비해가요!";
			case 168:
				result += "혹시 제품의 플러그를 꼽은걸 확인했나요?";
			case 169:
				result += "혹시 이 집이 더 필요한게 뭔지 알아요? 반짝전구말이에요.";
			case 170:
				result += "하늘이 빨갛다면 혈월이라는 뜻이죠. 무언가가 괴물들을 모여들게 하고 있어요.";
			case 171:
				result += "저기 친구. 사망초를 어디서 구하는지 알아요? 아뇨? 이유는 없어요; 그냥 궁금해서, 그게 전부에요.";
			case 172:
				result += "하늘을 봐봐요, 하늘을 보면 달이 빨간걸 알 수 있죠.";
			case 173:
				result += "밤에는 실내에 있는게 좋아요. 어둠속에선 밖을 돌아다니는게 위험해요.";
			case 174:
				result += "안녕하세요, " + Main.player[Main.myPlayer].name + "님. 어떻게 도와드릴까요?";
			case 175:
				result += "전 앞으로 뭘 해야할지 충고를 줄꺼에요.	 뭔가 막힌다면 저와 대화하는걸 추천하죠.";
			case 176:
				result += "당신이 살아남도록 도와주는 사람이 어딘가 있다던데... 아 잠깐만. 저 말이였네요.";
			case 177:
				result += "곡괭이를 사용하면 땅을 팔 수 있고, 도끼로는 나무를 팰 수 있죠. 마우스 커서를 블럭 위에 두고 클릭하시기만 하면 되요!";
			case 178:
				result += "살아남고 싶다면, 무기와 집을 만드는것이 좋아요. 나무를 베어 원목을 모으는 것부터 시작하세요.";
			case 179:
				result += "키보드에서 [" + Main.cInv + "] 를 눌러 조합창에 들어가봐요. 나무가 충분하다면, 작업대를 만들어요. 작업대에서 가까이에만 있다면 더 복잡한것도 만들 수 있어요.";
			case 180:
				result += "나무나 어떤 블럭으로도 집을 지을 수 있지요. 아참, 벽을 조합하여 설치하는것도 잊지 마세요,";
			case 181:
				result += "목검을 만들었다면, 슬라임들에게서 젤을 모아보세요. 나무와 합하여 횃불을 만들 수 있답니다!";
			case 182:
				result += "배경을 바꾸고 싶다면 망치를 사용해보세요!";
			case 183:
				result += "채광을 통해 금속 광석을 얻어야 해요. 그걸로 쓸모있는 것들을 만들 수 있지요.";
			case 184:
				result += "광석이 조금 있으니, 금속괴로 만들어야해요. 이 작업은 화로를 필요로 하지요!";
			case 185:
				result += "화로를 만드려면 횃불, 돌 그리고 나무가 많이 필요해요. 작업대 근처에 서는걸 까먹지 마시구요";
			case 186:
				result += "금속괴로 무언가 만드려면 모루가 필요해요.";
			case 187:
				result += "모루는 철로 만들거나, 상인에게서 구입이 가능해요.";
			case 188:
				result += "지하에 있는 생명의 결정은 생명력을 늘릴때 써요. 곡괭이로 캐낼 수 있지요.";
			case 189:
				result += "별을 세개 모으면, 마법 수용력을 늘릴 수 있는 아이템을 만들 수 있답니다.";
			case 190:
				result += "밤에는 별이 어디든 떨어지지요. 그것들론 유용한 것들을 만들 수 있어요. 해가 뜨면 사라지니 그 전에 모으세요.";
			case 191:
				result += "많은 방법으로 당신의 마을에 사람들을 불러모을 수 있어요. 물론 그들이 살 집이 필요하구요.";
			case 192:
				result += "집을 만드려면 문, 탁자, 의자와 광원이 필요해요. 벽을 나두는것도 잊지 말구요";
			case 193:
				result += "한 집에는 두사람이 살 수 없어요. 또한, 집이 파괴되면, 다른 집을 찾아 이동하지요.";
			case 194:
				result += "집 인터페이스를 사용해 주거지를 보고 변경할 수 있어요. 인벤토리를 열어 집 아이콘을 클릭해 보세요.";
			case 195:
				result += "돈이 아주 많으면 상인이 찾아올 거에요. 50 은전이면 될꺼에요!";
			case 196:
				result += "최대 생명력을 늘리면 간호사가 찾아올 거에요.";
			case 197:
				result += "내가 장담하건데, 총을 소지하면 무기상이 찾아올 거에요!";
			case 198:
				result += "강력한 괴물을 죽여 당신의 힘을 증명해 보세요. 숲의 요정의 관심을 끌꺼에요";
			case 199:
				result += "던전을 철저히 탐험해보세요. 깊은곳에 사람이 있을지도 몰라요!.";
			case 200:
				result += "아마 던전 근처에 있는 노인은 저주가 풀리면 우리를 찾아올 지도 몰라요.";
			case 201:
				result += "폭발물을 찾았다면 조금만 기다려보세요.폭탄상인이 한번 보고 싶어 할꺼에요.";
			case 202:
				result += "정말 고블린들은 우리와 달라서 같이 평화롭게 살 수 없나요?";
			case 203:
				result += "마법사가 이 세상 어디에 산다던데... 다음번에 지하에 가면 꼭 찾아보세요.";
			case 204:
				result += "악마의 제단에서 렌즈를 조합해 보세요, 강력한 괴물을 소환할 있는 아이템을 만들 수 있을거에요. 소환하려면 밤까지 기다려야 하지만요";
			case 205:
				result += "썩은 덩어리와 역겨운 가루를 조합하면 벌레 먹이를 만들 수 있어요. 쓰기전에 타락 지역에 있는지 확인하세요.";
			case 206:
				result += "악마의 제단은 타락 지역에서 흔히 볼 수 있어요. 어떤 아이템들은 조합할 때 그 제단 근처에 있어야해요.";
			case 207:
				result += "갈고리는 쇠사슬 3개와 갈고랑쇠로 만들 수 있지요. 보통은 지하에 있는 스켈레톤에게서 강고랑쇠 구할 수 있고, 철괴로 사슬을 만들 수 있지요.";
			case 208:
				result += "항아리가 보인다면 깨 보세요. 유용한 물건들이 많이 들어 있어요.";
			case 209:
				result += "이 세상 곳곳에 보물이 숨겨진거 알아요? 지하 깊숙한 곳엔 멋진것도 있지요!";
			case 210:
				result += "그림자 보주를 깨는 일은 유성을 떨어지게도 해요. 그림자 보주는 보통 타락한 땅 지하에서 발견되요 .";
			case 211:
				result += "지금은 생명의 결정을 모아 최대 생명력을 늘리는데 집중해야해요.";
			case 212:
				result += "지금 장비하고 있는 방어구는 소용이 없어요. 더 좋은 방어구를 만들어야 해요.";
			case 213:
				result += "당신은 이제 첫번째 큰 전투에 준비가 된 것 같아요. 밤이 오면 눈알으로부터 렌즈를 모아 악마의 제단으로 가져가보세요 .";
			case 214:
				result += "다음 도전을 위해서는 생명력이 더 필요해요. 하트 열 다섯개면 충분할 것 같아요.";
			case 215:
				result += "타락 지역에 있는 까만 돌은 숲의 요정한테서 산 가루로 정화시킬 수 있어요, 또는 폭발물로 부술 수 있구요.";
			case 216:
				result += "타락한 땅을 탐엄 하는게 다음 단계에요.	그림자 보주를 찾으면 부셔버리세요.";
			case 217:
				result += "여기서 멀지 않은 곳에 오래된 던전이 하나 있어요. 지금 그걸 확인하는것이 좋은 타이밍 인것 같네요.";
			case 218:
				result += "이제 남은 생명력을 마저 채워보시는건 어떤가요? 하트 20개를 모아봐요.";
			case 219:
				result += "아직 미발견된 보물이 정글 속에 많이 있어요, 충분히 깊게 파야 하지만요.";
			case 220:
				result += "지하세계는 지옥석이라는 물질로 만들어져 있지요. 방어구와 무기를 만드는데 딱이랍니다.";
			case 221:
				result += "지하세계의 수호자를 상대할 준비가 되면, 살아있는 제물을 희생시켜야해요. 필요한 모든것은 지하세계에 있답니다.";
			case 222:
				result += "악마의 제단을 찾아 부수세요. 무엇인가 좋은일이 일어날꺼에요!";
			case 223:
				result += "어떨때는 극에 달한 빛과 어둠이 있는곳에 타락한 생물이 영혼을 떨어뜨리기도 한답니다.";
			case 224:
				result += "호 호 호, 그리고 한 병의... 에그노그!";
			case 225:
				result += "쿠키는 안 구워 왔나?";
			case 226:
				result += "뭐라고? 내가 진짜가 아닌줄 알았다고?";
			case 227:
				result += "어떻게든 얼굴을 되돌려 놨어요. 다음엔 제발 조심히 좀 해요.";
			case 228:
				result += "아무래도 흉터가 남겠어요.";
			case 229:
				result += "다 나아졌어요. 이제 절벽에서 뛰어내리는 짓은 보고싶지 않네요.";
			case 230:
				result += "그렇게 안 아팠죠, 아팠나요?";
			case 231:
				result += "땅 속에서 사는건 그렇게 나쁘지 안았버섯, 너 같은 바보들이 내 아이들을 대려가는것만 빼면 말이버섯.";
			case 232:
				result += "우리 둘 사이에 말인버섯, " + text3 + " 요정이 내가 믿는 유일한 친구버섯. 걔만 날 먹으려들거나 포션으로 만들지 않았버섯.";
			case 233:
				result += "도데체 뭐가 대수인지 알기 위해 내 몸을 햝아보기도 했버섯, 근데 모든게 파란빛으로 빛나기 시작했버섯.";
			case 234:
				result += "파란걸 볼때마다버섯, 날 우울하게 만들고 게으르게 만들버섯.";
			case 235:
				result += "이 근처에서 돼지를 본 적이 없버섯? 내 동생은 다리 하나를 그들한테 잃엇버섯.";
			case 236:
				result += "이 마을의 모든 사람은 조금씩 이상버섯. 어젯밤에 깨보니 옷상인이 내 발을 먹고있었버섯.";
			case 237:
				result += "젊은이 옷에는 할인을 부과하겠소, 만약 젊은이가 " + str5 + KRTracker.End(text5, "을를") + " 설득해서....치수! 치수를 재러 오게 만들면 말이오";
			case 238:
				result += "아마 " + str5 + " 님이 오해를 받는것 같아요, 참 재미있게 발효된 분이었는데."; //원문은 'fun guy'(재밋는 친구)는 'fungi'(곰팡이류)와 발음이 비슷함을 이용한 말장난
			case 240:
				result += "트러플 셔플'같은건 모른다버섯! 그만좀 물어봐버섯!";
			case 241:
				result += "나에 관한 큰 소문이 돌고있버섯, '그를 이기지 못한다면, 먹어버려!'라고 말버섯";
			case 242:
				result += "어머나, 도데체 너 속엔 뭐가 든거야?"; // Oy, whatchu got in you jiminy fluffer?
			case 243:
				result += "하이재커가 됬어야 할까? 고민 많이 했었는데.";
			case 244:
				result += "개의치 말고, 너한텐 제트팩이 잘 어울리겠는데!"; //뭐라는거야... ("Be it what it would, a jetpack would suit you nicely!")
			case 245:
				result += "늦어서 짜증이 조금 나, 네 괜한 법석을 받아줄 정도는 안돼!";
			case 246:
				result += "난 저 로봇 자식이 정말 궁금해, " + str6 + " 말야. 도데체 어떤 동력으로 움직이는거야?";
			case 247:
				result += "저 선장은 '부두에서 잘 나가는 '사람 같아. 뭔 말인지 알겠어?";
			case 248:
				result += "내게 톱니바퀴를 보여줘...!";
			case 249:
				result += "나는 너의 ... 톱니바퀴가 좋아. 놋쇠 제품이야?";
			case 250:
				result += "신성한 땅에 들어가면 하늘에 무지개가 있는걸 볼 수 있어. 그걸 색칠하고 싶으면 도와줄 수 있어.";
			case 251:
				result += "저 아이," + text6 + " 말야. 저 아이라면 마을을 온통 빨간색으로 칠할꺼야!";
			case 252:
				result += "난 터키옥 색이랑 청록색의 차이르 알아. 그렇지만 안알려줄꺼야.";
			case 253:
				result += "타이타늄 화이트는 다 나가고 없으니, 묻지를 말어.";
			case 254:
				result += "분홍색과 보라색의 스월리 디자인은 어때? 멩세하건데 이뻐!";
			case 255:
				result += "아냐아냐아냐... 회색이란게 얼마나 많은데! 말하게 하지마...";
			case 256:
				result += "페인트가 마르기 전에 비가 내리지 않았으면 좋겠어. 그건 재앙이나 마찬가지야!";
			case 257:
				result += "재무를 가져온다면 가장 화려한 색을 가져오지!";
			case 258:
				result += "어휴, 그리 칙칙한 옷을 입고 다니다니. 옷을 염색하는 법을 배워야겠어!";
			case 259:
				result += "나무를 염색하려면 난 마호가니 나무만 할꺼야. 다른 나무는 그냥 낭비거든.";
			case 260:
				result +=  str7 + "한테 무슨 말좀 해봐요.  여기 왔다 갈때마다 냄새를 빼는데 일주일이나 걸린다구요";
			case 261:
				result += "무슨 마술사냐고? 난 주술사야."; // which doctor(어느 의사) 와 witch doctor(주술사) 의 발음이 비슷함을 이용한 말장난
			case 262:
				result += "마법의 심장은 자연이야. 심장의 본성은 마법이고."; // nature 이 다른 뜻으로 쓰임 (자연, 본성)을 이용한 말장난
			case 263:
				result += text + " 간호사는 치료를 도와주지만, 난 너의 몸이 너를 치료를 하게 만들 수 있어.";
			case 264:
				result += "신중히 선택해, " + Main.player[Main.myPlayer].name + ", 내 물건들은 변덕스럽고 나의 어두운 예술은, 불가사의하지.";
			case 265:
				result += "우리 얘기좀 해. ㅍ... 파티 말야.";
			case 266:
				result += "파티? 2차? 어떤게 더 좋은지 결정을 못하겠어.";
			case 267:
				result += "반짝이 꽃 파티를 만들자! 물론 2차도 준비하고 말야.";
			case 268:
				result += "와우, " + Main.player[Main.myPlayer].name + ", 모험적인 너를 만나니 파티가 하고싶어져!";
			case 269:
				result += "디스코 볼 설치좀 해줘, 그러면 파티를 어떻게 하는지 알려줄게";
			case 270:
				result += "스웨덴에 가본적이 있는데, 파티를 엄청 열광적이게 하더라고! 왜 너는 그러지 않은거야?";
			case 271:
				result += "내 이름은 " + text6 + " 인데 다들 나를 확깨는 여자라고 하더라고. 몰라아아 , 그래도 멋지게 들려.";
			case 272:
				result += "혹시 파티해? 가끔이라도? 흠, 우리 얘기좀 해...";
			case 273:
				result += "난 풋내기 선원이 아냐. 하지만 풋내기였다가 아닌게 아얘 풋내기가 아니였던것 보단 낫지"; //사랑을 하다가 사랑을 잃은 편이 사랑을 한 번도 안 해본 것 보다 낫다 의 사랑(love) 와 landlubber의 'lubb' 가 발음이 비슷한 것을 이용한 말장난
			case 274:
				result += "요 호 호 그리고 한병의 ....반짝이꽃!";
			case 275:
				result += "야알!	 정말 웃기는군 넌 내 앵무샐 말했어야 했어 왜냐하면!...엄...우리 먼 얘기 하고 있엇지?";
			case 276:
				result += Main.player[Main.myPlayer].name + ", 넌 선장이 2주동간 본 아가씨들 중에 가장 이쁘게 생겼군!";
			case 277:
				result += "내 뒤에서 비켜, 이 망나니야!";
			case 278:
				result += "도데체 먼 소리를 하는거야? 모비딕은 내꺼야!";
			case 279:
				result += "*야아아 내가 ㄱ르에서서어 *"; // 술에 취한 상태라네요
			case 280:
				result += "그리고 492-8 가 말했다, '내가 누군거 같아, 472-6?' 하. 하. 하";
			case 281:
				result += "어떤 투사체가 내 기압원동기와 접촉했을때 내 탐험 능력은 급격히 줄어들었다.";
			case 282:
				result += "이 문장은 '거짓'이다 , 과연 그런가?";
			case 283:
				result += "그러니까 저 '펑크' 한 계집이 발명가다? 그녀에게 한개나 두개정도 보여줄 것이 있다!";
			case 284:
				result += "분명 나와 " + str7 + " 은(는) 친구다, 그렇지만 그 앵무새가 나랑 거래할 때는 싫다. 그건 부식성이다!";
			case 285:
				result += "난 미각 시스템을 내가 장착했다. 에일 정도는 마실 수 있다";
			case 286:
				result += "비트박스정도는 쉽다... 이해되? '비트'?"; // 원래는 Sometimes I come off a bit... get it?... a bit? 인데 '조금'(a bit)과 컴퓨터 단위 '비트'(bit)가 같음을 이용한 말장난
			case 287:
				result += "'옆이랑 뒷마리 짧게, 맞죠?";
			case 288:
				result += "역시 하이라이트를 해야 눈이 돋보인다니까요!";
			case 289:
				result += "제 손이 끈적 끈적하게 더러워 졌어요... 왁스로요."; //이 드립 조금;;
			case 290:
				result += "차? 커피? 아니면 그냥 오렌지 주스요?";
			case 291:
				result += "으구 인형같은 우리 언니, 그 머리카락 끝 갈라진 것 좀 어떻게 해야겠어요.";
			case 292:
				result += "어머머! 언니! 언니랑 수다 떠는게 최고에요.";
			case 293:
				result += "오늘은 어떤 에프터쉐이브 로션으로 하시겠어요?";
			case 294:
				result += "앉아서 잠시만 기다려주세요, 면도날좀 가져올게요.";
			case 295:
				result += "스타일이 있으시거나, 스타일링 받으시거나.";
			case 296:
				result += "당신은.. 해야겠어요... 관리요. 손이 많이 안가도록요.";
			case 297:
				result += "염색상의 염료를 써봤는데요.. 머리 끝이 상해버렸어요. 재앙이 따로 없네요.";
			case 298:
				result += "오..불쌍해라.. 그냥... 그냥 여기 앉아있어요. 괜찮아 질꺼에요. 쉬이이이.";
			case 299:
				result += "신상 헤어는 어때요?";
			case 300:
				result += "안녕하세요~ 전 " + str8 + "에요. 당신 이발사에요.";
			case 301:
				result += "그냥 다듬어 달라고요? 재미 없는뎁....";
			case 302:
				result += "제가 다듬은" + text6 + "의 헤어가 맘에 드시면 좋겟네요!";
			case 303:
				result += str2 + "의 타버린 모발을 저도 어떻게 할 수가 없어요. 실패작이나 마찬가지에요.";
			case 304:
				result += "물론 티핑은 옵션이지만, 가위랑 머리카락은 제 손에 달려있는걸 기억하세요.";
			case 305:
				result += "참고로 이거 재래식 면도기에요.";
			case 306:
				result += "오늘은 좀 떨어지는게 좋아요. 방금 가위날을 갈았는데, 사용할 만한 명분거리를 찾고 있거든요!";
			case 307:
				result += string.Concat(new string[]
				{
					"흐음, ",
					text6,
					" 한테서 들은게 있는데 ",
					text5,
					"의 친구 ",
					text,
					" 가 남자친구 월급을 그녀 신발에 다 써버렸다네요."
				});
			case 308:
				result += "한번은 " + str6 + "에게 가발을 씌어줬어요. 머리를 자를 수 있게요. 좋아햇던것 같아요 ";
			case 309:
				result += "언제한번 " + str8 + "을(를) 만나러 갔어. 나를 보자마자 그냥 '아뇨'라고 하더라.'";
			case 310:
				result += "나 머리를 만질때가 된거 같지 않아?";
			case 311:
				result += "오늘 머리를 빗기는 한거에요?";
			case 312:
				result += "그러니까 픽시컷, 그리구 여성스러움을 강조할까요?";
			case 313:
				result += "귀와 눈썹은 손질해줄 수 있지만, 코 털은... 사양할게요.";
			case 314:
				result += "다 됬어요, 앉아서 조금만 기다려주세요. 25분 있다가 물에 씻어낼게요...";
			case 315:
				result += "고마워요! 드디어 머리 손질좀 하겠네.";
			case 316:
				result += "조금만 더 일찍오셨다면 무료로 손질해드렸을거에요.";
			case 317:
				result += "사람들이 말하기를 여행갈때 가위는 가져가지 말라더라구요. 그 사람들이 말하기를 거미줄에는 갇힐일도 없을것이라고도 햇구요!";
			case 318:
				result += "으, 내 머리, 온통 거미줄로 가득하잖아!";
			case 319:
				result += "3시간 뒤에 " + str4 + "의 집 뒤에서 만나요, 당신이 흥미를 가질만한 물건이 있거든요.";
			case 320:
				result += "저 " + str + "은(는)요 좋은 거래가 뭔지 정말 모르는 것 같아요.";
			case 321:
				result += "전 제가 구할 수 있는거만 팔아요. " + str3 + "은(는) 이국적인 옷들 때문에 저를 사냥하려고 들어요.";
			case 322:
				result += "천사상을 사용하는건 어때요?";
			case 323:
				result += " \"소비자의 후회...\"라는 명목으로 환불은 안받아요. 다른 이유도 마찬가지구요.";
			case 324:
				result += "지금 사면 배송이 무료!";
			case 325:
				result += "전 없을것 같은 재료라도 구해서 판다구요!";
			case 326:
				result += "얼마에 원하신다구요? 절반 가격으로 드리죠!";
			case 327:
				result += "물담배와 커피머신의 조합! 그리고 줄리엔느도 만들죠!";
			case 328:
				result += "♬한번만 보고가요! 물고기 1 파운드! 정말 정말 좋은! 물고기 1파운드!";
			case 329:
				result += "고물을 찾으러 오셨다면, 잘못 찾아오셨어요.";
			case 330:
				result += "중고품 가계라구요?  아뇨, 정말 좋은 물품들만 가지고 왔다구요.";
			case 331:
				result += "핓빛 심장을 부수면 하늘에서 별똥별이 떨어질 수도 있어요. 핓빛 심장은 피투성이 땅 깊은 틈 속 근처에 있지요.";
			case 332:
				result += "정화 가루를 피투성이 땅에 있는 핓빛 돌에 써 보셨나요?";
			case 333:
				result += "당신은 이 피투성이인 세상을 정화시켜야해요.";
			case 334:
				result += "쉿! 네게 시킬일이 있어. 싫다고 말 못할껄!";
			case 335:
				result += "네가 찾아줬으면 하는 물고기가 있어! 물어봐봐!";
			case 336:
				result += "어이! 찾고 있엇다구 너 말야, 우리의 희생- 내말은 우리 능숙한 낚시꾼 말야! ";
			case 337:
				result += str9 + "은(는) '너'가 " + Main.worldName + "의 심부름 원숭이가 되길 바래!";
			case 338:
				result += "뭐어어어어?! 지금 낚싯줄 정리하는거 안보이냐??";
			case 339:
				result += "지금이라면 물고기는 충분해! 너의 도움은 필요없어!";
			case 340:
				result += "이 세계, " + Main.worldName + "에는 쉐프가 없어서 이 물고기들을 내가 스스로 요리해야되!";
			case 341:
				result += "야! 조심해! 나는 내 생에 가장 최고의 장난을 준비중이라고! 아무도 예상 못할껄? 아무한테도 말하지마!";
			case 342:
				result += "애로써 충고하는데, 얼음엔 혀를 대지마! 잠깐, 방금 말한건 잊어버려, 너가 그렇게 하는걸 보고싶어!";
			case 343:
				result += "혹시 개처럼 짖는 물고기에 관해서 들어본 적이 있어?! 난 없어, 그냥 궁금해서!";
			case 344:
				result += Main.worldName + " 에는 이상한 물고기가 정말 많아!";
			case 345:
				result += "정말 속상해! 내가 태어나기도 전에 멸종된 물고기가 있다니, 불공평해!";
			case 346:
				result += "어.. 아빠랑 엄마는 안계셔, 그렇지만 물고기가 많이 있지! 그게 그거 아냐?";
			case 347:
				result += "헤헤, 아까 " + text3 + "의 얼굴을 봤어야 했어, 피라냐 이빨을 의자 위에 뒀을때 말이야!";
			case 348:
				result += "너에게 부탁이 있어! 아니, 지금 좀비 아포칼립스가 일어나고 있다고해도 상관없어!";
			case 349:
				result += "빨리좀 들어봐! 너가 뭐 좀 잡아 줬으면 좋겠어 지금!";
			case 350:
				result += "난 블러드문이 싫어! 밤새 무서운 소리 때문에 못 잔단 말이야!";
			case 351:
				result += "블러드문은 낚시하기 딱 안좋은 날씨야! 입질도 그렇지만, 좀비는 어떻다고!";
			case 352:
				result += "저기 어어어엄청 많은 몬스터들이 밖에 있어!";
			case 353:
				result += "고마워, 아마도, 날 구해줘서 말이야. 넌 분명히 좋은 하인이 될꺼야!";
			case 354:
				result += "워? 넌 누구야? 나 여기서 익사한다거나 그런거 아니였어!";
			case 355:
				result += "날 구하다니! 너 끔직하도록 좋은 사람이구나, 널 이용해서... 어, 그러니까, 고용해서 멋진 일들을 할 수 있을꺼야!";
			case 356:
				result += "혹시 뼈 파는거 있어? 엉덩이 뼈가 부러져서 말야.... 또.";
			case 357:
				result += "아싸! 드디어 내 손에서 구더기들을 때줄 사람을 찾았군";
			case 358:
				result += "슬라임 기름으로 고칠 수 없는 병은 어디에도 없지! 믿어도 좋아, 내 몸을 봐!";
			case 359:
				result += "진짜 척추는 이 지하에나 있지, 뭐좀 살래?";
			case 360:
				result += "사람들이 나에게 뭘 던졌는지 너는 상상도 못할꺼야... 그중 몇개좀 살래?";
			case 361:
				result += "이번엔 손을 빌려줄게, 근데 저번에 그랬을때는, 한달동안이나 못 돌려받았어";
			case 362:
				result += "거미들 가까이 가지 마. 안쪽은 모두 빨려 껍데기만 남게 될꺼야. 이번엔 믿어도 좋아.";
			case 363:
				result += "이 세계에서 일정한건 두개야. 죽음과 세금이지, 난 둘다 겪어봤고!";
			case 364:
				result += "또 너야? 돈 받으러 왔지!?";
			case 365:
				result += "여기 있는 사람들은 문을 다 쾅쾅 거리며 다녀야 하는거야?!";
			case 366:
				result += "너 한가해 보이는군, 늘 그렇듯이. 그런 사람들의 삶은 상상도 못하겟군.";
			case 367:
				result += "그래, 그래, 그래! -- 네 돈 줄게. 조금만 더 참을성이 있으면 좋겠군.";
			case 368:
				result += "나 큰 놈이 여기 혼자서 뭐하겠어? 덜 바쁜사람한테 찾아가, 꺼져!";
			case 369:
				result += "...술 두병, 더하기 -- 아, 신경 쓰지마. 돈 여깄어.";
			case 370:
				result += "우리 둘 사이에 말인데... 왜 주민들이 집세 내는데 신경을 안쓰는지 모르겠어 ";
			case 371:
				result += "가서" + text3 + " 에게 세금 대신 부탁 하나만 들어달라고 해, 이상한 곳에서 버섯이 자란다고.";
			case 372:
				result += "가서 " + text2 + " 에게 탄약으로 세금을 내지 말라고 해, 총도 없는데 말야 .";
			case 373:
				result += "왜 '네가'" + str2 + " 에게서 세금을 받아오지 않는거야? 다리나 팔 하나를 잃지 않으려고 시도 하면서 말야...";
			case 374:
				result += "방금 " + str + "네 집에서 오는 길이야. 신용카드를 받는지 궁금해 하더군.";
			case 380:
				result += "이 엄청난 인구에서 세금을 받아내려 우리 지도자 분이 오셨군!";
			case 381:
				result += "여기 누가 왔는지 봐봐, 내 돈을 가지러 말야! 가져가! !";
			case 382:
				result += "프후! 여기, 니 돈은 가져가고 내 시야에서 사라져!";
			case 383:
				result += "이게 지금 가져갈 수 있는 전부야, 페니 하나도 더 못줘! 현명하게 쓰길.";
			case 390:
				result += "...그리고 사람들이 날 욕심 많다고 부른다고? 없어, 더는 줄것이 없어.";
			case 391:
				result += "날 동전 표지판으로 본다 이거냐? 날 볼때마다 물어보잖아.";
			case 392:
				result += "여기 오는 이유가 '안녕하세요?'라고 말 한마디 하지는 못하냐!";
			case 393:
				result += "프후! 또 너야? 내 동전을 조금전에 가져갔잖아, 꺼져! 나중에 다시와!";
			case 394:
				result += "분명히 반 실링을 5분 전에 가져갔잖아! 썩 꺼져!";
			case 395:
				result += "내 돈가방까지 손댈꺼야!? 그리고 나보고 욕심이 많다고 하지... 프후.";
			case 396:
				result += "넌 지금 네 돈을 받았고, 단  파딩 하나도 더 못줘! 나가!";
			case 397:
				result += "돈은 나무에서 안자라니까, 내 열매까지 따가지는 마! 프후! ";
			case 398:
				result += "내가 준 돈은 벌써 다 쓴거야!? 프후, 난 자선사업가가 아니니, 가서 슬라임이나 잡아!";
			case 399:
				result += "이렇게 이르겐 안돼! 네 돈은 받았으니, 이제 나가! ";
			case 400:
				result += "이젠 구걸까지?! 하룻 밤 만에 내가 마음을 바꿀꺼라고 생각하는거야! ";
			case 401:
				result += "핓빛 제단을 찾으면 꼭 부수세요. 무언가 좋은일이 일어날 꺼랍니다!";
			case 402:
				result += "핓빛 제단은 피투성이 땅에서 찾을 수 있어요. 근처에 있으면 몇가지 아이템을 조합할 수 있어요.";
			case 403:
				result += "척추 뼈로 피 묻은 척추를 만들 수 있어요. 쓰기전에 피투성이 땅에 있는지 확인하세요.";
			default:
				result += "ERROR 404";
		}
		
		return result;
	}
		
		switch (l)
		{
			case 0:
				result += "방어력 +2 ";
			case 1:
				result += "방어력 +3";
			case 2:
				result += "이동속도 +15% 상승";
			case 3:
				result += "스페이스 건의 마나 소모 없음";
			case 4:
				result += "탄약을 쓰지 않을 확률 +20%";
			case 5:
				result += "마나 소모 16% 감소";
			case 6:
				result += "추가 대미지 +17%";
			case 7:
				result += "채광 속도 +30%";
			case 8:
				result += "마나 소모 14% 감소";
			case 9:
				result += "공격 속도 +15%";
			case 10:
				result += "탄약을 쓰지 않을 확률 +20%";
			case 11:
				result += "마나 소모 17% 감소";
			case 12:
				result += "근접 무기 치명타 확률 5% 만큼 증가합니다";
			case 13:
				result += "탄약을 쓰지 않을 확률 20% ";
			case 14:
				result += "마나 소모 19% 감소";
			case 15:
				result += "근접 무기 공격속도와 이동속도 18% 만큼 증가합니다";
			case 16:
				result += "탄약을 쓰지 않을 확률 25%";
			case 17:
				result += "마나 소모 20% 감소";
			case 18:
				result += "근접 무기 공격속도와 이동속도 19% 만큼 증가합니다";
			case 19:
				result += "탄약을 쓰지 않을 확률 25% 만큼 증가합니다";
			case 20:
				result += "방어력 +1";
			case 21:
				result += "회복 속도 대폭 상승";
			case 22:
				result += "근접과 원거리 공격이 동상을 입힙니다";
			case 23:
				result += "소환수의 최대 수가 증가합니다";
			case 24:
				result += "적에게 피해 입혔을때 회복속도 대폭 향상됩니다";
			case 25:
				result += "꽃잎들이 목표에 떨어져 추가 피해를 입힙니다";
			case 26:
				result += "적을 공격할 때 잠시동안 무적이 됩니다";
			case 27:
				result += "근처 적을 공격하는 잎사귀 크리스탈을 소환합니다";
			case 28:
				result += "마법공격 피해량과 치명타 확률이 10% 만큼 증가합니다";
			case 29:
				result += "공격자들도 피해를 입습니다";
			case 30:
				result += "적에게 마법 피해를 입히면 소량의 생명력을 회복합니다";
			case 31:
				result += "움직이지 않으면 은신 상태로 진입합니다\n 원거리 관련 능력이 향상되며 적이 목표로 삼을 확률이 적어집니다";
			case 32:
				result += "방어력 + 4 ";
			case 33:
				result += "피해량 10% 만큼 증가합니다";
			case 34:
				result += "소환수의 피해량이 25% 만큼 증가합니다";
			case 35:
				result += "주변 적들에게는 마법 피해량이 증가합니다";
			case 36:
				result += "마나 최대치가 60 증가합니다";
			case 37:
				result += "딱정벌레의 보호를 받습니다";
			case 38:
				result += "딱정벌레들이 근접 피해량과 공격속도를 증가시킵니다";
			case 39:
				result += "소환수의 피해량이 10% 만큼 증가합니다";
			case 40:
				result += "소환수의 피해량이 12% 만큼 증가합니다";
			case 41:
				result += "소비형 투척 아이템을 쓰지 않을 확률 33%";
			case 42:
				result += "소비형 투척 아이템을 쓰지 않을 확률 50%";
			case 43:
				result += "서서히 태양 방패가 생성됩니다\n태양 방패를 사용해 적에게 피해를 주며 돌진합니다";
			case 44:
				result += (Main.ReversedUpDownArmorSetBonuses ? "UP" : "DOWN") + " 키를 두번 눌러 은신 상태에 진입합니다  ,\n 은신상태에서는 원거리 능력이 항상되고 적에게 목표가 될 확률이 적어지나 이동속도가 느려집니다";
			case 45:
				result += "적에게 피해를 입히면 버프 부스터를 생성합니다,\n버프 부스터를 획득해 중첩 버프를 획득합니다";
			case 46:
				result += (Main.ReversedUpDownArmorSetBonuses ? "UP" : "DOWN") + " 키를 두번 눌러 수호자에게 그 자리를 지키도록 합니다";
		}
		
		return result;
	}
	
	public static string npcName(int l)
	{		
		string result = "";
		
		switch (l)
		{
			case -65:
				result += "말벌";
			case -64:
				result += "말벌";
			case -63:
				result += "말벌";
			case -62:
				result += "말벌";
			case -61:
				result += "말벌";
			case -60:
				result += "말벌";
			case -59:
				result += "말벌";
			case -58:
				result += "말벌";
			case -57:
				result += "말벌";
			case -56:
				result += "말벌";
			case -55:
				result += "좀비";
			case -54:
				result += "좀비";
			case -53:
				result += "해골";
			case -52:
				result += "해골";
			case -51:
				result += "해골";
			case -50:
				result += "해골";
			case -49:
				result += "해골";
			case -48:
				result += "해골";
			case -47:
				result += "해골";
			case -46:
				result += "해골";
			case -45:
				result += "좀비";
			case -44:
				result += "좀비";
			case -43:
				result += "악마의 눈";
			case -42:
				result += "악마의 눈";
			case -41:
				result += "악마의 눈";
			case -40:
				result += "악마의 눈";
			case -39:
				result += "악마의 눈";
			case -38:
				result += "악마의 눈";
			case -37:
				result += "좀비";
			case -36:
				result += "좀비";
			case -35:
				result += "좀비";
			case -34:
				result += "좀비";
			case -33:
				result += "좀비";
			case -32:
				result += "좀비";
			case -31:
				result += "좀비";
			case -30:
				result += "좀비";
			case -29:
				result += "좀비";
			case -28:
				result += "좀비";
			case -27:
				result += "좀비";
			case -26:
				result += "좀비";
			case -25:
				result += "진홍 슬라임";
			case -24:
				result += "진홍 슬라임";
			case -23:
				result += "크리메라";
			case -22:
				result += "크리메라";
			case -21:
				result += "이끼 말벌";
			case -20:
				result += "이끼 말벌";
			case -19:
				result += "이끼 말벌";
			case -18:
				result += "이끼 말벌";
			case -17:
				result += "말벌";
			case -16:
				result += "말벌";
			case -15:
				result += "무장 해골";
			case -14:
				result += "성난 해골";
			case -13:
				result += "성난 해골";
			case -12:
				result += "영혼을 먹는 자";
			case -11:
				result += "영혼을 먹는 자";
			case -10:
				result += "정글 슬라임";
			case -9:
				result += "노란 슬라임";
			case -8:
				result += "빨간 슬라임";
			case -7:
				result += "보라 슬라임";
			case -6:
				result += "검정 슬라임";
			case -5:
				result += "새끼 슬라임";
			case -4:
				result += "핑키";
			case -3:
				result += "초록 슬라임";
			case -2:
				result += "슬라이머";
			case -1:
				result += "슬라이머링";
			case 1:
				result += "파란 슬라임";
			case 2:
				result += "악마의 눈";
			case 3:
				result += "좀비";
			case 4:
				result += "크툴후의 눈";
			case 5:
				result += "크툴후의 하수인";
			case 6:
				result += "영혼을 먹는 자";
			case 7:
				result += "포식귀";
			case 8:
				result += "포식귀";
			case 9:
				result += "포식귀";
			case 10:
				result += "거대 지렁이";
			case 11:
				result += "거대 지렁이";
			case 12:
				result += "거대 지렁이";
			case 13:
				result += "세상을 먹는 자";
			case 14:
				result += "세상을 먹는 자";
			case 15:
				result += "세상을 먹는 자";
			case 16:
				result += "어미 슬라임";
			case 17:
				result += "상인";
			case 18:
				result += "간호사";
			case 19:
				result += "무기상";
			case 20:
				result += "숲의 요정";
			case 21:
				result += "해골";
			case 22:
				result += "안내자";
			case 23:
				result += "운석 머리";
			case 24:
				result += "불도깨비";
			case 25:
				result += "불타는 구체";
			case 26:
				result += "고블린 보병";
			case 27:
				result += "고블린 도적";
			case 28:
				result += "고블린 전사";
			case 29:
				result += "고블린 마법사";
			case 30:
				result += "혼돈의 구";
			case 31:
				result += "화가난 해골";
			case 32:
				result += "어둠의 마법사";
			case 33:
				result += "물의 구체";
			case 34:
				result += "저주받은 해골";
			case 35:
				result += "해골";
			case 36:
				result += "해골";
			case 37:
				result += "영감";
			case 38:
				result += "파괴자";
			case 39:
				result += "뼈다귀 뱀";
			case 40:
				result += "뼈다귀 뱀";
			case 41:
				result += "뼈다귀 뱀";
			case 42:
				result += "말벌";
			case 43:
				result += "식인 식물";
			case 44:
				result += "언데드 광부";
			case 45:
				result += "팀";
			case 46:
				result += "토끼";
			case 47:
				result += "타락한 토끼";
			case 48:
				result += "하피";
			case 49:
				result += "동굴 박쥐";
			case 50:
				result += "왕 슬라임";
			case 51:
				result += "정글 박쥐";
			case 52:
				result += "본즈 박사";
			case 53:
				result += "신랑";
			case 54:
				result += "재봉사";
			case 55:
				result += "금붕어";
			case 56:
				result += "스내쳐";
			case 57:
				result += "타락한 금붕어";
			case 58:
				result += "피라냐";
			case 59:
				result += "용암 슬라임";
			case 60:
				result += "지옥박쥐";
			case 61:
				result += "대머리 독수리";
			case 62:
				result += "악마";
			case 63:
				result += "파란 해파리";
			case 64:
				result += "분홍 해파리";
			case 65:
				result += "상어";
			case 66:
				result += "부두 악마";
			case 67:
				result += "게";
			case 68:
				result += "던전 수호자";
			case 69:
				result += "개미귀신";
			case 70:
				result += "스파이크 볼";
			case 71:
				result += "던전 슬라임";
			case 72:
				result += "불타는 바퀴";
			case 73:
				result += "고블린 정찰병";
			case 74:
				result += "새";
			case 75:
				result += "픽시";
			case 77:
				result += "무장한 해골";
			case 78:
				result += "미라";
			case 79:
				result += "어둠의 미라";
			case 80:
				result += "빛의 미라";
			case 81:
				result += "타락한 슬라임";
			case 82:
				result += "망령";
			case 83:
				result += "저주받은 망치";
			case 84:
				result += "마법이 깃든 검";
			case 85:
				result += "미믹";
			case 86:
				result += "유니콘";
			case 87:
				result += "와이번";
			case 88:
				result += "와이번";
			case 89:
				result += "와이번";
			case 90:
				result += "와이번";
			case 91:
				result += "와이번";
			case 92:
				result += "와이번";
			case 93:
				result += "거대한 박쥐";
			case 94:
				result += "타락귀";
			case 95:
				result += "디거";
			case 96:
				result += "디거";
			case 97:
				result += "디거";
			case 98:
				result += "월드 피더";
			case 99:
				result += "월드 피더";
			case 100:
				result += "월드 피더";
			case 101:
				result += "클링어";
			case 102:
				result += "아귀";
			case 103:
				result += "초록 해파리";
			case 104:
				result += "늑대인간";
			case 105:
				result += "묶여있는 고블린";
			case 106:
				result += "묶여있는 마법사";
			case 107:
				result += "고블린 뗌장이";
			case 108:
				result += "마법사";
			case 109:
				result += "광대";
			case 110:
				result += "해골 궁수";
			case 111:
				result += "고블린 궁수";
			case 112:
				result += "더러운 침";
			case 113:
				result += "육체의 벽";
			case 114:
				result += "육체의 벽";
			case 115:
				result += "굶주린 자";
			case 116:
				result += "굶주린 자";
			case 117:
				result += "거머리";
			case 118:
				result += "거머리";
			case 119:
				result += "거머리";
			case 120:
				result += "혼돈의 정령";
			case 121:
				result += "슬라이머";
			case 122:
				result += "복족류";
			case 123:
				result += "묶여있는 기계공";
			case 124:
				result += "기계공";
			case 125:
				result += "레티나이저";
			case 126:
				result += "스파즈마티즘";
			case 127:
				result += "스켈레트론 프라임";
			case 128:
				result += "프라임 캐논";
			case 129:
				result += "프라임 소우";
			case 130:
				result += "프라임 바이스";
			case 131:
				result += "프라임 레이저";
			case 132:
				result += "좀비";
			case 133:
				result += "방황하는 눈";
			case 134:
				result += "파괴자";
			case 135:
				result += "파괴자";
			case 136:
				result += "파괴자";
			case 137:
				result += "발광 박쥐";
			case 138:
				result += "발광 슬라임";
			case 139:
				result += "탐사정";
			case 140:
				result += "빙의된 갑옷";
			case 141:
				result += "독성 진흙";
			case 142:
				result += "산타 클로스";
			case 143:
				result += "눈사람 갱스터";
			case 144:
				result += "미스터 스태비";
			case 145:
				result += "스노우 벨라";
			case 147:
				result += "얼음 슬라임";
			case 148:
				result += "펭귄";
			case 149:
				result += "펭귄";
			case 150:
				result += "얼음 박쥐";
			case 151:
				result += "용암 박쥐";
			case 152:
				result += "거대한 비행 여우";
			case 153:
				result += "거대한 거북이";
			case 154:
				result += "얼음 거북이";
			case 155:
				result += "늑대";
			case 156:
				result += "붉은 악마";
			case 157:
				result += "피라루쿠";
			case 158:
				result += "뱀파이어";
			case 159:
				result += "뱀파이어";
			case 160:
				result += "송로버섯";
			case 161:
				result += "좀비 에스키모";
			case 162:
				result += "프랑켄슈타인";
			case 163:
				result += "검은 은둔자";
			case 164:
				result += "월 크리퍼";
			case 165:
				result += "월 크리퍼";
			case 166:
				result += "정체불명의 늪생물";
			case 167:
				result += "언데드 바이킹";
			case 168:
				result += "타락한 펭귄";
			case 169:
				result += "얼음 정령";
			case 170:
				result += "돼지용";
			case 171:
				result += "돼지용";
			case 172:
				result += "룬의 마법사";
			case 173:
				result += "크리메라";
			case 174:
				result += "허플링";
			case 175:
				result += "화가난 사냥꾼";
			case 176:
				result += "이끼 말벌";
			case 177:
				result += "더플링";
			case 178:
				result += "스팀펑커";
			case 179:
				result += "진홍 도끼";
			case 180:
				result += "돼지용";
			case 181:
				result += "얼굴 괴물";
			case 182:
				result += "플로티 글로스";
			case 183:
				result += "진홍 슬라임";
			case 184:
				result += "가시박힌 얼음 슬라임";
			case 185:
				result += "스노우 플링스";
			case 186:
				result += "좀비";
			case 187:
				result += "좀비";
			case 188:
				result += "좀비";
			case 189:
				result += "좀비";
			case 190:
				result += "악마의 눈";
			case 191:
				result += "악마의 눈";
			case 192:
				result += "악마의 눈";
			case 193:
				result += "악마의 눈";
			case 194:
				result += "악마의 눈";
			case 195:
				result += "길 잃은 소녀";
			case 196:
				result += "님프";
			case 197:
				result += "무장한 바이킹";
			case 198:
				result += "리자드";
			case 199:
				result += "리자드";
			case 200:
				result += "좀비";
			case 201:
				result += "해골";
			case 202:
				result += "해골";
			case 203:
				result += "해골";
			case 204:
				result += "가시박힌 정글 슬라임";
			case 205:
				result += "나방";
			case 206:
				result += "얼음에 뒤덮힌 인어";
			case 207:
				result += "염료상";
			case 208:
				result += "파티 소녀";
			case 209:
				result += "사이보그";
			case 210:
				result += "꿀벌";
			case 211:
				result += "꿀벌";
			case 212:
				result += "해적 갑판원";
			case 213:
				result += "해적단";
			case 214:
				result += "해적 애꾸눈";
			case 215:
				result += "해적 석궁사";
			case 216:
				result += "해적 선장";
			case 217:
				result += "코치닐 딱정벌레";
			case 218:
				result += "청록색 딱정벌레";
			case 219:
				result += "랙 딱정벌레";
			case 220:
				result += "소라";
			case 221:
				result += "오징어";
			case 222:
				result += "여왕벌";
			case 223:
				result += "좀비";
			case 224:
				result += "날치";
			case 225:
				result += "우산 슬라임";
			case 226:
				result += "날아다니는 뱀";
			case 227:
				result += "화가";
			case 228:
				result += "주술사";
			case 229:
				result += "해적";
			case 230:
				result += "금붕어";
			case 231:
				result += "말벌";
			case 232:
				result += "말벌";
			case 233:
				result += "말벌";
			case 234:
				result += "말벌";
			case 235:
				result += "말벌";
			case 236:
				result += "정글 크리퍼";
			case 237:
				result += "정글 크리퍼";
			case 238:
				result += "검은 은둔자";
			case 239:
				result += "블러드 크롤러";
			case 240:
				result += "블러드 크롤러";
			case 241:
				result += "블러드 피더";
			case 242:
				result += "블러드 젤리";
			case 243:
				result += "얼음 골렘";
			case 244:
				result += "무지갯빛 슬라임";
			case 245:
				result += "골렘";
			case 246:
				result += "골렘 머리";
			case 247:
				result += "골렘 주먹";
			case 248:
				result += "골렘 주먹";
			case 249:
				result += "골렘 머리";
			case 250:
				result += "화가난 비구름";
			case 251:
				result += "아이저";
			case 252:
				result += "앵무새";
			case 253:
				result += "사신";
			case 254:
				result += "좀비";
			case (int)byte.MaxValue:
				result += "좀비";
			case 256:
				result += "버섯 해파리";
			case 257:
				result += "버섯 집게";
			case 258:
				result += "무시 무당벌레";
			case 259:
				result += "버섯 구근";
			case 260:
				result += "거대한 버섯 구근";
			case 261:
				result += "버섯 포자";
			case 262:
				result += "플렌테라";
			case 263:
				result += "플렌테라의 갈고리";
			case 264:
				result += "플렌테라의 촉수";
			case 265:
				result += "포자";
			case 266:
				result += "크툴후의 뇌";
			case 267:
				result += "크리퍼";
			case 268:
				result += "이코르 스티커";
			case 269:
				result += "녹슨 무장 해골";
			case 270:
				result += "녹슨 무장 해골";
			case 271:
				result += "녹슨 무장 해골";
			case 272:
				result += "녹슨 무장 해골";
			case 273:
				result += "파란 무장 해골";
			case 274:
				result += "파란 무장 해골";
			case 275:
				result += "파란 무장 해골";
			case 276:
				result += "파란 무장 해골";
			case 277:
				result += "지옥 무장 해골";
			case 278:
				result += "지옥 무장 해골";
			case 279:
				result += "지옥 무장 해골";
			case 280:
				result += "지옥 무장 해골";
			case 281:
				result += "누더기 마법사";
			case 282:
				result += "누더기 마법사";
			case 283:
				result += "네크로멘서";
			case 284:
				result += "네크로멘서";
			case 285:
				result += "디아볼리스트";
			case 286:
				result += "디아볼리스트";
			case 287:
				result += "본 리";
			case 288:
				result += "던전 영혼";
			case 289:
				result += "거대한 저주받은 해골";
			case 290:
				result += "팔라딘";
			case 291:
				result += "해골 저격수";
			case 292:
				result += "전술 해골";
			case 293:
				result += "해골 특전사";
			case 294:
				result += "화난 해골";
			case 295:
				result += "화난 해골";
			case 296:
				result += "화난 해골";
			case 297:
				result += "큰어치";
			case 298:
				result += "홍관조";
			case 299:
				result += "다람쥐";
			case 300:
				result += "생쥐";
			case 301:
				result += "까마귀";
			case 302:
				result += "슬라임";
			case 303:
				result += "슬라임";
			case 304:
				result += "호핀' 잭";
			case 305:
				result += "허수아비";
			case 306:
				result += "허수아비";
			case 307:
				result += "허수아비";
			case 308:
				result += "허수아비";
			case 309:
				result += "허수아비";
			case 310:
				result += "허수아비";
			case 311:
				result += "허수아비";
			case 312:
				result += "허수아비";
			case 313:
				result += "허수아비";
			case 314:
				result += "허수아비";
			case 315:
				result += "머리 없는 기수";
			case 316:
				result += "유령";
			case 317:
				result += "악마의 눈";
			case 318:
				result += "악마의 눈";
			case 319:
				result += "좀비";
			case 320:
				result += "좀비";
			case 321:
				result += "좀비";
			case 322:
				result += "해골";
			case 323:
				result += "해골";
			case 324:
				result += "해골";
			case 325:
				result += "탄식하는 나무";
			case 326:
				result += "스플린터링";
			case 327:
				result += "펌킹";
			case 328:
				result += "펌킹";
			case 329:
				result += "헬하운드";
			case 330:
				result += "폴터가이스트";
			case 331:
				result += "좀비";
			case 332:
				result += "좀비";
			case 333:
				result += "슬라임";
			case 334:
				result += "슬라임";
			case 335:
				result += "슬라임";
			case 336:
				result += "슬라임";
			case 337:
				result += "토끼";
			case 338:
				result += "좀비 요정";
			case 339:
				result += "좀비 요정";
			case 340:
				result += "좀비 요정";
			case 341:
				result += "선물 미믹";
			case 342:
				result += "생강빵";
			case 343:
				result += "예티";
			case 344:
				result += "에버스크림";
			case 345:
				result += "얼음여왕";
			case 346:
				result += "산타-NK1";
			case 347:
				result += "엘프 콥터";
			case 348:
				result += "호두까기 인형";
			case 349:
				result += "호두까기 인형";
			case 350:
				result += "요정 궁수";
			case 351:
				result += "크램퍼스";
			case 352:
				result += "플로코";
			case 353:
				result += "스타일리스트";
			case 354:
				result += "거미줄에 걸린 스타일리스트";
			case 355:
				result += "반딧불이";
			case 356:
				result += "나비";
			case 357:
				result += "지렁이";
			case 358:
				result += "개똥벌레";
			case 359:
				result += "달팽이";
			case 360:
				result += "야광 달팽이";
			case 361:
				result += "개구리";
			case 362:
				result += "오리";
			case 363:
				result += "오리";
			case 364:
				result += "오리";
			case 365:
				result += "오리";
			case 366:
				result += "전갈";
			case 367:
				result += "전갈";
			case 368:
				result += "행상인";
			case 369:
				result += "낚시꾼";
			case 370:
				result += "듀크 피시론";
			case 371:
				result += "폭발하는 거품";
			case 372:
				result += "샤크론";
			case 373:
				result += "샤크론";
			case 374:
				result += "송로버섯 지렁이";
			case 375:
				result += "송로버섯 지렁이";
			case 376:
				result += "잠자는 낚시꾼";
			case 377:
				result += "메뚜기";
			case 378:
				result += "Chattering Teeth Bomb";
			case 379:
				result += "Blue Cultist Archer";
			case 380:
				result += "White Cultist Archer";
			case 381:
				result += "두뇌 분쇄기";
			case 382:
				result += "Ray Gunner";
			case 383:
				result += "Martian Officer";
			case 384:
				result += "거품 방패";
			case 385:
				result += "Gray Grunt";
			case 386:
				result += "Martian Engineer";
			case 387:
				result += "테슬라 터렛";
			case 388:
				result += "Martian Drone";
			case 389:
				result += "기가재퍼";
			case 390:
				result += "Scutlix Gunner";
			case 391:
				result += "Scutlix";
			case 392:
				result += "마틴 소서";
			case 393:
				result += "마틴 소서 터렛";
			case 394:
				result += "마틴 소서 캐논";
			case 395:
				result += "마틴 소서";
			case 396:
				result += "Moon Lord";
			case 397:
				result += "Moon Lord's Hand";
			case 398:
				result += "Moon Lord's Core";
			case 399:
				result += "Martian Probe";
			case 402:
				result += "Milkyway Weaver";
			case 405:
			case 406:
				result += "Star Cell";
			case 407:
				result += "Flow Invader";
			case 409:
				result += "Twinkle Popper";
			case 410:
				result += "Twinkle";
			case 411:
				result += "Stargazer";
			case 412:
				result += "Crawltipede";
			case 413:
				result += "Crawltipede";
			case 414:
				result += "Crawltipede";
			case 415:
				result += "Drakomire";
			case 416:
				result += "Drakomire Rider";
			case 417:
				result += "Sroller";
			case 418:
				result += "Corite";
			case 419:
				result += "Selenian";
			case 420:
				result += "Nebula Floater";
			case 421:
				result += "Brain Suckler";
			case 422:
				result += "Vortex Pillar";
			case 423:
				result += "진화의 괴수";
			case 424:
				result += "Predictor";
			case 425:
				result += "Storm Diver";
			case 426:
				result += "외계여왕";
			case 427:
				result += "외계말벌";
			case 428:
				result += "외계애벌레";
			case 429:
				result += "소용도리안";
			case 430:
				result += "좀비";
			case 431:
				result += "좀비 에스키모";
			case 432:
				result += "좀비";
			case 433:
				result += "좀비";
			case 434:
				result += "좀비";
			case 435:
				result += "좀비";
			case 436:
				result += "좀비";
			case 437:
				result += "Mysterious Tablet";
			case 438:
				result += "Lunatic Devote";
			case 439:
				result += "Lunatic Cultist";
			case 440:
				result += "Lunatic Cultist";
			case 442:
				result += "Gold Bird";
			case 443:
				result += "Gold Bunny";
			case 444:
				result += "Gold Butterfly";
			case 445:
				result += "Gold Frog";
			case 446:
				result += "Gold Grasshopper";
			case 447:
				result += "Gold Mouse";
			case 448:
				result += "Gold Worm";
			case 449:
				result += "Skeleton";
			case 450:
				result += "Skeleton";
			case 451:
				result += "Skeleton";
			case 452:
				result += "Skeleton";
			case 454:
			case 455:
			case 456:
			case 457:
			case 458:
			case 459:
				result += "Phantasm Dragon";
			case 460:
				result += "도살자";
			case 461:
				result += "Creature from the Deep";
			case 462:
				result += "Fritz";
			case 463:
				result += "Nailhead";
			case 464:
				result += "Crimtane Bunny";
			case 465:
				result += "Crimtane Goldfish";
			case 466:
				result += "Psycho";
			case 467:
				result += "Deadly Sphere";
			case 468:
				result += "Dr. Man Fly";
			case 469:
				result += "The Possessed";
			case 470:
				result += "Vicious Penguin";
			case 471:
				result += "Goblin Summoner";
			case 472:
				result += "Shadowflame Apparation";
			case 473:
				result += "Corrupt Mimic";
			case 474:
				result += "Crimson Mimic";
			case 475:
				result += "Hallowed Mimic";
			case 476:
				result += "Jungle Mimic";
			case 477:
				result += "Mothron";
			case 478:
				result += "Mothron Egg";
			case 479:
				result += "Baby Mothron";
			case 480:
				result += "Medusa";
			case 481:
				result += "Hoplite";
			case 482:
				result += "Granite Golem";
			case 483:
				result += "Granite Elemental";
			case 484:
				result += "Enchanted Nightcrawler";
			case 485:
				result += "Grubby";
			case 486:
				result += "Sluggy";
			case 487:
				result += "Buggy";
			case 488:
				result += "Target Dummy";
			case 489:
				result += "Blood Zombie";
			case 490:
				result += "Drippler";
			case 493:
				result += "Stardust Pillar";
			case 494:
				result += "Crawdad";
			case 495:
				result += "Crawdad";
			case 496:
				result += "Giant Shelly";
			case 497:
				result += "Giant Shelly";
			case 498:
				result += "Salamander";
			case 499:
				result += "Salamander";
			case 500:
				result += "Salamander";
			case 501:
				result += "Salamander";
			case 502:
				result += "Salamander";
			case 503:
				result += "Salamander";
			case 504:
				result += "Salamander";
			case 505:
				result += "Salamander";
			case 506:
				result += "Salamander";
			case 507:
				result += "Nebula Pillar";
			case 508:
				result += "Antlion Charger";
			case 509:
				result += "Antlion Swarmer";
			case 510:
			case 511:
			case 512:
				result += "Dune Splicer";
			case 513:
			case 514:
			case 515:
				result += "Tomb Crawler";
			case 516:
				result += "Solar Flare";
			case 517:
				result += "Solar Pillar";
			case 518:
				result += "Drakanian";
			case 519:
				result += "Solar Fragment";
			case 520:
				result += "Martian Walker";
			case 521:
				result += "Ancient Vision";
			case 522:
				result += "Ancient Light";
			case 523:
				result += "Ancient Doom";
			case 524:
				result += "구울";
			case 525:
				result += "Vile 구울";
			case 526:
				result += "Tainted 구울";
			case 527:
				result += "꿈꾸는 구울";
			case 528:
			case 529:
				result += "Lamia";
			case 530:
			case 531:
				result += "Sand Poacher";
			case 532:
				result += "바실리스크";
			case 533:
				result += "사막 정령";
			case 534:
				result += "Tortured Soul";
			case 535:
				result += "Spiked Slime";
			case 536:
				result += "The Bride";
			case 537:
				result += "Sand Slime";
			case 538:
				result += "Red Squirrel";
			case 539:
				result += "Gold Squirrel";
		}
		
		return result;
	}
	
	public static string toolTip(int l)
	{
		
		if (l >= 1372 && l <= 1375)
		{
			return "'W. Garner'";
=======
					case 0:
						array2[0] = "Oh! Thanks for the fish I asked for, now scram!";
						break;
					case 1:
						array2[0] = "Awesome catch! It's all going according to plan! He he he!";
						break;
					case 2:
						array2[0] = "You make a great errand monkey! Now go away!";
						break;
					case 3:
						array2[0] = "Muahahahahaha! You did it! You're still in one piece though, how boring!";
						break;
					case 4:
						array2[0] = "Woah!? You actually did what I asked, and survived! Nice, hand it over and beat it!";
						break;
				}
			}
			if (Main.anglerQuestFinished)
			{
				switch (Main.rand.Next(5))
				{
					case 0:
						array[0] = "I don't have anything for you to do right now.";
						break;
					case 1:
						array[0] = "You have entertained me enough for today, go.";
						break;
					case 2:
						array[0] = "You are done, the grand " + str + " dismisses you!";
						break;
					case 3:
						array[0] = "Only one fish a day, please go away!";
						break;
					case 4:
						array[0] = "I haven't even used the last fish you gave me.  I don't need another.";
						break;
				}
			}
			else
			{
				switch (Main.anglerQuestItemNetIDs[Main.anglerQuest])
				{
					case 2450:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "Na na na na na na na Bat-FISH!";
							array[num2++] = "That means go digging underground, fetch it, and bring it to me!";
							flag = true;
							text = "\n(Caught in Underground & Caverns)";
						}
						break;
					case 2451:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "The subterranean jungles of " + Main.worldName + " have the weirdest things!";
							array[num2++] = "Like, there's this fish I saw that looked just like a giant bumblebee!";
							array[num2++] = "I'm allergic to bees, so you have to catch it for me! I bet it'd taste like a tuna and honey sandwich!";
							flag = true;
							text = "\n(Caught in Honey)";
						}
						break;
					case 2452:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "I finally found a jungle cat that likes water! I think it's because it's also part fish.";
							array[num2++] = "I don't know why this happened, and I don't want to know.";
							array[num2++] = "I just want it in my hands, and make it snappy!";
							flag = true;
							text = "\n(Caught in Jungle Surface)";
						}
						break;
					case 2453:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "There's a rumor going around that there are islands that float high up in the sky, and that they have amazing treasure!";
							array[num2++] = "Who cares about that though, what's even cooler is that sometimes lakes form in the clouds, and in those lakes are fish made out of clouds!";
							array[num2++] = "I wanna know what it tastes like, so you better go catch it for me!";
							flag = true;
							text = "\n(Caught in Sky Lakes)";
						}
						break;
					case 2454:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "There's a cursed fish swimming in the waters of the deepest corruption!";
							array[num2++] = "It was forged of the cursed flames that spread from the fallen horrors that lurk down there.";
							array[num2++] = "They say not even water can put out this fire, and that it can burn forever.";
							array[num2++] = "I can think of some awesome things I can do with a fish like that! You gonna go get it for me, or are you too chicken!?";
							flag = true;
							text = "\n(Caught in Corruption)";
						}
						break;
					case 2455:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "I was reeling in the big one when this funny talking zombie burst out of the forest lake and started rambling on about this 'ferocious' species of fish made out of dirt!";
							array[num2++] = "He says it could suffocate ten blokes his size, or something like that... I want it! NOW!";
							flag = true;
							text = "\n(Caught in Surface, Underground, & Caverns)";
						}
						break;
					case 2456:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "The demolitionist was raising cane about losing a stick of dynamite in the lake out in the forest. He has like, so many, so why does one matter?";
							array[num2++] = "Apparently, because it grew fins and started swimming away! I don't know where he gets his materials to make those things, but that one is clearly possessed!";
							array[num2++] = "Reel it in and bring it to me, I always wanted a suicide bombing fish! Don't ask why...";
							flag = true;
							text = "\n(Caught in Surface)";
						}
						break;
					case 2457:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "I bet you're not brave enough to find the Eater of Plankton.";
							array[num2++] = "A corrupt fish that was mutated from a severed piece of the Eater of Worlds itself!";
							array[num2++] = "Capture it and bring it to me, and prove to me you're not a wuss!";
							flag = true;
							text = "\n(Caught in Corruption)";
						}
						break;
					case 2458:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "I love collecting those bright yellow stars that fall from the sky! I love it even more when they land on someone's head.";
							array[num2++] = "But.. but.. nothing beats a star that falls in a foresty lake and turns into a fish!";
							array[num2++] = "That's just totally rad, and you're just rad enough to get it for me!";
							flag = true;
							text = "\n(Caught in Sky Lakes)";
						}
						break;
					case 2459:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "Apparently, Demon Eyes can sometimes be amphibious. They don't fly, they swim!";
							array[num2++] = "I want to see the look on someone's face when they find it in their bathtub!";
							array[num2++] = "They hang around the same areas. That means you reel one in for me!";
							flag = true;
							text = "\n(Caught in Sky Lakes & Surface)";
						}
						break;
					case 2460:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "I don't know what's worse, a bone fish or a bone fish with HANDS. This Fish-o-Tron deep in the caverns really freaks me out!";
							array[num2++] = "I think it's possessed by the same evil spirits that possessed that old man by the dungeon!";
							array[num2++] = "I double duck dare you to go catch it!";
							flag = true;
							text = "\n(Caught in Caverns)";
						}
						break;
					case 2461:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "I was trying to sleep by the hill lakeside when this fish swooped down at me. It was flying!";
							array[num2++] = "It also had the face of a lady and had feathers! I think I screamed louder than she did!";
							array[num2++] = "Hey you, go make her pay for scaring me like that!";
							flag = true;
							text = "\n(Caught in Sky Lakes & Surface)";
						}
						break;
					case 2462:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "There's a piece of the Hunger that morphed from the Wall of Flesh into a small fish-like thing that swims around aimlessly in the underworld and it's gross and it's yucky and I want it now!";
							flag = true;
							text = "\n(Caught in Caverns)";
						}
						break;
					case 2463:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "Did you know deep in the crimson, some of those creatures make this gross yellow stuff?";
							array[num2++] = "I overheard a crazy story about a pool of it having melted together into a shape of a fish and it swims around and everything!";
							array[num2++] = "Fetch it for me, so I can stick it in someone's toilet!";
							flag = true;
							text = "\n(Caught in Crimson)";
						}
						break;
					case 2464:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "Oooooohhh, I'm going to be SO rich! Deep in the caverns, there is a fish made out of gemstones!";
							array[num2++] = "Don't ask me how, I don't know, all I know is that this fish is totally awesome and you're going to catch it for me!";
							flag = true;
							text = "\n(Caught in Underground & Caverns)";
						}
						break;
					case 2465:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "There's some interesting critters to be found in the deeper Hallows, I tell you!";
							array[num2++] = "They glow this crazy purple color and it messes with my eyes!";
							array[num2++] = "It's totally wild, so I want you to catch a fish like that for me!";
							flag = true;
							text = "\n(Caught in Underground Hallow)";
						}
						break;
					case 2466:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "What's white and tan and fluffy and lives in a frozen underground lake? A mutant flinxfin!";
							array[num2++] = "I wasn't telling a joke, you know, there really is a mutated variety of Flinx that is more adapted to an aquatic lifestyle!";
							array[num2++] = "I want it to adapt to my fishbowl, so make sure that happens!";
							flag = true;
							text = "\n(Caught in Underground Tundra)";
						}
						break;
					case 2467:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "It's a whale! It's a dolphin! No, it's a penguin fish! Oh, and look, it's you!";
							array[num2++] = "You get to bring me one! You do know they only like cold water, right?";
							flag = true;
							text = "\n(Caught in Tundra)";
						}
						break;
					case 2468:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "There's a really really rare type of pixie that's born with so many wings that it can't actually fly!";
							array[num2++] = "It swims with the fishes in the lakes surrounded by that blue colored grass.";
							array[num2++] = "My fish tank needs a lamp, so I want you to catch me that pixie!";
							flag = true;
							text = "\n(Caught in Hallow)";
						}
						break;
					case 2469:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "I saw a fish that had eight legs! Nope! Not happening!";
							array[num2++] = "You're fishing it for me, so it's not alive when I hold it!";
							array[num2++] = "That's the last time I go fishing so deep in the cavern!";
							flag = true;
							text = "\n(Caught in Underground & Caverns)";
						}
						break;
					case 2470:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "You ever wonder why the lakes on the surface of the snowy areas of " + Main.worldName + " never ice over? I don't.";
							array[num2++] = "The fish, however, do! A fish made out of ice would make a great offering to the mighty and amazing " + str + "!";
							array[num2++] = "Go, my loyal subject, and bring me this Tundra Trout with haste!";
							flag = true;
							text = "\n(Caught in Surface Tundra)";
						}
						break;
					case 2471:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "Unicorns and rainbows are absolutely great! They're everywhere, even in the water.";
							array[num2++] = "No, really, I actually saw a unicorn fish in the Hallowed lake!";
							array[num2++] = "Your job is to reel it up and let me have it as a pet!";
							flag = true;
							text = "\n(Caught in Hallow)";
						}
						break;
					case 2472:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "Those demons in the underworld really like voodoo dolls, but I think there's a doll out there who was blasted with way too much magic!";
							array[num2++] = "It turned into a fish and it does stuff on its own. I dare you to go down and get me one!";
							array[num2++] = "I'd watch out for the boiling lava, because it burns you to death and that won't get me my fish!";
							flag = true;
							text = "\n(Caught in Caverns)";
						}
						break;
					case 2473:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "I know something youuuuu don't! Fine, I'll tell you, there's a terrifying creature that flies among the stars! I'm not making this up!";
							array[num2++] = "It's called a Wyvern! But, but, you knew that already, right? Well what you don't know is that they are born and raised as tadpoles!";
							array[num2++] = "So, they're actually like.. well, a frog! Hop to it and get me one!";
							flag = true;
							text = "\n(Caught in Sky Lakes)";
						}
						break;
					case 2474:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "You won't believe it! I caught a fish in the forest at night that was already dead! Then it tried to eat me! I threw it away and ran!";
							array[num2++] = "Now I want to stick it in someone's dresser to see what happens, so go fish it back up for me will ya?!";
							flag = true;
							text = "\n(Caught in Surface)";
						}
						break;
					case 2475:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "I found this spectacular place draped in giant glowing mushrooms! Everything was blue! I was picking some of the mushrooms I found next to a glistening blue lake, when one of the mushrooms snapped at me and swam away! I want to give it a taste of its own medicine, and give it a good chompin'! What I mean is, you gotta get it for me!";
							flag = true;
							text = "\n(Caught in Glowing Mushroom Fields)";
						}
						break;
					case 2476:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "Did you know there's magical islands that float up high in the sky? Bet you didn't! They say angels live in the sky, and I believe those angels have fins and gills and swim around! I believe you must catch one for me!";
							flag = true;
							text = "\n(Caught in Sky Lakes)";
						}
						break;
					case 2477:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "Ow! Don't get near me! I got stung by a Bloody Man-O-War! In case you're not smart enough to know what that is, it's the most menacing jellyfish in all of " + Main.worldName + "! Go to that rotten crimson and catch it if you dare! ";
							flag = true;
							text = "\n(Caught in Crimson)";
						}
						break;
					case 2478:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "Normally I could care less if I see fishbones floating in the water underground, but this one was swimming! What, you thought that only human skeletons still flailed about in " + Main.worldName + "? Get it for me so I can stick it in someone's bed!";
							flag = true;
							text = "\n(Caught in Underground & Caverns)";
						}
						break;
					case 2479:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "Out in the forest, I was fishing right? Well guess what! A bunny hopped up to me! Then another one hopped up, and another... suddenly I'm surrounded by bunnies! One even swam up to me from the water, but it had no legs! I fell outta my chair in surprise and all the bunnies scurried off! I want that bunny fish as a pet, so you better catch it for me! Pronto!";
							flag = true;
							text = "\n(Caught in Surface)";
						}
						break;
					case 2480:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "Yarr matey! Shiver me timbers! Avast, scallywags! There's a pirate captain who once had a pet fish named Cap'n Tunabeard, but during a big storm the fishbowl fell overboard! It has a hook for a tail, and an eyepatch and everything! You need to fetch me that fish, so I can be as cool as a pirate! Obviously it's out in the ocean somewhere! Duh!";
							flag = true;
							text = "\n(Caught in Ocean)";
						}
						break;
					case 2481:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "I saw this bright orange and colorful fish by the ocean, and it was looking around frantically as though it was seeking a lost family member! Go catch it for me, so that another one will show up looking frantically for him instead!";
							flag = true;
							text = "\n(Caught in Ocean)";
						}
						break;
					case 2482:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "I hear in the underworld, that the King of all demons is actually a fish! Just imagine the absolute power I would have if you caught it for me!";
							flag = true;
							text = "\n(Caught in Caverns)";
						}
						break;
					case 2483:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "Those Derplings in the jungle are the most scary creatures I've ever seen! Good thing is, sometimes they don't have legs! These ones live in the water and are a lot less scary! Catch me one now so I can see what they taste like without being scared half to death!";
							flag = true;
							text = "\n(Caught in Jungle Surface)";
						}
						break;
					case 2484:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "There's a legend of a mighty being known as the Fishron! It's part pig, part dragon, and part FISH! I hear it hangs around in the frozen subterranean lakes of the coldest part of the world! I'm not going there, so YOU go catch it and makes sure it lands in my hands! I'm so excited!";
							flag = true;
							text = "\n(Caught in Underground Tundra)";
						}
						break;
					case 2485:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "A really long fish that looks like a sword's sheath swims in the murky waters of the corruption! It looks a lot like ebonstone, so don't let it fool you! That's right, you. You're catching it, not me!";
							flag = true;
							text = "\n(Caught in Corruption)";
						}
						break;
					case 2486:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "Watch your step when wading through jungle waters! Why? No, not because I care about you being eaten by piranhas. I care because you'll step on one of my favorite kinds of fish, the Mud Fish! I also care a lot that you're going to grab me one as a pet!";
							flag = true;
							text = "\n(Caught in Jungle)";
						}
						break;
					case 2487:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "In the forest, the slimes are kinda gross. Slimefish are even more so! I don't want to swim with slimes, so yoink one out of the water for me!";
							flag = true;
							text = "\n(Caught Anywhere)";
						}
						break;
					case 2488:
						if (gotFish)
						{
							array = array2;
						}
						else
						{
							array[num2++] = "Piranhas and sharks are ugly! Soooo ugly! Did you know there's a fish that looks very pretty and still can eat your face off? I would pay 2 platinum to see that happen, by the way... To the point, though, you catchy for me. Just make sure I have it before you lose your face!";
							flag = true;
							text = "\n(Caught Jungle Surface)";
						}
						break;
				}
			}
>>>>>>> origin/master
		}

		public static string dialog(int l)
		{
			string text = NPC.firstNPCName(18);
			string text2 = NPC.firstNPCName(19);
			string text3 = NPC.firstNPCName(20);
			string text4 = NPC.firstNPCName(107);
			string text5 = NPC.firstNPCName(124);
			string text6 = NPC.firstNPCName(208);

			string str = NPC.firstNPCName(17);
			string str2 = NPC.firstNPCName(38);
			string str3 = NPC.firstNPCName(54);
			string str4 = NPC.firstNPCName(22);
			string str5 = NPC.firstNPCName(160);
			string str6 = NPC.firstNPCName(209);
			string str7 = NPC.firstNPCName(229);
			string str8 = NPC.firstNPCName(353);
			string str9 = NPC.firstNPCName(369);

			string result = "";

			switch (l)
			{
				case 1:
					result += "나와 크툴루의 눈 사이에 서있는게 뼈만 앙상한 자네가 전부이지 않길 바라네.";
					break;
				case 2:
					result += "그 조잡한 방어구좀 보게. 치료약을 좀 사는것이 어떤가?";
					break;
				case 3:
					result += "사악한 존재가 날 보고 있는것만 같아.";
					break;
				case 4:
					result += "보자기를 이기는건 검이지! 오늘 하나 사게나.";
					break;
				case 5:
					result += "무엇을 살텐가? 사과? 딸기? 파인에플? 횃불은 있는데";
					break;
				case 6:
					result += "좋은 아침이군, 그렇지 않나? 뭔가 필요한 것이 있나?";
					break;
				case 7:
					result += "곧 어둠이 우리 위를 덮을꺼야 친구. 선택할 수 있을때 하게.";
					break;
				case 8:
					result += "넌 해외에선 흙 블럭이 얼마나 잘 팔리는지 모를꺼야.";
					break;
				case 9:
					result += "아, 언젠가는 " + Main.player[Main.myPlayer].name + "의 전설이 퍼질꺼야... 좋은 이야기들만 말야.";
					break;
				case 10:
					result += "내 흙블럭들좀 보시게나! 훨씬 더 더럽지.";
					break;
				case 11:
					result += "어이, 저 태양은 뜨겁기만 하다네! 통풍이 잘되는 방어구가 있는데... 어떤가?.";
					break;
				case 12:
					result += "태양은 높지만, 내 가격은 아니야.";
					break;
				case 13:
					result += string.Concat(new string[]
				{
					"Oh, great. I can hear ",
					text5,
					" and ",
					text,
					" arguing from here."
				});
					break;
				case 14:
					result += "자네 혹시 그걸 본적이 있나?  키툴...시툴.. 채ㅌ...아 아니 그 큰 눈을 말야.";
					break;
				case 15:
					result += "어이, 이 집은 안전한거지? 그치? " + Main.player[Main.myPlayer].name + "?";
					break;
				case 16:
					result += "혈월도 자본주의를 막지는 못하지! 자 거래를 하자.";
					break;
				case 17:
					result += "상품에서 눈을 때지 말게, 렌즈도 사고 말야!";
					break;
				case 18:
					result += "코시, 케플렉 모그. 아 미안하네, 방금 그건 클링곤어로 '뭔가 사거나 죽게.' 라는 뜻이야.";
					break;
				case 19:
					result += Main.player[Main.myPlayer].name + " 맞지? 자네 이야길 많이 들었어, 친구!";
					break;
				case 20:
					result += "숨겨진 보물이 있다던데... 아, 신경쓰지 말게.";
					break;
				case 21:
					result += "천사상? 미안하게 됬군, 난 고물상인이 아니거든.";
					break;
				case 22:
					result += "자네 전의 사람은 나에게 쓰레ㄱ... 어 그러니까... 귀중품을 팔고 갔지!";
					break;
				case 23:
					result += "정말 궁금하군. 달은 치즈로 만들어진걸까?... 어, 뭐라고? 그래 맞아, 물건들좀 보게나!";
					break;
				case 24:
					result += "방금 금이라고 했나?  자네에게서 뜯어내고 말겠네 .";
					break;
				case 25:
					result += "워우, 저한테 피를 흘리진 마세요.";
					break;
				case 26:
					result += "서둘러요, 피좀 그만 흘리구요.";
					break;
				case 27:
					result += "죽을거 같으면... 밖에서 죽어요.";
					break;
				case 28:
					result += "도데체 그게 무슨 꿍꿍이신 거죠?!";
					break;
				case 29:
					result += "당신의 그 말투... 반갑지가 않군요.";
					break;
				case 30:
					result += "도데체 여긴 왜 온거에요? 피 흘리는게 아니라면, 여기 있을 필요는 없어요. 나가요.";
					break;
				case 31:
					result += "뭐라구요?!";
					break;
				case 32:
					result += "던젼 주변의 노인을 본적이 있어요? 불안해 하는 것 같던데.";
					break;
				case 33:
					result += "제발 " + str2 + " 님이 좀더 조심스러웠으면 해요. 그 사람 팔을 다시 붙이는것도 지긋지긋해요.";
					break;
				case 34:
					result += "저기요, 혹시 " + text2 + " 님이 어떤 이유든 간에 의사가 필요하다 한적 없나요? 그냥 궁금해서요.";
					break;
				case 35:
					result += "정말 " + str4 + " 님과 심각한 대화가 필요해요. 이번주만 해도 심각한 용암 화상으로 온게 몇번짼데요?";
					break;
				case 36:
					result += "이쪽이 더 나아 보이는군요.";
					break;
				case 37:
					result += "으으.... 당신 얼굴에 무슨일이 일어난 거에요?";
					break;
				case 38:
					result += "꺄아아아! 나...난 괜찮아요, 근데 당신처럼 괜찮진 않아요...";
					break;
				case 39:
					result += "이자리에 우린 지난 친구들에게 마지막 작고를 하기 위하여 모였어요... 어 안녕하세요? 괜찮아요. 당신은 좋아질꺼에요.";
					break;
				case 40:
					result += "저기, 팔을 나두고 갔던데요. 잠시만요...";
					break;
				case 41:
					result += "애처럼 굴지좀 말아요! 난 더한것도 봤어요.";
					break;
				case 42:
					result += "그건 꿰매야 겠는데요!";
					break;
				case 43:
					result += "또 그 나쁜 놈들이랑 어울렸나요?";
					break;
				case 44:
					result += "잠시만요, 뽀로로 반창고좀 찾아 올게요...";
					break;
				case 45:
					result += "남자답게 행동좀 해요, " + Main.player[Main.myPlayer].name + ", 괜찮아 질거에요. 어휴.";
					break;
				case 46:
					result += "그곳을 누르면 아픈가요? 그럼 누르질 마요.";
					break;
				case 47:
					result += "당신... 반쯤 소화된것 같아요. 슬라임들을 잡으러 다녔나요?";
					break;
				case 48:
					result += "제채기는 머리를 돌리고 해요.";
					break;
				case 49:
					result += "그 큰 상처는 제가 본것에 비하면 별거 아니에요... 맞아요, 더 큰것도 봤어요. 확실해요.";
					break;
				case 50:
					result += "사탕이라도 드릴까요?";
					break;
				case 51:
					result += "어디가 아픈지 보여주세요.";
					break;
				case 52:
					result += "죄송하지만, 절 고용하기엔...";
					break;
				case 53:
					result += "그것보단 돈이 더 필요해요.";
					break;
				case 54:
					result += "전 의료봉사원이 아니에요. 모르실까봐.";
					break;
				case 55:
					result += "전 행복한 결말따위 좋아하지 않아요.";
					break;
				case 56:
					result += "더이상은 안되요. 성형이라면 모를까.";
					break;
				case 57:
					result += "제 시간좀 뺏지 말아요.";
					break;
				case 58:
					result += "인형중에 " + str4 + " 녀석과 비슷한 인형이 지하 어딘가 있다더라고. 	그속에다 몇발 쏴 보고 싶군.";
					break;
				case 59:
					result += "빨리좀 해! " + text + " 간호사와 데이트 약속이 있단 말야.";
					break;
				case 60:
					result += "난 그 간호사, " + text + " 의 상품을 구매하고 싶군... 뭐? 그녀는 파는 상품이 없다고?";
					break;
				case 61:
					result += text3 + "? 그녀는 정말 매력적이야!  내숭쟁이라는게 정말 아쉽군.";
					break;
				case 62:
					result += str2 + " 녀석이랑은 어울리지도 마. 너한테 필요한건 내가 다 가지고 있어.";
					break;
				case 63:
					result += "도데체 " + str2 + " 저놈은 뭐하는 거야? 우리가 서로 다른 물건을 취급하는건 알고는 있는거야??";
					break;
				case 64:
					result += "누구랑도 얘기하기 싫은 밤이군. 안그래 " + Main.player[Main.myPlayer].name + "?";
					break;
				case 65:
					result += "오늘같은 밤이 좋아.	죽이고 싶은게 모자라지 않거든!";
					break;
				case 66:
					result += "이 미니샤크가 그렇게 궁금해?.. 어떻게 만들어졌는진 알고싶지 않을껄?.";
					break;
				case 67:
					result += "야 이거 영화 아냐. 탄약은 따로라고.";
					break;
				case 68:
					result += "내 물건에서 손때 , 이놈아!";
					break;
				case 69:
					result += "혹시 타락한 땅 흑단석에 정화가루를  뿌려보셨나요?";
					break;
				case 70:
					result += "제발 " + text2 + krEnd.End(text2, "이가") + " 그만 집적대면 좋겠어요. 내가 500살이 넘었다는건 모르나 보죠?";
					break;
				case 71:
					result += "왜 자꾸 " + str + krEnd.End(str, "이가") + " 나에게 천사상을 팔려는 건가요? 쓸모가 없다는건 모두가 아는 사실인데.";
					break;
				case 72:
					result += "던전 근처를 돌아다니는 노인을 보셨나요? 건강이 별로 좋아보이지 않던데...";
					break;
				case 73:
					result += "전 팔고싶은 것만 팔아요! 맘에 안드신다면, 안됐네요.";
					break;
				case 74:
					result += "왜 하필 이럴때에 대립적이신거죠?";
					break;
				case 75:
					result += "저는 당신이 제 물건을 사는걸 바라지 않아요. 당신이 내 물건을 사고 싶어하는걸 바랄 뿐이죠. ";
					break;
				case 76:
					result += "저기요, 그냥 기분탓인가요 아님 밖에 좀비가 엄청나게 많은건가요?";
					break;
				case 77:
					result += "당신은 타락한 이 세계를 정화해야만 해요.";
					break;
				case 78:
					result += "조심하세요! 테라리아는 당신을 필요로 해요!";
					break;
				case 79:
					result += "시간의 모래는 흐르고 있어요. 그리고 당신은 나이를 꼴사납게 먹는군요.";
					break;
				case 80:
					result += "제가 걱정했던것 만큼 그리 '나쁘지' 않다구요 무슨뜻이에요?";
					break;
				case 81:
					result += "두 고블린이 바에 들어갔는데, 한 고블린이 뭐라고 했는질 알아요? '맥주 고블릿으로 한잔 어때?!"; //말장난 '고블린'과 '고블릿'(유리잔) 의 발음이 비슷한 말장난
					break;
				case 82:
					result += "내 저주를 풀어주지 않는다면 던전에 들여보내주지 않을꺼요.";
					break;
				case 83:
					result += "들어가고 싶다면, 밤에 다시 오시오.";
					break;
				case 84:
					result += "내 마스터는 낮의 빛 아래 소환될 수 없소.";
					break;
				case 85:
					result += "당신은 내 저주를 풀어주기엔 너무 약하군.	 쓸모가 있어지면 다시 오시오.";
					break;
				case 86:
					result += "불쌍한 바보여.  당신이 내 주인을 상대하기엔 희망조차도 못한다오.";
					break;
				case 87:
					result += "난 당신이 여섯명의 친구와 함께이길 바라오. 당신 혼자겠지만.";
					break;
				case 88:
					result += "제발, 하지 마시오 낮선 이여. 당신을 죽이는 일만 될 뿐이라오.";
					break;
				case 89:
					result += "당신은 내 저주를 풀어주기에 충분하게 보이는군...";
					break;
				case 90:
					result += "낮선 이여, 당신은 내 마스터를 상대할 힘을 소유하고 있소?";
					break;
				case 91:
					result += "제발! 내 포획자를 상대하고 날 자유케 해 주시오! 이렇게 빌겠소!";
					break;
				case 92:
					result += "내 마스터와 싸워 이긴다면 던전으로 가는 길을 열어주겠소.";
					break;
				case 93:
					result += "까만 돌을 뚫고 싶다고, 에?  이 폭발물을 그 돌들에게 소개시켜주는건 어때!";
					break;
				case 94:
					result += "혹시 주변에서 광대를 본적이 있어?";
					break;
				case 95:
					result += "분명 폭탄을 여기 어디 두었는데, 도데체 찾을 수가 없네...";
					break;
				case 96:
					result += "좀비들을 상대할 만한 좋은게 있지!";
					break;
				case 97:
					result += text2 + "마저도 내 물건들을 사고싶어 한다고";
					break;
				case 98:
					result += "총알이 낫겠어 아님 폭탄이 낫겠어? 그냥 그렇다고.";
					break;
				case 99:
					result += "분명" + text + " 간호사가 팔을 붙이는데 도와줄꺼야. 이녀석들한테 당한다면 말야.";
					break;
				case 100:
					result += "그냥 날려버리면 되는데 정화를 할 필요가 있을까?";
					break;
				case 101:
					result += "이걸 욕조에 넣고 모든 창문을 닫아봐. 당신 코는 물론이고 귀까지 뚫어버릴껄!";
					break;
				case 102:
					result += "닭폭탄놀이 어때?";
					break;
				case 103:
					result += "저기, 여기에 서명좀 해주겠어? 테러 포기각서 말야";
					break;
				case 104:
					result += "담배는 나가서 펴!!";
					break;
				case 105:
					result += "폭탄의 인기가 폭발적이라고! .	너도 어서 하나 사!";
					break;
				case 106:
					result += "삶을 마감하기 좋은 날이로다!";
					break;
				case 107:
					result += "만약 이걸 이렇게 한다면... (펑)... 어이쿠, 미안, 혹시 그 다리가 필요해?";
					break;
				case 108:
					result += "다이너마이트, 내 특효약이지, 어떤 고통에도 잘 들어.";
					break;
				case 109:
					result += "내 물건들좀 봐줘; 폭탄 세일중이야!";
					break;
				case 110:
					result += "희미안 기억이지만 한 소자를 묶어 던전 속으로 던진 기억이 자꾸만 나";
					break;
				case 111:
					result += "... 문제가 생겼소, 밖에 블러드문이!";
					break;
				case 112:
					result += "만약 내가 젊었다면" + text + " 간호사를 불러냈을텐데... 소싯적엔 꾀나 여자를 부렸거든.";
					break;
				case 113:
					result += "어! 그 빨간 모자 어디서 본거 같은데";
					break;
				case 114:
					result += "다시한번 저주를 풀어준데 의해 감사를 표하지. 꼭 뭔가 뛰어오르며 날 물어뜯는 느낌이였거든.";
					break;
				case 115:
					result += "어머니께선 항상 내가 좋은 양복을 만들거라고 했지 .";
					break;
				case 116:
					result += "삶은 마치 옷이 가득한 상자와 같아; 뭘 입게 될지 모르지!";
					break;
				case 117:
					result += "물론 자수를 놓는건 힘들지! 만약 어렵지 않았다면, 누구도 하지 않았을꺼야! 그게 바로 자수가 멋진 이유지.";
					break;
				case 118:
					result += "난 의복 사업이라면 모든것을 꽤고 있지.";
					break;
				case 119:
					result += "저주받았을땐 외로웠어, 그래서 가죽으로 친구를 만들었지. 그 친구 이름은 윌슨이야.";
					break;
				case 120:
					result += "풀어줘서 고마워 인간. 다른 고블린들에 의해 여기 묶여 버려졌었어.	사이가 안 좋았다고 볼 수 있어.";
					break;
				case 121:
					result += "고블린들이 동쪽으로 가고 있지 않다는걸 지적한 이유로 날 여기 버리고 갔다는걸 정말 믿을수가 없어!";
					break;
				case 122:
					result += "난 이제 왕따니까, 가시공좀 버려도 되지? 주머니쪽이 아파.";
					break;
				case 123:
					result += "도구 전문자를 찾고 있어? 난 너의 고블린이야!";
					break;
				case 124:
					result += "도와줘서 고마워. 이제, 하릴없이 이곳을 돌아다녀야겠군. 언젠가 또 만나게 될꺼야.";
					break;
				case 125:
					result += "난 너가 키가 더 클줄 알았는데.";
					break;
				case 126:
					result += "저기...지금 혹시 " + text5 + krEnd.End(text5, "은는") + "뭐해? 말...말 나눠 본적 있어? 우연이라도?";
					break;
				case 127:
					result += "혹시 너의 모자에 모터가 필요하지 않아? 그 모자에 꼭 맞는 모터를 가지고 있는것 같은데.";
					break;
				case 128:
					result += "요, 너 로켓과 운동화를 좋아한다 들엇어,  그래서 로켓을 운동화 속에 넣었지.";
					break;
				case 129:
					result += "침묵은 금이야. 덕트 테이프는 은이고.";
					break;
				case 130:
					result += "그래 , 금이 철보다 강한지.  도데체 요즘 인간들은 뭘 배우는지.";
					break;
				case 131:
					result += "근데말야, 그 채광용-오리발 조합은 종이에서나 좋은 아이디어였어.";
					break;
				case 132:
					result += "고블린들은 쉽게 분노를 표하지. 사실, 옷때문에 전쟁이 일어나기도 해!";
					break;
				case 133:
					result += "솔직히 모든 고블린들이 로켓 연구가는 아냐. 글쌔, 몇명은.";
					break;
				case 134:
					result += "왜 우리가 이 가시공들을 들고 다니는지 알아? 내가 안들고 다니거든.";
					break;
				case 135:
					result += "방금 신상품을 개발했지! 이번꺼는 숨을 깊게 쉰다고 격렬하게 터지진 않을꺼야.";
					break;
				case 136:
					result += "고블린 도적들은 사실 자기 일을 제데로 하지도 못해. 잠겨있지 않은 창고에서 물건을 훔치지도 못하거든!";
					break;
				case 137:
					result += "살려줘서 고맙소 친구!  이 결박이 쓸리기 시작했거든.";
					break;
				case 138:
					result += "오! 나의 영웅!";
					break;
				case 139:
					result += "정말 영웅적이군! 살려줘서 고맙소, 젊은 아가씨!";
					break;
				case 140:
					result += "정말 영웅적이군! 살려줘서 고맙소, 젊은이!";
					break;
				case 141:
					result += "이제 서로 알았으니, 나도 너와 함께 살아도 되겠소?";
					break;
				case 142:
					result += "오, 안녕하신가, " + str4 + "! 오늘은 무엇을 도와드리면 좋겠소?";
					break;
				case 143:
					result += "오, 안녕하신가, " + str2 + "! 오늘은 무엇을 도와드리면 좋겠소?";
					break;
				case 144:
					result += "오, 안녕하신가, " + text4 + "! 오늘은 무엇을 도와드리면 좋겠소?";
					break;
				case 145:
					result += "오, 안녕하신가, " + text + "! 오늘은 무엇을 도와드리면 좋겠소?";
					break;
				case 146:
					result += "오, 안녕하신가, " + text5 + "! 오늘은 무엇을 도와드리면 좋겠소?";
					break;
				case 147:
					result += "오, 안녕하신가, " + text3 + "! 오늘은 무엇을 도와드리면 좋겠소?";
					break;
				case 148:
					result += "귀 뒤에서 동전 꺼내는 마술 보여줄까? 싫소? 알았소.";
					break;
				case 149:
					result += "혹시 마법 사탕은 어떻소? 싫소? 알았소.";
					break;
				case 150:
					result += "핫초코를 인챈팅 하는건 어떻...싫소? 알았소.";
					break;
				case 151:
					result += "내 수정구를 훔쳐보려고 왔소?";
					break;
				case 152:
					result += "혹시 돌을 슬라임으로 바꾸는 인챈트 반지를 가지고 싶은적이 있소? 글쎄, 나도 싫소.";
					break;
				case 153:
					result += "누군가 말하더군 우정은 마법이라고. 그렇게 멍청한 말이 또 어딨겠소? 우정으로는 사람들을 개구리로 만들수 없잖소.";
					break;
				case 154:
					result += "자네의 미래가 보이는군... 나에게서 많은 아이템을 살 것이란걸 말이오!";
					break;
				case 155:
					result += "천사상에게 생명을 불어넣는 시도도 해봣지. 아무일도 안일어나더군.";
					break;
				case 156:
					result += "고마워요!	이곳 스켈레톤처럼 끝나는건 시간문제였거든요.";
					break;
				case 157:
					result += "길좀 보고 다녀욧! 조금 전에도 여기였거든요?!";
					break;
				case 158:
					result += "잠깐만요, 분명 어디서 와이파이 신호가 잡혔는데...";
					break;
				case 159:
					result += "그...그치만 조금만 더하면 반짝전구를 달았는데!";
					break;
				case 160:
					result += "꼼짝마요! 컨택트렌즈를 떨어뜨렸어요.";
					break;
				case 161:
					result += "전 그저 스위치로...흐흐...... 뭐!";
					break;
				case 162:
					result += "제가 하나 맞춰볼까요?. 전선을 충분히 안샀죠?. 멍청이.";
					break;
				case 163:
					result += "그냥... 그냥 좀... 네? 오케이? 오케이. 어휴.";
					break;
				case 164:
					result += "그런 눈으로 보지마요. 지금 '일'하잖아요!.";
					break;
				case 165:
					result += string.Concat(new string[]
				{
					"저기, ",
					Main.player[Main.myPlayer].name,
					", 혹시  ",
					text4,
					"'의 집에서 오는 길인가요? 그가 우연히라도 제 말을 하던가요?"
				});
					break;
				case 166:
					result += text2 + " 님이 자꾸 갑압판이 누르는게 아니냐고 물어봐요. 밟는거라도 그렇게 말을 해도...";
					break;
				case 167:
					result += "필요한 전선보다 더 많이 준비해가요!";
					break;
				case 168:
					result += "혹시 제품의 플러그를 꼽은걸 확인했나요?";
					break;
				case 169:
					result += "혹시 이 집이 더 필요한게 뭔지 알아요? 반짝전구말이에요.";
					break;
				case 170:
					result += "하늘이 빨갛다면 블러드문이라는 뜻이죠. 무언가가 괴물들을 모여들게 하고 있어요.";
					break;
				case 171:
					result += "저기 친구. 사망초를 어디서 구하는지 알아요? 아뇨? 이유는 없어요; 그냥 궁금해서, 그게 전부에요.";
					break;
				case 172:
					result += "하늘을 봐봐요, 하늘을 보면 달이 빨간걸 알 수 있죠.";
					break;
				case 173:
					result += "밤에는 실내에 있는게 좋아요. 어둠속에선 밖을 돌아다니는게 위험해요.";
					break;
				case 174:
					result += "안녕하세요, " + Main.player[Main.myPlayer].name + "님. 어떻게 도와드릴까요?";
					break;
				case 175:
					result += "전 앞으로 뭘 해야할지 충고를 줄꺼에요.	 뭔가 막힌다면 저와 대화하는걸 추천하죠.";
					break;
				case 176:
					result += "당신이 살아남도록 도와주는 사람이 어딘가 있다던데... 아 잠깐만. 저 말이였네요.";
					break;
				case 177:
					result += "곡괭이를 사용하면 땅을 팔 수 있고, 도끼로는 나무를 팰 수 있죠. 마우스 커서를 블럭 위에 두고 클릭하시기만 하면 되요!";
					break;
				case 178:
					result += "살아남고 싶다면, 무기와 집을 만드는것이 좋아요. 나무를 베어 원목을 모으는 것부터 시작하세요.";
					break;
				case 179:
					result += "키보드에서 [" + Main.cInv + "] 를 눌러 조합창에 들어가봐요. 나무가 충분하다면, 작업대를 만들어요. 작업대에서 가까이에만 있다면 더 복잡한것도 만들 수 있어요.";
					break;
				case 180:
					result += "나무나 어떤 블럭으로도 집을 지을 수 있지요. 아참, 벽을 조합하여 설치하는것도 잊지 마세요,";
					break;
				case 181:
					result += "목검을 만들었다면, 슬라임들에게서 젤을 모아보세요. 나무와 합하여 횃불을 만들 수 있답니다!";
					break;
				case 182:
					result += "배경을 바꾸고 싶다면 망치를 사용해보세요!";
					break;
				case 183:
					result += "채광을 통해 금속 광석을 얻어야 해요. 그걸로 쓸모있는 것들을 만들 수 있지요.";
					break;
				case 184:
					result += "광석이 조금 있으니, 금속괴로 만들어야해요. 이 작업은 화로를 필요로 하지요!";
					break;
				case 185:
					result += "화로를 만드려면 횃불, 돌 그리고 나무가 많이 필요해요. 작업대 근처에 서는걸 까먹지 마시구요";
					break;
				case 186:
					result += "금속괴로 무언가 만드려면 모루가 필요해요.";
					break;
				case 187:
					result += "모루는 철로 만들거나, 상인에게서 구입이 가능해요.";
					break;
				case 188:
					result += "지하에 있는 생명의 결정은 생명력을 늘릴때 써요. 곡괭이로 캐낼 수 있지요.";
					break;
				case 189:
					result += "별을 세개 모으면, 마법 수용력을 늘릴 수 있는 아이템을 만들 수 있답니다.";
					break;
				case 190:
					result += "밤에는 별이 어디든 떨어지지요. 그것들론 유용한 것들을 만들 수 있어요. 해가 뜨면 사라지니 그 전에 모으세요.";
					break;
				case 191:
					result += "많은 방법으로 당신의 마을에 사람들을 불러모을 수 있어요. 물론 그들이 살 집이 필요하구요.";
					break;
				case 192:
					result += "집을 만드려면 문, 탁자, 의자와 광원이 필요해요. 벽을 나두는것도 잊지 말구요";
					break;
				case 193:
					result += "한 집에는 두사람이 살 수 없어요. 또한, 집이 파괴되면, 다른 집을 찾아 이동하지요.";
					break;
				case 194:
					result += "집 인터페이스를 사용해 주거지를 보고 변경할 수 있어요. 인벤토리를 열어 집 아이콘을 클릭해 보세요.";
					break;
				case 195:
					result += "돈이 아주 많으면 상인이 찾아올 거에요. 50 은전이면 될꺼에요!";
					break;
				case 196:
					result += "최대 생명력을 늘리면 간호사가 찾아올 거에요.";
					break;
				case 197:
					result += "내가 장담하건데, 총을 소지하면 무기상이 찾아올 거에요!";
					break;
				case 198:
					result += "강력한 괴물을 죽여 당신의 힘을 증명해 보세요. 숲의 요정의 관심을 끌꺼에요";
					break;
				case 199:
					result += "던전을 철저히 탐험해보세요. 깊은곳에 사람이 있을지도 몰라요!.";
					break;
				case 200:
					result += "아마 던전 근처에 있는 노인은 저주가 풀리면 우리를 찾아올 지도 몰라요.";
					break;
				case 201:
					result += "폭발물을 찾았다면 조금만 기다려보세요.폭탄상인이 한번 보고 싶어 할꺼에요.";
					break;
				case 202:
					result += "정말 고블린들은 우리와 달라서 같이 평화롭게 살 수 없나요?";
					break;
				case 203:
					result += "마법사가 이 세상 어디에 산다던데... 다음번에 지하에 가면 꼭 찾아보세요.";
					break;
				case 204:
					result += "악마의 제단에서 렌즈를 조합해 보세요, 강력한 괴물을 소환할 있는 아이템을 만들 수 있을거에요. 소환하려면 밤까지 기다려야 하지만요";
					break;
				case 205:
					result += "썩은 덩어리와 역겨운 가루를 조합하면 벌레 먹이를 만들 수 있어요. 쓰기전에 타락 지역에 있는지 확인하세요.";
					break;
				case 206:
					result += "악마의 제단은 타락 지역에서 흔히 볼 수 있어요. 어떤 아이템들은 조합할 때 그 제단 근처에 있어야해요.";
					break;
				case 207:
					result += "갈고리는 쇠사슬 3개와 갈고랑쇠로 만들 수 있지요. 보통은 지하에 있는 스켈레톤에게서 강고랑쇠 구할 수 있고, 철괴로 사슬을 만들 수 있지요.";
					break;
				case 208:
					result += "항아리가 보인다면 깨 보세요. 유용한 물건들이 많이 들어 있어요.";
					break;
				case 209:
					result += "이 세상 곳곳에 보물이 숨겨진거 알아요? 지하 깊숙한 곳엔 멋진것도 있지요!";
					break;
				case 210:
					result += "그림자 보주를 깨는 일은 유성을 떨어지게도 해요. 그림자 보주는 보통 타락한 땅 지하에서 발견되요 .";
					break;
				case 211:
					result += "지금은 생명의 결정을 모아 최대 생명력을 늘리는데 집중해야해요.";
					break;
				case 212:
					result += "지금 장비하고 있는 방어구는 소용이 없어요. 더 좋은 방어구를 만들어야 해요.";
					break;
				case 213:
					result += "당신은 이제 첫번째 큰 전투에 준비가 된 것 같아요. 밤이 오면 눈알으로부터 렌즈를 모아 악마의 제단으로 가져가보세요 .";
					break;
				case 214:
					result += "다음 도전을 위해서는 생명력이 더 필요해요. 하트 열 다섯개면 충분할 것 같아요.";
					break;
				case 215:
					result += "타락 지역에 있는 까만 돌은 숲의 요정한테서 산 가루로 정화시킬 수 있어요, 또는 폭발물로 부술 수 있구요.";
					break;
				case 216:
					result += "타락한 땅을 탐엄 하는게 다음 단계에요.	그림자 보주를 찾으면 부셔버리세요.";
					break;
				case 217:
					result += "여기서 멀지 않은 곳에 오래된 던전이 하나 있어요. 지금 그걸 확인하는것이 좋은 타이밍 인것 같네요.";
					break;
				case 218:
					result += "이제 남은 생명력을 마저 채워보시는건 어떤가요? 하트 20개를 모아봐요.";
					break;
				case 219:
					result += "아직 미발견된 보물이 정글 속에 많이 있어요, 충분히 깊게 파야 하지만요.";
					break;
				case 220:
					result += "지하세계는 지옥석이라는 물질로 만들어져 있지요. 방어구와 무기를 만드는데 딱이랍니다.";
					break;
				case 221:
					result += "지하세계의 수호자를 상대할 준비가 되면, 살아있는 제물을 희생시켜야해요. 필요한 모든것은 지하세계에 있답니다.";
					break;
				case 222:
					result += "악마의 제단을 찾아 부수세요. 무엇인가 좋은일이 일어날꺼에요!";
					break;
				case 223:
					result += "어떨때는 극에 달한 빛과 어둠이 있는곳에 타락한 생물이 영혼을 떨어뜨리기도 한답니다.";
					break;
				case 224:
					result += "호 호 호, 그리고 한 병의... 에그노그!";
					break;
				case 225:
					result += "쿠키는 안 구워 왔나?";
					break;
				case 226:
					result += "뭐라고? 내가 진짜가 아닌줄 알았다고?";
					break;
				case 227:
					result += "어떻게든 얼굴을 되돌려 놨어요. 다음엔 제발 조심히 좀 해요.";
					break;
				case 228:
					result += "아무래도 흉터가 남겠어요.";
					break;
				case 229:
					result += "다 나아졌어요. 이제 절벽에서 뛰어내리는 짓은 보고싶지 않네요.";
					break;
				case 230:
					result += "그렇게 안 아팠죠, 아팠나요?";
					break;
				case 231:
					result += "땅 속에서 사는건 그렇게 나쁘지 안았버섯, 너 같은 바보들이 내 아이들을 대려가는것만 빼면 말이버섯.";
					break;
				case 232:
					result += "우리 둘 사이에 말인버섯, " + text3 + " 요정이 내가 믿는 유일한 친구버섯. 걔만 날 먹으려들거나 포션으로 만들지 않았버섯.";
					break;
				case 233:
					result += "도데체 뭐가 대수인지 알기 위해 내 몸을 햝아보기도 했버섯, 근데 모든게 파란빛으로 빛나기 시작했버섯.";
					break;
				case 234:
					result += "파란걸 볼때마다버섯, 날 우울하게 만들고 게으르게 만들버섯.";
					break;
				case 235:
					result += "이 근처에서 돼지를 본 적이 없버섯? 내 동생은 다리 하나를 그들한테 잃엇버섯.";
					break;
				case 236:
					result += "이 마을의 모든 사람은 조금씩 이상버섯. 어젯밤에 깨보니 옷상인이 내 발을 먹고있었버섯.";
					break;
				case 237:
					result += "젊은이 옷에는 할인을 부과하겠소, 만약 젊은이가 " + str5 + krEnd.End(text5, "을를") + " 설득해서....치수! 치수를 재러 오게 만들면 말이오";
					break;
				case 238:
					result += "아마 " + str5 + " 님이 오해를 받는것 같아요, 참 재미있게 발효된 분이었는데."; //원문은 'fun guy'(재밋는 친구)는 'fungi'(곰팡이류)와 발음이 비슷함을 이용한 말장난
					break;
				case 240:
					result += "트러플 셔플'같은건 모른다버섯! 그만좀 물어봐버섯!";
					break;
				case 241:
					result += "나에 관한 큰 소문이 돌고있버섯, '그를 이기지 못한다면, 먹어버려!'라고 말버섯";
					break;
				case 242:
					result += "어머나, 도데체 너 속엔 뭐가 든거야?"; // Oy, whatchu got in you jiminy fluffer?
					break;
				case 243:
					result += "하이재커가 됬어야 할까? 고민 많이 했었는데.";
					break;
				case 244:
					result += "개의치 말고, 너한텐 제트팩이 잘 어울리겠는데!"; //뭐라는거야... ("Be it what it would, a jetpack would suit you nicely!")
					break;
				case 245:
					result += "I'm feeling a bit peevish as of late, so enough with your palaver you ragamuffin!";
					break;
				case 246:
					result += "I'm mighty curious about that " + str6 + " fellow. By what manner of consumption does he maintain such locomotion?";
					break;
				case 247:
					result += "That captain fellow seems to me to be 'pretty well over the bay' if you know what I mean!";
					break;
				case 248:
					result += "내게 톱니바퀴를 보여줘...!";
					break;
				case 249:
					result += "나는 너의 ... 톱니바퀴가 좋아. Does it come in brass?";
					break;
				case 250:
					result += "신성한 땅에 들어가면 하늘에 무지개가 있는걸 볼 수 있어. 그걸 색칠하고 싶으면 도와줄 수 있어.";
					break;
				case 251:
					result += "저 아이," + text6 + " 말야. 저 아이라면 마을을 온통 빨간색으로 칠할꺼야!";
					break;
				case 252:
					result += "난 터키옥 색이랑 청록색의 차이르 알아. 그렇지만 안알려줄꺼야.";
					break;
				case 253:
					result += "타이타늄 화이트는 다 나가고 없으니, 묻지를 말어.";
					break;
				case 254:
					result += "분홍색과 보라색의 스월리 디자인은 어때? 멩세하건데 이뻐!";
					break;
				case 255:
					result += "아냐아냐아냐... 회색이란게 얼마나 많은데! 말하게 하지마...";
					break;
				case 256:
					result += "페인트가 마르기 전에 비가 내리지 않았으면 좋겠어. 그건 재앙이나 마찬가지야!";
					break;
				case 257:
					result += "재무를 가져온다면 가장 화려한 색을 가져오지!";
					break;
				case 258:
					result += "어휴, 그리 칙칙한 옷을 입고 다니다니. 옷을 염색하는 법을 배워야겠어!";
					break;
				case 259:
					result += "The only kind of wood I would bother dyeing is RICH Mahogany. Dyeing any other wood is such a waste.";
					break;
				case 260:
					result += str7 + "한테 무슨 말좀 해봐요.  여기 왔다 갈때마다 냄새를 빼는데 일주일이나 걸린다구요";
					break;
				case 261:
					result += "무슨 마술사냐고? 난 주술사야."; // which doctor(어느 의사) 와 witch doctor(주술사) 의 발음이 비슷함을 이용한 말장난
					break;
				case 262:
					result += "마법의 심장은 자연이야. 심장의 본성은 마법이고."; // nature 이 다른 뜻으로 쓰임 (자연, 마법)을 이용한 말장난
					break;
				case 263:
					result += text + " 간호사는 치료를 도와주지만, 난 너의 몸이 너를 치료를 하게 만들 수 있어.";
					break;
				case 264:
					result += "신중히 선택해, " + Main.player[Main.myPlayer].name + ", 내 물건들은 변덕스럽고 나의 어두운 예술은, 불가사의하지.";
					break;
				case 265:
					result += "우리 얘기좀 해. ㅍ... 파티 말야.";
					break;
				case 266:
					result += "파티? 2차? 어떤게 더 좋은지 결정을 못하겠어.";
					break;
				case 267:
					result += "반짝이 꽃 파티를 만들자! 물론 2차도 준비하고 말야.";
					break;
				case 268:
					result += "와우, " + Main.player[Main.myPlayer].name + ", 모험적인 너를 만나니 파티가 하고싶어져!";
					break;
				case 269:
					result += "디스코 볼 설치좀 해줘, 그러면 파티를 어떻게 하는지 알려줄게";
					break;
				case 270:
					result += "스웨덴에 가본적이 있는데, 파티를 엄청 열광적이게 하더라고! 왜 너는 그러지 않은거야?";
					break;
				case 271:
					result += "내 이름은 " + text6 + " 인데 다들 나를 확깨는 여자라고 하더라고. 몰라아아 , 그래도 멋지게 들려.";
					break;
				case 272:
					result += "혹시 파티해? 가끔이라도? 흠, 우리 얘기좀 해...";
					break;
				case 273:
					result += "난 풋내기 선원이 아냐. 하지만 풋내기였다가 아닌게 아얘 풋내기가 아니였던것 보단 낫지"; //사랑을 하다가 사랑을 잃은 편이 사랑을 한 번도 안 해본 것 보다 낫다 의 사랑(love) 와 landlubber의 'lubb' 가 발음이 비슷한 것을 이용한 말장난
					break;
				case 274:
					result += "요 호 호 그리고 한병의 ....반짝이꽃!";
					break;
				case 275:
					result += "야알!	 정말 웃기는군 넌 내 앵무샐 말했어야 했어 왜냐하면!...엄...우리 먼 얘기 하고 있엇지?";
					break;
				case 276:
					result += Main.player[Main.myPlayer].name + ", 넌 선장이 2주동간 본 아가씨들 중에 가장 이쁘게 생겼군!";
					break;
				case 277:
					result += "내 뒤에서 비켜, 이 망나니야!";
					break;
				case 278:
					result += "도데체 먼 소리를 하는거야? 모비딕은 내꺼야!";
					break;
				case 279:
					result += "*야아아 내가 ㄱ르에서서어 *"; // 술에 취한 상태라네요
					break;
				case 280:
					result += "And then Unit 492-8 said, 'Who do you think I am, Unit 472-6?' HA. HA. HA.";
					break;
				case 281:
					result += "My expedition efficiency was critically reduced when a projectile impacted my locomotive actuator.";
					break;
				case 282:
					result += "This sentence is false , or is it?";
					break;
				case 283:
					result += "So that 'punk' lookin' chick is an inventor, eh? I think I could show her a thing or two!";
					break;
				case 284:
					result += "Sure, me and " + str7 + " are pals, but I hate it when his parrot does his business on me. That stuff's corrosive!";
					break;
				case 285:
					result += "I built myself a taste mechanism, so I can drink some ale!";
					break;
				case 286:
					result += "Sometimes I come off a bit... Get it? a bit?";
					break;
				case 287:
					result += "'Short back and sides' is it?";
					break;
				case 288:
					result += "Those highlights really bring out your eyes!";
					break;
				case 289:
					result += "My hands are sticky from all that... wax.";
					break;
				case 290:
					result += "Tea? Coffee? Or is it just orange juice again?";
					break;
				case 291:
					result += "Doll, we seriously need to fix those split ends.";
					break;
				case 292:
					result += "Gurrllll! You are my favorite gossip ever.";
					break;
				case 293:
					result += "Which aftershave can I interest you in today, sir?";
					break;
				case 294:
					result += "Sit down for a second and I'll have you steppin' razor.";
					break;
				case 295:
					result += "Either you have style, or you get styled.";
					break;
				case 296:
					result += "For you I think we'll do something... low maintenance.";
					break;
				case 297:
					result += "I tried using one of the Dye Master's products once. Ends fried. Disaster.";
					break;
				case 298:
					result += "Oh you poor, poor thing. Just... just sit down here. It'll be okay. Shhhh.";
					break;
				case 299:
					result += "Check my fresh.";
					break;
				case 300:
					result += "Hello sir, I'm " + str8 + ", and I'll be your barber today.";
					break;
				case 301:
					result += "Just a little off the top?  That's no fun...";
					break;
				case 302:
					result += "I hope you like what I did to " + text6 + "'s hair!";
					break;
				case 303:
					result += "There is nothing I can do for " + str2 + "'s singed head. He's a lost cause.";
					break;
				case 304:
					result += "Tipping IS optional, but remember I have access to scissors and your head.";
					break;
				case 305:
					result += "This is a cut-throat razer by the way.";
					break;
				case 306:
					result += "You better stay outta my hair tonight, hun. I just sharpened my scissors, and I'm looking for an excuse to use them!";
					break;
				case 307:
					result += string.Concat(new string[]
				{
					"Mhmm, I heard from ",
					text6,
					" that ",
					text5,
					"'s friend ",
					text,
					" spent her boyfriend's last paycheck on shoes."
				});
					break;
				case 308:
					result += "One time I put a wig on " + str6 + " just so I could cut his hair. I think he kinda liked it!";
					break;
				case 309:
					result += "I tried to visit " + str8 + " one time. She just looked at me and said 'nope.'";
					break;
				case 310:
					result += "I think it is about time I got my hair did!";
					break;
				case 311:
					result += "Did you even try to brush your hair today?";
					break;
				case 312:
					result += "So a pixie cut, would you like to keep some lady burns?";
					break;
				case 313:
					result += "I have no problem cleaning up ears and eyebrows, but I draw the line at nose hair.";
					break;
				case 314:
					result += "Alright, you sit and marinate. I'll be back to rinse your color out in 25 minutes...";
					break;
				case 315:
					result += "Thanks hun! Now I can finally do my hair.";
					break;
				case 316:
					result += "I would have given you a free cut if you'd come earlier.";
					break;
				case 317:
					result += "Don't go exploring with scissors, they said. You won't get trapped in a spider's web, they said!";
					break;
				case 318:
					result += "Ew, my hair, there's spider web all over it!";
					break;
				case 319:
					result += "Meet me behind " + str4 + "'s house in about three hours, I think I have something you will find very appealing.";
					break;
				case 320:
					result += "That " + str + ", he really has no appreciation for a really good deal.";
					break;
				case 321:
					result += "I sell only what I can get. " + str3 + " keeps hounding me for exotic clothing.";
					break;
				case 322:
					result += "Hmm, you look like you could use an Angel Statue! They slice, and dice, and make everything nice!";
					break;
				case 323:
					result += "I don't refund for \"buyer's remorse...\" Or for any other reason, really.";
					break;
				case 324:
					result += "Buy now and get free shipping!";
					break;
				case 325:
					result += "I sell wares from places that might not even exist!";
					break;
				case 326:
					result += "You want two penny farthings!? Make it one and we have a deal.";
					break;
				case 327:
					result += "Combination hookah and coffee maker! Also makes julienne fries!";
					break;
				case 328:
					result += "Come and have a look! One pound fish! Very, very good! One pound fish!";
					break;
				case 329:
					result += "If you're looking for junk, you've come to the wrong place.";
					break;
				case 330:
					result += "A thrift shop?  No, I am only selling the highest quality items on the market.";
					break;
				case 331:
					result += "Smashing a crimson heart will sometimes cause a meteor to fall out of the sky. crimson hearts can usually be found in the chasms around crimtane areas.";
					break;
				case 332:
					result += "Have you tried using purification powder on the crimstone of the crimson?";
					break;
				case 333:
					result += "You must cleanse the world of this crimson.";
					break;
				case 334:
					result += "Psst! I might have a job for you. Don't think you can say no, either!";
					break;
				case 335:
					result += "I want a fish and you're going to find me one! Ask me about it!";
					break;
				case 336:
					result += "Hey! Just the sacrifi- I mean competent fishing master that I've been looking for! ";
					break;
				case 337:
					result += str9 + " wants YOU as the official " + Main.worldName + " errand monkey!";
					break;
				case 338:
					result += "Whaaaat?! Can't you see I'm winding up fishing line??";
					break;
				case 339:
					result += "I have enough fish! I don't need your help right now!";
					break;
				case 340:
					result += "There's no chefs in all of " + Main.worldName + ", so I have to cook all this fish myself! ";
					break;
				case 341:
					result += "Hey! Watch it! I'm setting up traps for my biggest prank ever! No one will see it coming! Don't you dare tell anyone!";
					break;
				case 342:
					result += "Let a kid give you some advice, never touch your tongue to an ice block! Wait, forget what I said, I totally want to see you do it!";
					break;
				case 343:
					result += "Ever heard of a barking fish?! I haven't, I'm just wondering if you did!";
					break;
				case 344:
					result += Main.worldName + " is filled to the brim with the most outlandish kinds of fish!";
					break;
				case 345:
					result += "I'm bummed out! There's probably been fish that have gone extinct before I even was born, and that's not fair!";
					break;
				case 346:
					result += "I don't have a mommy or a daddy, but I have a lot of fish! It's close enough!";
					break;
				case 347:
					result += "Heh heh, you shoulda seen the look on " + text3 + "'s face when I stuck that piranha tooth in the chair!";
					break;
				case 348:
					result += "I have a request for you! No, I don't care that there's a zombie apocalypse right now!";
					break;
				case 349:
					result += "Hurry up and listen! I need you to catch something for me right now!";
					break;
				case 350:
					result += "I hate blood moons! I stay up all night because of all the scary noises!";
					break;
				case 351:
					result += "Blood moon is the worst time to fish! The fish bite, yes, but so do the zombies!";
					break;
				case 352:
					result += "There's a bajillion monsters running around out there right now!";
					break;
				case 353:
					result += "Thanks, I guess, for saving me or whatever. You'd be a great helper minion!";
					break;
				case 354:
					result += "Wha? Who might you be? I totally wasn't just drowning or anything!";
					break;
				case 355:
					result += "You saved me! You're awful nice, I could use you... er, I mean, totally hire you to do some awesome stuff for me!";
					break;
				case 356:
					result += "Got any spare bones for sale? I'm looking to replace my broken hip... again.";
					break;
				case 357:
					result += "Excellent! Someone's finally come by to take some of these maggots off my hands.";
					break;
				case 358:
					result += "There's no illness or condition that can't be cured by some of my Slime Oil! Trust me, it works, just look at my lively figure!";
					break;
				case 359:
					result += "You've got a real backbone coming way down here, how 'bout ya buy somethin?";
					break;
				case 360:
					result += "You would not believe some of the things people throw at me... Wanna buy some of it?";
					break;
				case 361:
					result += "I'd lend you a hand, but last time I did that, I didn't get it back for a month";
					break;
				case 362:
					result += "Stay away from the spiders. They'll suck out your insides and leave you a hollow shell of a man. Trust me on this one.";
					break;
				case 363:
					result += "The only things constant in this world are death and taxes, I've got both!";
					break;
				case 364:
					result += "You again? Suppose you want more money!?";
					break;
				case 365:
					result += "Must everyone open and shut doors so incredibly noisily around here?!";
					break;
				case 366:
					result += "I see you're free of time, as usual. Can't imagine what work life would be for your kind of folk.";
					break;
				case 367:
					result += "Yes, yes, yes! -- I'll give you your share in just a moment. I'd think you to be a bit more patient, what with me doing all the work and all.";
					break;
				case 368:
					result += "What does a man have to do to be left alone in this place? Go bugger someone less busy!";
					break;
				case 369:
					result += "...two barrels of molasses, plus -- Oh, nevermind that, you're here. Here's your money.";
					break;
				case 370:
					result += "Just between you and me... I have no idea why they're bothering to pay the rent";
					break;
				case 371:
					result += "Tried to get " + text3 + " to pay me with favors once, now I have fungus growing in strange places.";
					break;
				case 372:
					result += "Go tell " + text2 + " to stop offering to pay me with ammo, I don't even own a gun.";
					break;
				case 373:
					result += "Why don't YOU try collecting money from " + str2 + " and not losing a hand or foot or...";
					break;
				case 374:
					result += "I just came from " + str + "'s. He wanted to know if I took credit cards.";
					break;
				case 380:
					result += "Here's your cut of the taxes that I've taken from our surplus population!";
					break;
				case 381:
					result += "Here you are again, taking all my coin! Just grab it and begone from my sight!";
					break;
				case 382:
					result += "Bah! Here, take your shillings and get out of my sight!";
					break;
				case 383:
					result += "This is all you're gonna get for now, not a penny more! Take it and spend it wisely.";
					break;
				case 390:
					result += "...And people call me greedy? No, I have nothing else for you.";
					break;
				case 391:
					result += "Oh, so you just see me as a coin sign, eh? 'Cus every time you see me, you ask me.";
					break;
				case 392:
					result += "Don't you ever stop just to say 'Hi?'";
					break;
				case 393:
					result += "Bah! You again? You just grabbed some of my coin just moments ago, so bugger off and come back later!";
					break;
				case 394:
					result += "I just gave you half a crown five minutes ago! Scram!";
					break;
				case 395:
					result += "Reaching into my moneybags again already!? And you call ME greedy.";
					break;
				case 396:
					result += "You just received your pay, and not a farthing more! Get out!";
					break;
				case 397:
					result += "Money doesn't grow on trees, so don't overpick my fruit! Bah! ";
					break;
				case 398:
					result += "You already managed to spend every pence I paid you!? Bah, I'm not a charity, go kill a slime!";
					break;
				case 399:
					result += "Not so fast! You got your money, now begone! ";
					break;
				case 400:
					result += "Begging so soon?! Don't look at me like I'll have a change of heart overnight! ";
					break;
				case 401:
					result += "Make sure to smash any crimson altar you can find. Something good is bound to happen if you do!";
					break;
				case 402:
					result += "Crimson altars can usually be found in the crimson. You will need to be near them to craft some items.";
					break;
				case 403:
					result += "You can create a bloody spine with vertebrae. Make sure you are in a crimtane area before using it.";
					break;
				default:
					result += "ERROR";
					break;
			}

			return result;
		}

		public static string setBonus(int l)
		{
			string result = "";

			switch (l)
			{
				case 0:
					result += "방어 +2";
					break;
				case 1:
					result += "방어 +3";
					break;
				case 2:
					result += "이동속도 +15%";
					break;
				case 3:
					result += "스페이스 건의 마나 소모 없음";
					break;
				case 4:
					result += "탄을 쓰지 않을 확률 +20%";
					break;
				case 5:
					result += "16% reduced mana usage";
					break;
				case 6:
					result += "추가 대미지 +17%";
					break;
				case 7:
					result += "채광 속도 +30%";
					break;
				case 8:
					result += "14% reduced mana usage";
					break;
				case 9:
					result += "공격 속도 +15%";
					break;
				case 10:
					result += "탄을 쓰지 않을 확률 +20%";
					break;
				case 11:
					result += "17% reduced mana usage";
					break;
				case 12:
					result += "5% increased melee critical strike chance";
					break;
				case 13:
					result += "20% chance to not consume ammo";
					break;
				case 14:
					result += "19% reduced mana usage";
					break;
				case 15:
					result += "18% increased melee and movement speed";
					break;
				case 16:
					result += "25% chance to not consume ammo";
					break;
				case 17:
					result += "20% reduced mana usage";
					break;
				case 18:
					result += "19% increased melee and movement speed";
					break;
				case 19:
					result += "25% chance to not consume ammo";
					break;
				case 20:
					result += "1 defense";
					break;
				case 21:
					result += "Greatly increased life regen";
					break;
				case 22:
					result += "Melee and ranged attacks cause frostburn";
					break;
				case 23:
					result += "Increases your max number of minions";
					break;
				case 24:
					result += "Greatly increases life regeneration after striking an enemy";
					break;
				case 25:
					result += "Flower petals will fall on your target for extra damage";
					break;
				case 26:
					result += "Become immune after striking an enemy";
					break;
				case 27:
					result += "Summons a powerful leaf crystal to shoot at nearby enemies";
					break;
				case 28:
					result += "10% increased magic critical strike chance";
					break;
				case 29:
					result += "Attackers also take full damage";
					break;
				case 30:
					result += "Magic damage done to enemies heals the player with lowest health";
					break;
				case 31:
					result += "Not moving puts you in stealth,\nincreasing ranged ability and reducing chance for enemies to target you";
					break;
				case 32:
					result += "4 defense";
					break;
				case 33:
					result += "10% increased damage";
					break;
				case 34:
					result += "Increases minion damage by 25%";
					break;
				case 35:
					result += "Magic damage done will hurt extra nearby enemies";
					break;
				case 36:
					result += "Increases maximum mana by 60";
					break;
				case 37:
					result += "Beetles protect you from damage";
					break;
				case 38:
					result += "Beetles increase your melee damage and speed";
					break;
				case 39:
					result += "Increases minion damage by 10%";
					break;
				case 40:
					result += "Increases minion damage by 12%";
					break;
				case 41:
					result += "33% chance to not consume thrown item";
					break;
				case 42:
					result += "50% chance to not consume thrown item";
					break;
				case 43:
					result += "Solar shields generate over time protecting you,\nconsume the shield power to dash, damaging enemies";
					break;
				case 44:
					result += "Double tap " + (Main.ReversedUpDownArmorSetBonuses ? "UP" : "DOWN") + " to toggle stealth,\nincreasing ranged ability and reducing chance for enemies to target you but slowing movement speed";
					break;
				case 45:
					result += "Hurting enemies has a chance to spawn buff boosters,\npick boosters up to get stacking buffs";
					break;
				case 46:
					result += "Double tap " + (Main.ReversedUpDownArmorSetBonuses ? "UP" : "DOWN") + " to direct your guardian to a location";
					break;
			}

			return result;
		}

		public static string npcName(int l)
		{
			string result = "";

			switch (l)
			{
				case -65:
					result += "말벌";
					break;
				case -64:
					result += "말벌";
					break;
				case -63:
					result += "말벌";
					break;
				case -62:
					result += "말벌";
					break;
				case -61:
					result += "말벌";
					break;
				case -60:
					result += "말벌";
					break;
				case -59:
					result += "말벌";
					break;
				case -58:
					result += "말벌";
					break;
				case -57:
					result += "말벌";
					break;
				case -56:
					result += "말벌";
					break;
				case -55:
					result += "좀비";
					break;
				case -54:
					result += "좀비";
					break;
				case -53:
					result += "해골";
					break;
				case -52:
					result += "해골";
					break;
				case -51:
					result += "해골";
					break;
				case -50:
					result += "해골";
					break;
				case -49:
					result += "해골";
					break;
				case -48:
					result += "해골";
					break;
				case -47:
					result += "해골";
					break;
				case -46:
					result += "해골";
					break;
				case -45:
					result += "좀비";
					break;
				case -44:
					result += "좀비";
					break;
				case -43:
					result += "악마의 눈";
					break;
				case -42:
					result += "악마의 눈";
					break;
				case -41:
					result += "악마의 눈";
					break;
				case -40:
					result += "악마의 눈";
					break;
				case -39:
					result += "악마의 눈";
					break;
				case -38:
					result += "악마의 눈";
					break;
				case -37:
					result += "좀비";
					break;
				case -36:
					result += "좀비";
					break;
				case -35:
					result += "좀비";
					break;
				case -34:
					result += "좀비";
					break;
				case -33:
					result += "좀비";
					break;
				case -32:
					result += "좀비";
					break;
				case -31:
					result += "좀비";
					break;
				case -30:
					result += "좀비";
					break;
				case -29:
					result += "좀비";
					break;
				case -28:
					result += "좀비";
					break;
				case -27:
					result += "좀비";
					break;
				case -26:
					result += "좀비";
					break;
				case -25:
					result += "진홍 슬라임";
					break;
				case -24:
					result += "진홍 슬라임";
					break;
				case -23:
					result += "크리메라";
					break;
				case -22:
					result += "크리메라";
					break;
				case -21:
					result += "이끼 말벌";
					break;
				case -20:
					result += "이끼 말벌";
					break;
				case -19:
					result += "이끼 말벌";
					break;
				case -18:
					result += "이끼 말벌";
					break;
				case -17:
					result += "말벌";
					break;
				case -16:
					result += "말벌";
					break;
				case -15:
					result += "무장 해골";
					break;
				case -14:
					result += "성난 해골";
					break;
				case -13:
					result += "성난 해골";
					break;
				case -12:
					result += "영혼을 먹는 자";
					break;
				case -11:
					result += "영혼을 먹는 자";
					break;
				case -10:
					result += "정글 슬라임";
					break;
				case -9:
					result += "노란 슬라임";
					break;
				case -8:
					result += "빨간 슬라임";
					break;
				case -7:
					result += "보라 슬라임";
					break;
				case -6:
					result += "검정 슬라임";
					break;
				case -5:
					result += "새끼 슬라임";
					break;
				case -4:
					result += "핑키";
					break;
				case -3:
					result += "초록 슬라임";
					break;
				case -2:
					result += "슬라이머";
					break;
				case -1:
					result += "슬라이머링";
					break;
				case 1:
					result += "파란 슬라임";
					break;
				case 2:
					result += "악마의 눈";
					break;
				case 3:
					result += "좀비";
					break;
				case 4:
					result += "크툴후의 눈";
					break;
				case 5:
					result += "크툴후의 하수인";
					break;
				case 6:
					result += "영혼을 먹는 자";
					break;
				case 7:
					result += "포식귀";
					break;
				case 8:
					result += "포식귀";
					break;
				case 9:
					result += "포식귀";
					break;
				case 10:
					result += "거대 지렁이";
					break;
				case 11:
					result += "거대 지렁이";
					break;
				case 12:
					result += "거대 지렁이";
					break;
				case 13:
					result += "세상을 먹는 자";
					break;
				case 14:
					result += "세상을 먹는 자";
					break;
				case 15:
					result += "세상을 먹는 자";
					break;
				case 16:
					result += "어미 슬라임";
					break;
				case 17:
					result += "상인";
					break;
				case 18:
					result += "간호사";
					break;
				case 19:
					result += "무기상";
					break;
				case 20:
					result += "숲의 요정";
					break;
				case 21:
					result += "해골";
					break;
				case 22:
					result += "안내자";
					break;
				case 23:
					result += "운석 머리";
					break;
				case 24:
					result += "불도깨비";
					break;
				case 25:
					result += "불타는 구체";
					break;
				case 26:
					result += "고블린 보병";
					break;
				case 27:
					result += "고블린 도적";
					break;
				case 28:
					result += "고블린 전사";
					break;
				case 29:
					result += "고블린 마법사";
					break;
				case 30:
					result += "혼돈의 구";
					break;
				case 31:
					result += "화가난 해골";
					break;
				case 32:
					result += "어둠의 마법사";
					break;
				case 33:
					result += "물의 구체";
					break;
				case 34:
					result += "저주받은 해골";
					break;
				case 35:
					result += "해골";
					break;
				case 36:
					result += "해골";
					break;
				case 37:
					result += "영감";
					break;
				case 38:
					result += "파괴자";
					break;
				case 39:
					result += "뼈다귀 뱀";
					break;
				case 40:
					result += "뼈다귀 뱀";
					break;
				case 41:
					result += "뼈다귀 뱀";
					break;
				case 42:
					result += "말벌";
					break;
				case 43:
					result += "식인 식물";
					break;
				case 44:
					result += "언데드 광부";
					break;
				case 45:
					result += "팀";
					break;
				case 46:
					result += "토끼";
					break;
				case 47:
					result += "타락한 토끼";
					break;
				case 48:
					result += "하피";
					break;
				case 49:
					result += "동굴 박쥐";
					break;
				case 50:
					result += "왕 슬라임";
					break;
				case 51:
					result += "정글 박쥐";
					break;
				case 52:
					result += "본즈 박사";
					break;
				case 53:
					result += "신랑";
					break;
				case 54:
					result += "재봉사";
					break;
				case 55:
					result += "금붕어";
					break;
				case 56:
					result += "스내쳐";
					break;
				case 57:
					result += "타락한 금붕어";
					break;
				case 58:
					result += "피라냐";
					break;
				case 59:
					result += "용암 슬라임";
					break;
				case 60:
					result += "지옥박쥐";
					break;
				case 61:
					result += "대머리 독수리";
					break;
				case 62:
					result += "악마";
					break;
				case 63:
					result += "파란 해파리";
					break;
				case 64:
					result += "분홍 해파리";
					break;
				case 65:
					result += "상어";
					break;
				case 66:
					result += "부두 악마";
					break;
				case 67:
					result += "게";
					break;
				case 68:
					result += "던전 수호자";
					break;
				case 69:
					result += "개미귀신";
					break;
				case 70:
					result += "스파이크 볼";
					break;
				case 71:
					result += "던전 슬라임";
					break;
				case 72:
					result += "불타는 바퀴";
					break;
				case 73:
					result += "고블린 정찰병";
					break;
				case 74:
					result += "새";
					break;
				case 75:
					result += "픽시";
					break;
				case 77:
					result += "무장한 해골";
					break;
				case 78:
					result += "미라";
					break;
				case 79:
					result += "어둠의 미라";
					break;
				case 80:
					result += "빛의 미라";
					break;
				case 81:
					result += "타락한 슬라임";
					break;
				case 82:
					result += "망령";
					break;
				case 83:
					result += "저주받은 망치";
					break;
				case 84:
					result += "마법이 깃든 검";
					break;
				case 85:
					result += "미믹";
					break;
				case 86:
					result += "유니콘";
					break;
				case 87:
					result += "와이번";
					break;
				case 88:
					result += "와이번";
					break;
				case 89:
					result += "와이번";
					break;
				case 90:
					result += "와이번";
					break;
				case 91:
					result += "와이번";
					break;
				case 92:
					result += "와이번";
					break;
				case 93:
					result += "거대한 박쥐";
					break;
				case 94:
					result += "타락귀";
					break;
				case 95:
					result += "디거";
					break;
				case 96:
					result += "디거";
					break;
				case 97:
					result += "디거";
					break;
				case 98:
					result += "월드 피더";
					break;
				case 99:
					result += "월드 피더";
					break;
				case 100:
					result += "월드 피더";
					break;
				case 101:
					result += "클링어";
					break;
				case 102:
					result += "아귀";
					break;
				case 103:
					result += "초록 해파리";
					break;
				case 104:
					result += "늑대인간";
					break;
				case 105:
					result += "묶여있는 고블린";
					break;
				case 106:
					result += "묶여있는 마법사";
					break;
				case 107:
					result += "고블린 뗌장이";
					break;
				case 108:
					result += "마법사";
					break;
				case 109:
					result += "광대";
					break;
				case 110:
					result += "해골 궁수";
					break;
				case 111:
					result += "고블린 궁수";
					break;
				case 112:
					result += "더러운 침";
					break;
				case 113:
					result += "육체의 벽";
					break;
				case 114:
					result += "육체의 벽";
					break;
				case 115:
					result += "굶주린 자";
					break;
				case 116:
					result += "굶주린 자";
					break;
				case 117:
					result += "거머리";
					break;
				case 118:
					result += "거머리";
					break;
				case 119:
					result += "거머리";
					break;
				case 120:
					result += "혼돈의 정령";
					break;
				case 121:
					result += "슬라이머";
					break;
				case 122:
					result += "복족류";
					break;
				case 123:
					result += "묶여있는 기계공";
					break;
				case 124:
					result += "기계공";
					break;
				case 125:
					result += "레티나이저";
					break;
				case 126:
					result += "스파즈마티즘";
					break;
				case 127:
					result += "스켈레트론 프라임";
					break;
				case 128:
					result += "프라임 캐논";
					break;
				case 129:
					result += "프라임 소우";
					break;
				case 130:
					result += "프라임 바이스";
					break;
				case 131:
					result += "프라임 레이저";
					break;
				case 132:
					result += "좀비";
					break;
				case 133:
					result += "방황하는 눈";
					break;
				case 134:
					result += "파괴자";
					break;
				case 135:
					result += "파괴자";
					break;
				case 136:
					result += "파괴자";
					break;
				case 137:
					result += "발광 박쥐";
					break;
				case 138:
					result += "발광 슬라임";
					break;
				case 139:
					result += "탐사정";
					break;
				case 140:
					result += "빙의된 갑옷";
					break;
				case 141:
					result += "독성 진흙";
					break;
				case 142:
					result += "산타 클로스";
					break;
				case 143:
					result += "눈사람 갱스터";
					break;
				case 144:
					result += "미스터 스태비";
					break;
				case 145:
					result += "스노우 벨라";
					break;
				case 147:
					result += "얼음 슬라임";
					break;
				case 148:
					result += "펭귄";
					break;
				case 149:
					result += "펭귄";
					break;
				case 150:
					result += "얼음 박쥐";
					break;
				case 151:
					result += "용암 박쥐";
					break;
				case 152:
					result += "거대한 비행 여우";
					break;
				case 153:
					result += "거대한 거북이";
					break;
				case 154:
					result += "얼음 거북이";
					break;
				case 155:
					result += "늑대";
					break;
				case 156:
					result += "붉은 악마";
					break;
				case 157:
					result += "피라루쿠";
					break;
				case 158:
					result += "뱀파이어";
					break;
				case 159:
					result += "뱀파이어";
					break;
				case 160:
					result += "송로버섯";
					break;
				case 161:
					result += "좀비 에스키모";
					break;
				case 162:
					result += "프랑켄슈타인";
					break;
				case 163:
					result += "검은 은둔자";
					break;
				case 164:
					result += "월 크리퍼";
					break;
				case 165:
					result += "월 크리퍼";
					break;
				case 166:
					result += "정체불명의 늪생물";
					break;
				case 167:
					result += "언데드 바이킹";
					break;
				case 168:
					result += "타락한 펭귄";
					break;
				case 169:
					result += "얼음 정령";
					break;
				case 170:
					result += "돼지용";
					break;
				case 171:
					result += "돼지용";
					break;
				case 172:
					result += "룬의 마법사";
					break;
				case 173:
					result += "크리메라";
					break;
				case 174:
					result += "허플링";
					break;
				case 175:
					result += "화가난 사냥꾼";
					break;
				case 176:
					result += "이끼 말벌";
					break;
				case 177:
					result += "더플링";
					break;
				case 178:
					result += "스팀펑커";
					break;
				case 179:
					result += "진홍 도끼";
					break;
				case 180:
					result += "돼지용";
					break;
				case 181:
					result += "얼굴 괴물";
					break;
				case 182:
					result += "플로티 글로스";
					break;
				case 183:
					result += "진홍 슬라임";
					break;
				case 184:
					result += "가시박힌 얼음 슬라임";
					break;
				case 185:
					result += "스노우 플링스";
					break;
				case 186:
					result += "좀비";
					break;
				case 187:
					result += "좀비";
					break;
				case 188:
					result += "좀비";
					break;
				case 189:
					result += "좀비";
					break;
				case 190:
					result += "악마의 눈";
					break;
				case 191:
					result += "악마의 눈";
					break;
				case 192:
					result += "악마의 눈";
					break;
				case 193:
					result += "악마의 눈";
					break;
				case 194:
					result += "악마의 눈";
					break;
				case 195:
					result += "길 잃은 소녀";
					break;
				case 196:
					result += "님프";
					break;
				case 197:
					result += "무장한 바이킹";
					break;
				case 198:
					result += "리자드";
					break;
				case 199:
					result += "리자드";
					break;
				case 200:
					result += "좀비";
					break;
				case 201:
					result += "해골";
					break;
				case 202:
					result += "해골";
					break;
				case 203:
					result += "해골";
					break;
				case 204:
					result += "가시박힌 정글 슬라임";
					break;
				case 205:
					result += "나방";
					break;
				case 206:
					result += "얼음에 뒤덮힌 인어";
					break;
				case 207:
					result += "염료상";
					break;
				case 208:
					result += "파티 소녀";
					break;
				case 209:
					result += "사이보그";
					break;
				case 210:
					result += "꿀벌";
					break;
				case 211:
					result += "꿀벌";
					break;
				case 212:
					result += "해적 갑판원";
					break;
				case 213:
					result += "해적단";
					break;
				case 214:
					result += "해적 애꾸눈";
					break;
				case 215:
					result += "해적 석궁사";
					break;
				case 216:
					result += "해적 선장";
					break;
				case 217:
					result += "코치닐 딱정벌레";
					break;
				case 218:
					result += "청록색 딱정벌레";
					break;
				case 219:
					result += "랙 딱정벌레";
					break;
				case 220:
					result += "소라";
					break;
				case 221:
					result += "오징어";
					break;
				case 222:
					result += "여왕벌";
					break;
				case 223:
					result += "좀비";
					break;
				case 224:
					result += "날치";
					break;
				case 225:
					result += "우산 슬라임";
					break;
				case 226:
					result += "날아다니는 뱀";
					break;
				case 227:
					result += "화가";
					break;
				case 228:
					result += "주술사";
					break;
				case 229:
					result += "해적";
					break;
				case 230:
					result += "금붕어";
					break;
				case 231:
					result += "말벌";
					break;
				case 232:
					result += "말벌";
					break;
				case 233:
					result += "말벌";
					break;
				case 234:
					result += "말벌";
					break;
				case 235:
					result += "말벌";
					break;
				case 236:
					result += "정글 크리퍼";
					break;
				case 237:
					result += "정글 크리퍼";
					break;
				case 238:
					result += "검은 은둔자";
					break;
				case 239:
					result += "블러드 크롤러";
					break;
				case 240:
					result += "블러드 크롤러";
					break;
				case 241:
					result += "블러드 피더";
					break;
				case 242:
					result += "블러드 젤리";
					break;
				case 243:
					result += "얼음 골렘";
					break;
				case 244:
					result += "무지갯빛 슬라임";
					break;
				case 245:
					result += "골렘";
					break;
				case 246:
					result += "골렘 머리";
					break;
				case 247:
					result += "골렘 주먹";
					break;
				case 248:
					result += "골렘 주먹";
					break;
				case 249:
					result += "골렘 머리";
					break;
				case 250:
					result += "화가난 비구름";
					break;
				case 251:
					result += "아이저";
					break;
				case 252:
					result += "앵무새";
					break;
				case 253:
					result += "사신";
					break;
				case 254:
					result += "좀비";
					break;
				case (int)byte.MaxValue:
					result += "좀비";
					break;
				case 256:
					result += "버섯 해파리";
					break;
				case 257:
					result += "버섯 집게";
					break;
				case 258:
					result += "무시 무당벌레";
					break;
				case 259:
					result += "버섯 구근";
					break;
				case 260:
					result += "거대한 버섯 구근";
					break;
				case 261:
					result += "버섯 포자";
					break;
				case 262:
					result += "플렌테라";
					break;
				case 263:
					result += "플렌테라의 갈고리";
					break;
				case 264:
					result += "플렌테라의 촉수";
					break;
				case 265:
					result += "포자";
					break;
				case 266:
					result += "크툴후의 뇌";
					break;
				case 267:
					result += "크리퍼";
					break;
				case 268:
					result += "이코르 스티커";
					break;
				case 269:
					result += "녹슨 무장 해골";
					break;
				case 270:
					result += "녹슨 무장 해골";
					break;
				case 271:
					result += "녹슨 무장 해골";
					break;
				case 272:
					result += "녹슨 무장 해골";
					break;
				case 273:
					result += "파란 무장 해골";
					break;
				case 274:
					result += "파란 무장 해골";
					break;
				case 275:
					result += "파란 무장 해골";
					break;
				case 276:
					result += "파란 무장 해골";
					break;
				case 277:
					result += "지옥 무장 해골";
					break;
				case 278:
					result += "지옥 무장 해골";
					break;
				case 279:
					result += "지옥 무장 해골";
					break;
				case 280:
					result += "지옥 무장 해골";
					break;
				case 281:
					result += "누더기 마법사";
					break;
				case 282:
					result += "누더기 마법사";
					break;
				case 283:
					result += "네크로멘서";
					break;
				case 284:
					result += "네크로멘서";
					break;
				case 285:
					result += "디아볼리스트";
					break;
				case 286:
					result += "디아볼리스트";
					break;
				case 287:
					result += "본 리";
					break;
				case 288:
					result += "던전 영혼";
					break;
				case 289:
					result += "거대한 저주받은 해골";
					break;
				case 290:
					result += "팔라딘";
					break;
				case 291:
					result += "해골 저격수";
					break;
				case 292:
					result += "전술 해골";
					break;
				case 293:
					result += "해골 특전사";
					break;
				case 294:
					result += "화난 해골";
					break;
				case 295:
					result += "화난 해골";
					break;
				case 296:
					result += "화난 해골";
					break;
				case 297:
					result += "큰어치";
					break;
				case 298:
					result += "홍관조";
					break;
				case 299:
					result += "다람쥐";
					break;
				case 300:
					result += "생쥐";
					break;
				case 301:
					result += "까마귀";
					break;
				case 302:
					result += "슬라임";
					break;
				case 303:
					result += "슬라임";
					break;
				case 304:
					result += "호핀' 잭";
					break;
				case 305:
					result += "허수아비";
					break;
				case 306:
					result += "허수아비";
					break;
				case 307:
					result += "허수아비";
					break;
				case 308:
					result += "허수아비";
					break;
				case 309:
					result += "허수아비";
					break;
				case 310:
					result += "허수아비";
					break;
				case 311:
					result += "허수아비";
					break;
				case 312:
					result += "허수아비";
					break;
				case 313:
					result += "허수아비";
					break;
				case 314:
					result += "허수아비";
					break;
				case 315:
					result += "머리 없는 기수";
					break;
				case 316:
					result += "유령";
					break;
				case 317:
					result += "악마의 눈";
					break;
				case 318:
					result += "악마의 눈";
					break;
				case 319:
					result += "좀비";
					break;
				case 320:
					result += "좀비";
					break;
				case 321:
					result += "좀비";
					break;
				case 322:
					result += "해골";
					break;
				case 323:
					result += "해골";
					break;
				case 324:
					result += "해골";
					break;
				case 325:
					result += "탄식하는 나무";
					break;
				case 326:
					result += "스플린터링";
					break;
				case 327:
					result += "펌킹";
					break;
				case 328:
					result += "펌킹";
					break;
				case 329:
					result += "헬하운드";
					break;
				case 330:
					result += "폴터가이스트";
					break;
				case 331:
					result += "좀비";
					break;
				case 332:
					result += "좀비";
					break;
				case 333:
					result += "슬라임";
					break;
				case 334:
					result += "슬라임";
					break;
				case 335:
					result += "슬라임";
					break;
				case 336:
					result += "슬라임";
					break;
				case 337:
					result += "토끼";
					break;
				case 338:
					result += "좀비 요정";
					break;
				case 339:
					result += "좀비 요정";
					break;
				case 340:
					result += "좀비 요정";
					break;
				case 341:
					result += "선물 미믹";
					break;
				case 342:
					result += "생강빵";
					break;
				case 343:
					result += "예티";
					break;
				case 344:
					result += "에버스크림";
					break;
				case 345:
					result += "얼음여왕";
					break;
				case 346:
					result += "산타-NK1";
					break;
				case 347:
					result += "엘프 콥터";
					break;
				case 348:
					result += "호두까기 인형";
					break;
				case 349:
					result += "호두까기 인형";
					break;
				case 350:
					result += "요정 궁수";
					break;
				case 351:
					result += "크램퍼스";
					break;
				case 352:
					result += "플로코";
					break;
				case 353:
					result += "스타일리스트";
					break;
				case 354:
					result += "거미줄에 걸린 스타일리스트";
					break;
				case 355:
					result += "반딧불이";
					break;
				case 356:
					result += "나비";
					break;
				case 357:
					result += "지렁이";
					break;
				case 358:
					result += "개똥벌레";
					break;
				case 359:
					result += "달팽이";
					break;
				case 360:
					result += "야광 달팽이";
					break;
				case 361:
					result += "개구리";
					break;
				case 362:
					result += "오리";
					break;
				case 363:
					result += "오리";
					break;
				case 364:
					result += "오리";
					break;
				case 365:
					result += "오리";
					break;
				case 366:
					result += "전갈";
					break;
				case 367:
					result += "전갈";
					break;
				case 368:
					result += "행상인";
					break;
				case 369:
					result += "낚시꾼";
					break;
				case 370:
					result += "듀크 피시론";
					break;
				case 371:
					result += "폭발하는 거품";
					break;
				case 372:
					result += "샤크론";
					break;
				case 373:
					result += "샤크론";
					break;
				case 374:
					result += "송로버섯 지렁이";
					break;
				case 375:
					result += "송로버섯 지렁이";
					break;
				case 376:
					result += "잠자는 낚시꾼";
					break;
				case 377:
					result += "메뚜기";
					break;
				case 378:
					result += "Chattering Teeth Bomb";
					break;
				case 379:
					result += "Blue Cultist Archer";
					break;
				case 380:
					result += "White Cultist Archer";
					break;
				case 381:
					result += "두뇌 분쇄기";
					break;
				case 382:
					result += "Ray Gunner";
					break;
				case 383:
					result += "Martian Officer";
					break;
				case 384:
					result += "거품 방패";
					break;
				case 385:
					result += "Gray Grunt";
					break;
				case 386:
					result += "Martian Engineer";
					break;
				case 387:
					result += "테슬라 터렛";
					break;
				case 388:
					result += "Martian Drone";
					break;
				case 389:
					result += "기가재퍼";
					break;
				case 390:
					result += "Scutlix Gunner";
					break;
				case 391:
					result += "Scutlix";
					break;
				case 392:
					result += "마틴 소서";
					break;
				case 393:
					result += "마틴 소서 터렛";
					break;
				case 394:
					result += "마틴 소서 캐논";
					break;
				case 395:
					result += "마틴 소서";
					break;
				case 396:
					result += "Moon Lord";
					break;
				case 397:
					result += "Moon Lord's Hand";
					break;
				case 398:
					result += "Moon Lord's Core";
					break;
				case 399:
					result += "Martian Probe";
					break;
				case 402:
					result += "Milkyway Weaver";
					break;
				case 405:
					break;
				case 406:
					result += "Star Cell";
					break;
				case 407:
					result += "Flow Invader";
					break;
				case 409:
					result += "Twinkle Popper";
					break;
				case 410:
					result += "Twinkle";
					break;
				case 411:
					result += "Stargazer";
					break;
				case 412:
					result += "Crawltipede";
					break;
				case 413:
					result += "Crawltipede";
					break;
				case 414:
					result += "Crawltipede";
					break;
				case 415:
					result += "Drakomire";
					break;
				case 416:
					result += "Drakomire Rider";
					break;
				case 417:
					result += "Sroller";
					break;
				case 418:
					result += "Corite";
					break;
				case 419:
					result += "Selenian";
					break;
				case 420:
					result += "Nebula Floater";
					break;
				case 421:
					result += "Brain Suckler";
					break;
				case 422:
					result += "Vortex Pillar";
					break;
				case 423:
					result += "진화의 괴수";
					break;
				case 424:
					result += "Predictor";
					break;
				case 425:
					result += "Storm Diver";
					break;
				case 426:
					result += "외계여왕";
					break;
				case 427:
					result += "외계말벌";
					break;
				case 428:
					result += "외계애벌레";
					break;
				case 429:
					result += "소용도리안";
					break;
				case 430:
					result += "좀비";
					break;
				case 431:
					result += "좀비 에스키모";
					break;
				case 432:
					result += "좀비";
					break;
				case 433:
					result += "좀비";
					break;
				case 434:
					result += "좀비";
					break;
				case 435:
					result += "좀비";
					break;
				case 436:
					result += "좀비";
					break;
				case 437:
					result += "Mysterious Tablet";
					break;
				case 438:
					result += "Lunatic Devote";
					break;
				case 439:
					result += "Lunatic Cultist";
					break;
				case 440:
					result += "Lunatic Cultist";
					break;
				case 442:
					result += "Gold Bird";
					break;
				case 443:
					result += "Gold Bunny";
					break;
				case 444:
					result += "Gold Butterfly";
					break;
				case 445:
					result += "Gold Frog";
					break;
				case 446:
					result += "Gold Grasshopper";
					break;
				case 447:
					result += "Gold Mouse";
					break;
				case 448:
					result += "Gold Worm";
					break;
				case 449:
					result += "Skeleton";
					break;
				case 450:
					result += "Skeleton";
					break;
				case 451:
					result += "Skeleton";
					break;
				case 452:
					result += "Skeleton";
					break;
				case 454:
					break;
				case 455:
					break;
				case 456:
					break;
				case 457:
					break;
				case 458:
					break;
				case 459:
					result += "Phantasm Dragon";
					break;
				case 460:
					result += "도살자";
					break;
				case 461:
					result += "Creature from the Deep";
					break;
				case 462:
					result += "Fritz";
					break;
				case 463:
					result += "Nailhead";
					break;
				case 464:
					result += "Crimtane Bunny";
					break;
				case 465:
					result += "Crimtane Goldfish";
					break;
				case 466:
					result += "Psycho";
					break;
				case 467:
					result += "Deadly Sphere";
					break;
				case 468:
					result += "Dr. Man Fly";
					break;
				case 469:
					result += "The Possessed";
					break;
				case 470:
					result += "Vicious Penguin";
					break;
				case 471:
					result += "Goblin Summoner";
					break;
				case 472:
					result += "Shadowflame Apparation";
					break;
				case 473:
					result += "Corrupt Mimic";
					break;
				case 474:
					result += "Crimson Mimic";
					break;
				case 475:
					result += "Hallowed Mimic";
					break;
				case 476:
					result += "Jungle Mimic";
					break;
				case 477:
					result += "Mothron";
					break;
				case 478:
					result += "Mothron Egg";
					break;
				case 479:
					result += "Baby Mothron";
					break;
				case 480:
					result += "Medusa";
					break;
				case 481:
					result += "Hoplite";
					break;
				case 482:
					result += "Granite Golem";
					break;
				case 483:
					result += "Granite Elemental";
					break;
				case 484:
					result += "Enchanted Nightcrawler";
					break;
				case 485:
					result += "Grubby";
					break;
				case 486:
					result += "Sluggy";
					break;
				case 487:
					result += "Buggy";
					break;
				case 488:
					result += "Target Dummy";
					break;
				case 489:
					result += "Blood Zombie";
					break;
				case 490:
					result += "Drippler";
					break;
				case 493:
					result += "Stardust Pillar";
					break;
				case 494:
					result += "Crawdad";
					break;
				case 495:
					result += "Crawdad";
					break;
				case 496:
					result += "Giant Shelly";
					break;
				case 497:
					result += "Giant Shelly";
					break;
				case 498:
					result += "Salamander";
					break;
				case 499:
					result += "Salamander";
					break;
				case 500:
					result += "Salamander";
					break;
				case 501:
					result += "Salamander";
					break;
				case 502:
					result += "Salamander";
					break;
				case 503:
					result += "Salamander";
					break;
				case 504:
					result += "Salamander";
					break;
				case 505:
					result += "Salamander";
					break;
				case 506:
					result += "Salamander";
					break;
				case 507:
					result += "Nebula Pillar";
					break;
				case 508:
					result += "Antlion Charger";
					break;
				case 509:
					result += "Antlion Swarmer";
					break;
				case 510:
					break;
				case 511:
					break;
				case 512:
					result += "Dune Splicer";
					break;
				case 513:
					break;
				case 514:
					break;
				case 515:
					result += "Tomb Crawler";
					break;
				case 516:
					result += "Solar Flare";
					break;
				case 517:
					result += "Solar Pillar";
					break;
				case 518:
					result += "Drakanian";
					break;
				case 519:
					result += "Solar Fragment";
					break;
				case 520:
					result += "Martian Walker";
					break;
				case 521:
					result += "Ancient Vision";
					break;
				case 522:
					result += "Ancient Light";
					break;
				case 523:
					result += "Ancient Doom";
					break;
				case 524:
					result += "구울";
					break;
				case 525:
					result += "Vile 구울";
					break;
				case 526:
					result += "Tainted 구울";
					break;
				case 527:
					result += "꿈꾸는 구울";
					break;
				case 528:
					break;
				case 529:
					result += "Lamia";
					break;
				case 530:
					break;
				case 531:
					result += "Sand Poacher";
					break;
				case 532:
					result += "바실리스크";
					break;
				case 533:
					result += "사막 망령";
					break;
				case 534:
					result += "Tortured Soul";
					break;
				case 535:
					result += "Spiked Slime";
					break;
				case 536:
					result += "The Bride";
					break;
				case 537:
					result += "Sand Slime";
					break;
				case 538:
					result += "Red Squirrel";
					break;
				case 539:
					result += "Gold Squirrel";
					break;
			}

			return result;
		}

		public static string toolTip(int l)
		{

			if (l >= 1372 && l <= 1375)
			{
				return "'W. Garner'";
			}
			if (l == 1419)
			{
				return "'W. Garner'";
			}
			if (l == 1420)
			{
				return "'W. Garner'";
			}
			if (l == 1421)
			{
				return "'W. Garner'";
			}
			if (l == 1425)
			{
				return "'W. Garner'";
			}
			if (l == 1426)
			{
				return "'W. Garner'";
			}
			if (l == 1427)
			{
				return "'W. Garner'";
			}
			if (l == 1428)
			{
				return "'W. Garner'";
			}
			if (l == 1443)
			{
				return "'W. Garner'";
			}
			if (l == 1501)
			{
				return "'W. Garner'";
			}
			if (l == 1573)
			{
				return "'W. Garner'";
			}
			if (l == 1574)
			{
				return "'W. Garner'";
			}
			if (l == 1575)
			{
				return "'W. Garner'";
			}
			if (l == 1422)
			{
				return "'R. Moosdijk'";
			}
			if (l == 1423)
			{
				return "'R. Moosdijk'";
			}
			if (l == 1435)
			{
				return "'R. Moosdijk'";
			}
			if (l == 1424)
			{
				return "'V. Costa Moura'";
			}
			if (l == 1436)
			{
				return "'V. Costa Moura'";
			}
			if (l == 1437)
			{
<<<<<<< HEAD
				int l2 = 0;
				if (l >= 2897 && l <= 2994)
				{
					l2 = Item.BannerToNPC(89 + l - 2897 - 1);
				}
				if (l >= 1615 && l <= 1701)
				{
					l2 = Item.BannerToNPC(l - 1614);
				}
				if (l >= 3390 && l <= 3452)
				{
					l2 = Item.BannerToNPC(186 + l - 3390);
				}
				if (l >= 3593 && l <= 3594)
				{
					l2 = Item.BannerToNPC(249 + l - 3593);
				}
				string str = Lang.npcName(l2, false);
				return "근처 플레이어들은 몬스터를 상대할때 전투력이 향상됩니다. 해당 몬스터: " + str;
=======
				return "'V. Costa Moura'";
			}
			if (l == 1438)
			{
				return "'V. Costa Moura'";
			}
			if (l == 1439)
			{
				return "'V. Costa Moura'";
			}
			if (l == 1440)
			{
				return "'V. Costa Moura'";
			}
			if (l == 1442)
			{
				return "'V. Costa Moura'";
			}
			if (l >= 1481 && l <= 1494)
			{
				return "'V. Costa Moura'";
			}
			if (l == 1846)
			{
				return "'V. Costa Moura'";
			}
			if (l == 2995)
			{
				return "'V. Costa Moura'";
			}
			if (l >= 1476 && l <= 1480)
			{
				return "'J. T. Myhre'";
			}
			if (l >= 1496 && l <= 1499)
			{
				return "'J. T. Myhre'";
			}
			if (l == 1538)
			{
				return "'J. T. Myhre'";
			}
			if (l >= 1539 && l <= 1542)
			{
				return "'A. Craig'";
			}
			if (l == 1433)
			{
				return "'K. Wright'";
>>>>>>> origin/master
			}
			if (l == 1441)
			{
<<<<<<< HEAD
				return "요요 사거리거 증가합니다";
=======
				return "'A. G. Kolf'";
>>>>>>> origin/master
			}
			if (l == 1500)
			{
<<<<<<< HEAD
				return "요요로 피해를 입히면 카운터웨이트를 던집니다";
=======
				return "'A. G. Kolf'";
>>>>>>> origin/master
			}
			if (l == 1495)
			{
<<<<<<< HEAD
				return "우클릭으로 열기";
=======
				return "'A. G. Kolf'";
>>>>>>> origin/master
			}
			if (l == 1576)
			{
				return "'D. Phelps'";
			}
			if (l == 1577)
			{
				return "'M. J. Duncan'";
			}
			if (l == 1434)
			{
				return "'C. J. Ness'";
			}
			if (l == 1502)
			{
				return "'C. Burczyk'";
			}
			if (l >= 1847 && l <= 1850)
			{
				return "'J. Hayes'";
			}
			if (l >= 2865 && l <= 2867)
			{
				return "'J. Hayes'";
			}
			if (l >= 3055 && l <= 3059)
			{
				return "'J. Hayes'";
			}
			if (l == 2497)
			{
				return "'J. Hayes'";
			}
			if (l == 2995 || l == 3596)
			{
				return "'V. Costa Moura'";
			}

			if (true)
			{
				if (l >= 1874 && l <= 1905)
				{
					return "배치할 수 있는 성탄절 소나무";
				}
				if ((l >= 2897 && l <= 2994) || (l >= 1615 && l <= 1701) || (l >= 3390 && l <= 3452) || (l >= 3593 && l <= 3594))
				{
					int l2 = 0;
					if (l >= 2897 && l <= 2994)
					{
						l2 = Item.BannerToNPC(89 + l - 2897 - 1);
					}
					if (l >= 1615 && l <= 1701)
					{
						l2 = Item.BannerToNPC(l - 1614);
					}
					if (l >= 3390 && l <= 3452)
					{
						l2 = Item.BannerToNPC(186 + l - 3390);
					}
					if (l >= 3593 && l <= 3594)
					{
						l2 = Item.BannerToNPC(249 + l - 3593);
					}
					string str = Lang.npcName(l2, false);
					return "Nearby players get a bonus against: " + str;
				}
				if (l >= 3293 && l <= 3308)
				{
					return "Increases yoyo range";
				}
				if (l >= 3309 && l <= 3314)
				{
					return "Throws a counterweight after hitting an enemy with a yoyo";
				}
				if (l >= 3318 && l <= 3332)
				{
					return "Right click to open";
				}
				if (l <= 1450)
				{
					if (l <= 332)
					{
						if (l <= 168)
						{
							if (l <= 43)
							{
								if (l <= 23)
								{
<<<<<<< HEAD
									return "광원을 제공합니다";
=======
									if (l == 8)
									{
										return "Provides light";
									}
									switch (l)
									{
										case 15:
											return "Tells the time";
										case 16:
											return "Tells the time";
										case 17:
											return "Tells the time";
										case 18:
											return "Displays depth";
										case 19:
										case 20:
										case 21:
										case 22:
											return Lang.toolTip(l, true);
										case 23:
											return "'Both tasty and flammable'";
										default:
											return Lang.toolTip(l, true);
									}
>>>>>>> origin/master
								}
								else
								{
<<<<<<< HEAD
								case 15:
									return "시간을 알려줍니다";
								case 16:
									return "시간을 알려줍니다";
								case 17:
									return "시간을 알려줍니다";
								case 18:
									return "깊이를 표시합니다";
								case 19:
								case 20:
								case 21:
								case 22:
									goto IL_A9EF;
								case 23:
									return "'맛도 있고 불에도 잘타고!'";
								default:
									goto IL_A9EF;
=======
									if (l == 29)
									{
										return "Permanently increases maximum life by 20";
									}
									switch (l)
									{
										case 33:
											return "Used for smelting ore";
										case 34:
											return Lang.toolTip(l, true);
										case 35:
											return "Used to craft items from metal bars";
										case 36:
											return "Used for basic crafting";
										default:
											if (l != 43)
											{
												return Lang.toolTip(l, true);
											}
											return "Summons the Eye of Cthulhu";
									}
>>>>>>> origin/master
								}
							}
							else if (l <= 75)
							{
								switch (l)
								{
<<<<<<< HEAD
									return "영구적으로 생명력이 20 증가합니다";
=======
									case 49:
										return "Slowly regenerates life";
									case 50:
										return "Gaze in the mirror to return home";
									case 51:
									case 52:
									case 55:
									case 58:
									case 59:
									case 60:
									case 61:
									case 62:
									case 63:
									case 69:
										return Lang.toolTip(l, true);
									case 53:
										return "Allows the holder to double jump";
									case 54:
										return "The wearer can run super fast";
									case 56:
										return "'Pulsing with dark energy'";
									case 57:
										return "'Pulsing with dark energy'";
									case 64:
										return "Summons a vile thorn";
									case 65:
										return "Causes stars to rain from the sky";
									case 66:
										return "Cleanses the evil";
									case 67:
										goto IL_21BF;
									case 68:
										return "'Looks tasty!'";
									case 70:
										return "Summons the Eater of Worlds";
									default:
										if (l != 75)
										{
											return Lang.toolTip(l, true);
										}
										return "Disappears after the sunrise";
>>>>>>> origin/master
								}
							}
							else
							{
								switch (l)
								{
<<<<<<< HEAD
								case 33:
									return "광물을 제련할 때 필요합니다";
								case 34:
									goto IL_A9EF;
								case 35:
									return "금속괴를 사용하는 조합에 필요합니다";
								case 36:
									return "기본적인 조합에 필요합니다";
								default:
									if (l != 43)
									{
										goto IL_A9EF;
									}
									return "크툴후의 눈을 소환합니다";
=======
									case 84:
										return "'Get over here!'";
									case 85:
										return "Can be climbed on";
									case 86:
									case 87:
										return Lang.toolTip(l, true);
									case 88:
										return "Provides light when worn";
									default:
										switch (l)
										{
											case 98:
												return "33% chance to not consume ammo";
											case 99:
											case 104:
											case 105:
											case 106:
											case 107:
											case 108:
											case 110:
											case 116:
											case 119:
											case 122:
											case 126:
											case 127:
												return Lang.toolTip(l, true);
											case 100:
												return "7% increased melee speed";
											case 101:
												return "7% increased melee speed";
											case 102:
												return "7% increased melee speed";
											case 103:
												return "Able to mine Hellstone";
											case 109:
												return "Permanently increases maximum mana by 20";
											case 111:
												return "Increases maximum mana by 20";
											case 112:
												return "Throws balls of fire";
											case 113:
												return "Casts a controllable missile";
											case 114:
												return "Magically moves dirt";
											case 115:
												return "Creates a magical shadow orb";
											case 117:
												return "'Warm to the touch'";
											case 118:
												return "Sometimes dropped by Skeletons and Piranha";
											case 120:
												return "Lights wooden arrows ablaze";
											case 121:
												return "'It's made out of fire!'";
											case 123:
												return "7% increased magic damage";
											case 124:
												return "7% increased magic damage";
											case 125:
												return "7% increased magic damage";
											case 128:
												return "Allows flight";
											default:
												switch (l)
												{
													case 148:
														return "Holding this may attract unwanted attention";
													case 149:
														return "'It contains strange symbols'";
													case 150:
													case 154:
													case 155:
													case 160:
													case 161:
													case 162:
													case 163:
													case 164:
														return Lang.toolTip(l, true);
													case 151:
														break;
													case 152:
														return "5% increased ranged damage.";
													case 153:
														return "5% increased ranged damage.";
													case 156:
														return "Grants immunity to knockback";
													case 157:
														return "Sprays out a shower of water";
													case 158:
														return "Negates fall damage";
													case 159:
														return "Increases jump height";
													case 165:
														return "Casts a slow moving bolt of water";
													case 166:
														return "A small explosion that will destroy some tiles";
													case 167:
														return "A large explosion that will destroy most tiles";
													case 168:
														return "A small explosion that will not destroy tiles";
													default:
														return Lang.toolTip(l, true);
												}
												break;
										}
										break;
>>>>>>> origin/master
								}
							}
						}
						else if (l <= 230)
						{
							if (l <= 190)
							{
<<<<<<< HEAD
							case 49:
								return "서서히 생명력을 재생시킵니다";
							case 50:
								return "거울속을 바라보아 집으로 귀한합니다";
							case 51:
							case 52:
							case 55:
							case 58:
							case 59:
							case 60:
							case 61:
							case 62:
							case 63:
							case 69:
								goto IL_A9EF;
							case 53:
								return "착용자는 더블점프를 사용할 수 있습니다";
							case 54:
								return "착용하는 사람은 재빨리 뛸 수 있습니다";
							case 56:
								return "'어둠의 에너지가 고동칩니다'";
							case 57:
								return "'어둠의 에너지가 고동칩니다'";
							case 64:
								return "극도로 불쾌한 가시를 소환합니다";
							case 65:
								return "별이 비처럼 하늘에서 내리게 합니다";
							case 66:
								return "사악을 정화시킵니다";
							case 67:
								goto IL_21BF;
							case 68:
								return "'맛있어 보이네요!'";
							case 70:
								return "세상을 먹는 자를 소환합니다";
							default:
								if (l != 75)
=======
								if (l == 175)
								{
									return "'Hot to the touch'";
								}
								switch (l)
>>>>>>> origin/master
								{
									case 186:
										return "Increases breath time and allows breathing in water";
									case 187:
										return "Grants the ability to swim";
									case 188:
									case 189:
										return Lang.toolTip(l, true);
									case 190:
										return "Has a chance to poison enemies";
									default:
										return Lang.toolTip(l, true);
								}
<<<<<<< HEAD
								return "일출과 함께 사라집니다";
=======
>>>>>>> origin/master
							}
							else
							{
<<<<<<< HEAD
							case 84:
								return "'이리오너라!'";
							case 85:
								return "벽을 탈 수 있습니다";
							case 86:
							case 87:
								goto IL_A9EF;
							case 88:
								return "착용하면 빛을 발산합니다";
							default:
								switch (l)
								{
								case 98:
									return "탄약을 소비하지 않을 확률 33%";
								case 99:
								case 104:
								case 105:
								case 106:
								case 107:
								case 108:
								case 110:
								case 116:
								case 119:
								case 122:
								case 126:
								case 127:
									goto IL_A9EF;
								case 100:
									return "7%";
								case 101:
									return "근접관련 공격속도 증가 7%";
								case 102:
									return "근접관련 공격속도 증가 7%";
								case 103:
									return "지옥돌을 캘 수 있습니다";
								case 109:
									return "영구적으로 마나 최대치가 20만큼 증가합니다 ";
								case 111:
									return "마나 최대치가 20만큼 증가합니다";
								case 112:
									return "불공을 던집니다";
								case 113:
									return "제어가능한 발사체를 소환합니다";
								case 114:
									return "마법처럼 흙을 이동시킵니다";
								case 115:
									return "마법적인 그림자 보주를 소환합니다";
								case 117:
									return "'만져보니 따스하네요'";
								case 118:
									return "때때로 스켈레톤과 피라냐에게서 발견됩니다";
								case 120:
									return "나무 화살을 불타오르게 합니다";
								case 121:
									return "'그건 불로 이루워져 있어!'";
								case 123:
									return "마법 피해량이 7% 만큼 증가합니다";
								case 124:
									return "마법 피해량이 7% 만큼 증가합니다";
								case 125:
									return "마법 피해량이 7% 만큼 증가합니다";
								case 128:
									return "비행을 가능케 합니다";
								default:
									switch (l)
									{
									case 148:
										return "이걸 들고 있다면 원하지 않는 주목을 받을 수 있습니다";
									case 149:
										return "'이상한 기호가 그려져 있습니다'";
									case 150:
									case 154:
									case 155:
									case 160:
									case 161:
									case 162:
									case 163:
									case 164:
										goto IL_A9EF;
									case 151:
										break;
									case 152:
										return "마법 피해량이 5% 만큼 증가합니다.";
									case 153:
										return "마법 피해량이 5% 만큼 증가합니다.";
									case 156:
										return "넉백에 면역이 생깁니다";
									case 157:
										return "물을 솰솰 뿌립니다";
									case 158:
										return "낙하할 때 충격을 완화합니다";
									case 159:
										return "점프 높이를 증가시킵니다";
									case 165:
										return "느리게 움직이는 워터볼트를 시전합니다";
									case 166:
										return "몇몇의 블럭을 부술만한 작은 폭발력을 가지고 있습니다";
									case 167:
										return "대부분의 블럭을 부술만한 큰 폭발력을 가지고 있습니다";
									case 168:
										return "블럭을 부수지 못하지만 작은 폭발력을 가지고 있습니다";
=======
								if (l == 193)
								{
									return "Grants immunity to fire blocks";
								}
								if (l == 197)
								{
									return "Shoots fallen stars";
								}
								switch (l)
								{
									case 208:
										return "'It's pretty, oh so pretty'";
									case 209:
									case 210:
									case 214:
									case 216:
									case 217:
									case 219:
									case 220:
									case 221:
									case 224:
									case 225:
									case 226:
										return Lang.toolTip(l, true);
									case 211:
										return "12% increased melee speed";
									case 212:
										return "10% increased movement speed";
									case 213:
										return "Creates grass and moss on dirt and stone";
									case 215:
										return "'May annoy others'";
									case 218:
										return "Summons a controllable ball of fire";
									case 222:
										return "Grows plants";
									case 223:
										return "6% reduced mana usage";
									case 227:
										return "Reduced potion cooldown";
									case 228:
										return "Increases maximum mana by 40";
									case 229:
										return "Increases maximum mana by 20";
									case 230:
										return "Increases maximum mana by 20";
>>>>>>> origin/master
									default:
										return Lang.toolTip(l, true);
								}
							}
						}
						else if (l <= 305)
						{
<<<<<<< HEAD
							if (l == 175)
							{
								return "'만져보니 뜨거워요'";
							}
							switch (l)
							{
							case 186:
								return "잠수 능력을 향상시키며 물속에서 숨을 쉬게 해 줍니다";
							case 187:
								return "수영 능력이 생깁니다";
							case 188:
							case 189:
								goto IL_A9EF;
							case 190:
								return "적을 중독시킬 확률이 있습니다";
							default:
								goto IL_A9EF;
=======
							switch (l)
							{
								case 235:
									goto IL_233F;
								case 236:
									return Lang.toolTip(l, true);
								case 237:
									return "'Makes you look cool!'";
								case 238:
									return "15% increased magic damage";
								default:
									switch (l)
									{
										case 256:
											return "15% increased throwing velocity";
										case 257:
											return "15% increased throwing damage";
										case 258:
											return "10% increased throwing critical strike chance";
										case 259:
										case 262:
										case 263:
										case 264:
										case 265:
										case 269:
										case 270:
										case 271:
										case 273:
										case 274:
										case 275:
										case 276:
										case 277:
										case 278:
										case 279:
										case 280:
										case 284:
										case 286:
										case 287:
											return Lang.toolTip(l, true);
										case 260:
											return "It smells funny...";
										case 261:
											return "'It's smiling, might be a good snack'";
										case 266:
											return "'This is a good idea!'";
										case 267:
											return "'You are a terrible person.'";
										case 268:
											return "Greatly extends underwater breathing";
										case 272:
											return "Casts a demon scythe";
										case 281:
											return "Allows the collection of seeds for ammo";
										case 282:
											return "Works when wet";
										case 283:
											return "For use with Blowpipe";
										case 285:
											return "5% increased movement speed";
										case 288:
											return "Provides immunity to lava";
										case 289:
											return "Provides life regeneration";
										case 290:
											return "25% increased movement speed";
										case 291:
											return "Breathe water instead of air";
										case 292:
											return "Increase defense by 8";
										case 293:
											return "Increased mana regeneration";
										case 294:
											return "20% increased magic damage";
										case 295:
											return "Slows falling speed";
										case 296:
											return "Shows the location of treasure and ore";
										case 297:
											return "Grants invisibility";
										case 298:
											return "Emits an aura of light";
										case 299:
											return "Increases night vision";
										case 300:
											return "Increases enemy spawn rate";
										case 301:
											return "Attackers also take damage";
										case 302:
											return "Allows the ability to walk on water";
										case 303:
											return "20% increased arrow speed and damage";
										case 304:
											return "Shows the location of enemies";
										case 305:
											return "Allows the control of gravity";
										default:
											return Lang.toolTip(l, true);
									}
									break;
>>>>>>> origin/master
							}
						}
						else
						{
<<<<<<< HEAD
							if (l == 193)
							{
								return "뜨거운 블럭들에게 면역이 생깁니다";
							}
							if (l == 197)
							{
								return "별을 발사합니다";
							}
							switch (l)
							{
							case 208:
								return "'아름다워, 오, 정말 아름다워'";
							case 209:
							case 210:
							case 214:
							case 216:
							case 217:
							case 219:
							case 220:
							case 221:
							case 224:
							case 225:
							case 226:
								goto IL_A9EF;
							case 211:
								return "근접공격 속도가 12% 만큼 증가합니다";
							case 212:
								return "이동속도가 10% 만큼 증가합니다";
							case 213:
								return "풀과 이끼를 흙과 돌에 생성시킵니다";
							case 215:
								return "'짜증전도자가 되보세요'";
							case 218:
								return "제어가능한 불공을 소환합니다";
							case 222:
								return "식물을 자라게 합니다";
							case 223:
								return "마나 소모량이 6% 만큼 감소합니다";
							case 227:
								return "물약 재사용 시간을 줄입니다";
							case 228:
								return "마나 최대치가 40 만큼 증가합니다";
							case 229:
								return "마나 최대치가 20 만큼 증가합니다";
							case 230:
								return "마나 최대치가 20 만큼 증가합니다";
							default:
								goto IL_A9EF;
=======
							if (l == 324)
							{
								return "'Banned in most places'";
							}
							switch (l)
							{
								case 327:
									return "Opens one Gold or Dungeon Chest";
								case 328:
									return Lang.toolTip(l, true);
								case 329:
									return "Opens all Shadow Chests";
								default:
									if (l != 332)
									{
										return Lang.toolTip(l, true);
									}
									return "Used for crafting cloth";
>>>>>>> origin/master
							}
						}
					}
					else if (l <= 726)
					{
						if (l <= 603)
						{
<<<<<<< HEAD
						case 235:
							goto IL_233F;
						case 236:
							goto IL_A9EF;
						case 237:
							return "'멋잇게 보여요!'";
						case 238:
							return "마법 피해량이 15% 만큼 증가합니다";
						default:
							switch (l)
							{
							case 256:
								return "투척물의 속도가 15% 만큼 증가합니다";
							case 257:
								return "투척물의 피해량이 15% 만큼 증가합니다";
							case 258:
								return "투척물의 치명타 확률이 10% 만큼 증가합니다";
							case 259:
							case 262:
							case 263:
							case 264:
							case 265:
							case 269:
							case 270:
							case 271:
							case 273:
							case 274:
							case 275:
							case 276:
							case 277:
							case 278:
							case 279:
							case 280:
							case 284:
							case 286:
							case 287:
								goto IL_A9EF;
							case 260:
								return "냄새가 웃겨요...";
							case 261:
								return "'웃고 있다. 좋은 간식이 될 것 같다'";
							case 266:
								return "'정말 좋은 아이디어야!'";
							case 267:
								return "'당신 정말 끔찍한 사람이군요.'";
							case 268:
								return "잠수 능력이 대폭 향상됩니다";
							case 272:
								return "악마의 대낫을 시전합니다";
							case 281:
								return "씨앗을 탄약으로 모을 수 있게 합니다";
							case 282:
								return "젖어야 사용할 수 있어요";
							case 283:
								return "분관을 사용할때 소모됨";
							case 285:
								return "이동속도가 5% 만큼 증가합니다";
							case 288:
								return "용암에 면역력이 생깁니다";
							case 289:
								return "생명 회복력이 증가합니다";
							case 290:
								return "이동속도가 25% 만큼 증가합니다";
							case 291:
								return "공기 대신 물로 호흡합니다";
							case 292:
								return "방어력이 8만큼 증가합니다";
							case 293:
								return "마나 회복력이 증가합니다";
							case 294:
								return "마법 피해량이 20% 만큼 증가합니다";
							case 295:
								return "낙하 속도를 줄여줍니다";
							case 296:
								return "보물과 광물의 위치를 표시합니다";
							case 297:
								return "은신 상태에 돌입합니다";
							case 298:
								return "빛을 발산합니다";
							case 299:
								return "야간 시력을 증가시킵니다";
							case 300:
								return "적이 소환되는 속도를 증가시킵니다";
							case 301:
								return "공격자도 피해를 입습니다";
							case 302:
								return "물 위를 걷는 능력을 줍니다";
							case 303:
								return "화살의 속도와 피해량이 20% 만큼 증가합니다";
							case 304:
								return "적의 위치를 표시합니다";
							case 305:
								return "중력을 제어할 수 있게 됩니다";
							default:
								goto IL_A9EF;
							}
							break;
						}
					}
					else
					{
						if (l == 324)
						{
							return "'대부분의 지역에서 금지되었습니다'";
						}
						switch (l)
						{
						case 327:
							return "금창고나 던전 창고를 열 수 있습니다";
						case 328:
							goto IL_A9EF;
						case 329:
							return "모든 그림자 창고를 열 수 있습니다";
						default:
							if (l != 332)
=======
							if (l <= 407)
							{
								if (l == 352)
								{
									return "Used for brewing ale";
								}
								switch (l)
								{
									case 357:
										return "Minor improvements to all stats";
									case 358:
									case 359:
									case 360:
									case 362:
									case 364:
									case 365:
									case 366:
									case 368:
									case 369:
									case 370:
									case 374:
									case 375:
									case 379:
									case 380:
									case 381:
									case 382:
									case 383:
									case 384:
									case 387:
									case 388:
									case 390:
									case 391:
									case 392:
									case 406:
										return Lang.toolTip(l, true);
									case 361:
										return "Summons a Goblin Army";
									case 363:
										return "Used for advanced wood crafting";
									case 367:
										return "Strong enough to destroy Demon Altars";
									case 371:
										return "Increases maximum mana by 40";
									case 372:
										return "7% increased movement speed";
									case 373:
										return "10% increased ranged damage";
									case 376:
										return "Increases maximum mana by 60";
									case 377:
										return "5% increased melee critical strike chance";
									case 378:
										return "12% increased ranged damage";
									case 385:
										return "Can mine Mythril and Orichalcum";
									case 386:
										return "Can mine Adamantite and Titanium";
									case 389:
										return "Has a chance to confuse";
									case 393:
										return "Displays horizontal position";
									case 394:
										return "Grants the ability to swim";
									case 395:
										return "Shows position";
									case 396:
										return "Negates fall damage";
									case 397:
										return "Grants immunity to knockback";
									case 398:
										return "Allows the combining of some accessories";
									case 399:
										return "Allows the holder to double jump";
									case 400:
										return "Increases maximum mana by 80";
									case 401:
										return "7% increased melee critical strike chance";
									case 402:
										return "14% increased ranged damage";
									case 403:
										return "6% increased damage";
									case 404:
										return "4% increased critical strike chance";
									case 405:
										return "Allows flight";
									case 407:
										return "Increases block placement range";
									default:
										return Lang.toolTip(l, true);
								}
							}
							else
>>>>>>> origin/master
							{
								switch (l)
								{
									case 422:
										return "Spreads the Hallow to some blocks";
									case 423:
										return "Spreads the corruption to some blocks";
									case 424:
										return Lang.toolTip(l, true);
									case 425:
										return "Summons a magical fairy";
									default:
										if (l == 434)
										{
											return "Three round burst";
										}
										switch (l)
										{
											case 485:
												return "Turns the holder into a werewolf at night";
											case 486:
												return "Creates measurement lines on screen for block placement";
											case 487:
											case 488:
											case 494:
											case 498:
											case 499:
											case 500:
											case 501:
											case 502:
											case 503:
											case 504:
											case 505:
											case 507:
											case 508:
											case 511:
											case 512:
											case 513:
											case 514:
											case 530:
											case 537:
											case 538:
											case 539:
											case 540:
											case 545:
											case 546:
											case 550:
											case 562:
											case 563:
											case 564:
											case 565:
											case 566:
											case 567:
											case 568:
											case 569:
											case 570:
											case 571:
											case 572:
											case 573:
											case 574:
											case 577:
											case 578:
											case 586:
											case 587:
											case 588:
											case 589:
											case 590:
											case 591:
											case 592:
											case 593:
											case 594:
											case 595:
											case 596:
											case 597:
											case 598:
												return Lang.toolTip(l, true);
											case 489:
												return "15% increased magic damage";
											case 490:
												return "15% increased melee damage";
											case 491:
												return "15% increased ranged damage";
											case 492:
												return "Allows flight and slow fall";
											case 493:
												return "Allows flight and slow fall";
											case 495:
												return "Casts a controllable rainbow";
											case 496:
												return "Summons a block of ice";
											case 497:
												return "Transforms the holder into merfolk when entering water";
											case 506:
												return "Uses gel for ammo";
											case 509:
												return "Places red wire";
											case 510:
												return "Removes wire";
											case 515:
												return "Creates several crystal shards on impact";
											case 516:
												return "Summons falling stars on impact";
											case 517:
												return "A magical returning dagger";
											case 518:
												return "Summons rapid fire crystal shards";
											case 519:
												return "Summons unholy fire balls";
											case 520:
												return "'The essence of light creatures'";
											case 521:
												return "'The essence of dark creatures'";
											case 522:
												return "'Not even water can put the flame out'";
											case 523:
												return "Can be placed in water";
											case 524:
												return "Used to smelt adamantite and titanium ore";
											case 525:
												return "Used to craft items from mythril, orichalcum, adamantite, and titanium bars";
											case 526:
												return "'Sharp and magical!'";
											case 527:
												return "'Sometimes carried by creatures in corrupt deserts'";
											case 528:
												return "'Sometimes carried by creatures in light deserts'";
											case 529:
												return "Activates when stepped on";
											case 531:
												return "Can be enchanted";
											case 532:
												return "Causes stars to fall when injured";
											case 533:
												return "50% chance to not consume ammo";
											case 534:
												return "Fires a spread of bullets";
											case 535:
												return "Reduces the cooldown of healing potions";
											case 536:
												return "Increases melee knockback";
											case 541:
												return "Activates when stepped on";
											case 542:
												return "Activates when a player steps on it";
											case 543:
												return "Activates when a player steps on it";
											case 544:
												return "Summons The Twins";
											case 547:
												return "'The essence of pure terror'";
											case 548:
												return "'The essence of the destroyer'";
											case 549:
												return "'The essence of omniscient watchers'";
											case 551:
												return "7% increased critical strike chance";
											case 552:
												return "7% increased damage";
											case 553:
												return "15% increased ranged damage";
											case 554:
												return "Increases length of invincibility after taking damage";
											case 555:
												return "8% reduced mana usage";
											case 556:
												return "Summons Destroyer";
											case 557:
												return "Summons Skeletron Prime";
											case 558:
												return "Increases maximum mana by 100";
											case 559:
												return "10% increased melee damage and critical strike chance";
											case 560:
												return "Summons King Slime";
											case 561:
												return "Stacks up to 5";
											case 575:
												return "'The essence of powerful flying creatures'";
											case 576:
												return "Has a chance to record songs";
											case 579:
												return "'Not to be confused with a picksaw'";
											case 580:
												return "Explodes when activated";
											case 581:
												return "Sends water to outlet pumps";
											case 582:
												return "Receives water from inlet pumps";
											case 583:
												return "Activates every second";
											case 584:
												return "Activates every 3 seconds";
											case 585:
												return "Activates every 5 seconds";
											case 599:
												return "Right click to open";
											case 600:
												return "Right click to open";
											case 601:
												return "Right click to open";
											case 602:
												return "Summons the Frost Legion";
											case 603:
												return "Summons a pet bunny";
											default:
												return Lang.toolTip(l, true);
										}
										break;
								}
							}
<<<<<<< HEAD
							return "옷을 만드는데 필요합니다";
=======
>>>>>>> origin/master
						}
						else if (l <= 686)
						{
<<<<<<< HEAD
							if (l == 352)
							{
								return "에일을 양조하는데 사용됩니다";
							}
							switch (l)
							{
							case 357:
								return "모든 스탯을 약간 향상시킵니다 ";
							case 358:
							case 359:
							case 360:
							case 362:
							case 364:
							case 365:
							case 366:
							case 368:
							case 369:
							case 370:
							case 374:
							case 375:
							case 379:
							case 380:
							case 381:
							case 382:
							case 383:
							case 384:
							case 387:
							case 388:
							case 390:
							case 391:
							case 392:
							case 406:
								goto IL_A9EF;
							case 361:
								return "고블린 군대를 소환합니다";
							case 363:
								return "나무 관련 조합에 필요합니다";
							case 367:
								return "악마의 제단을 부술 수 있을 만큼 충분히 강력합니다";
							case 371:
								return "마나 최대치가 40 만큼 증가합니다";
							case 372:
								return "이동속도가 7% 만큼 증가합니다";
							case 373:
								return "원거리 공격 피해량이 10% 만큼 증가합니다";
							case 376:
								return "마나 최대치가 60 만큼 증가합니다";
							case 377:
								return "근접공격 치명타 확률이 5% 만큼 증가합니다";
							case 378:
								return "원거리공격의 피해량이 12% 만큼 증가합니다";
							case 385:
								return "미스릴과 오리칼쿰을 채광할 수 있습니다";
							case 386:
								return "아다만타이트와 티타늄을 채광할 수 있습니다";
							case 389:
								return "상대방에게 혼란을 일으킬 수 있습니다";
							case 393:
								return "수평의 위치를 표시합니다";
							case 394:
								return "수영 능력이 생깁니다";
							case 395:
								return "위치를 표시합니다";
							case 396:
								return "낙하 할 때 충격을 완하합니다";
							case 397:
								return "넉백에 면역력이 생깁니다";
							case 398:
								return "액세서리를 결합시킬 때 필요합니다";
							case 399:
								return "착용한 사람은 더블 점프를 사용할 수 있게 됩니다";
							case 400:
								return "마나 최대치가 80 만큼 증가합니다";
							case 401:
								return "근접공격 치명타 확률이 7% 만큼 증가합니다 ";
							case 402:
								return "원거리공격의 피해량이 14% 만큼 증가합니다";
							case 403:
								return "피해량이 6% 만큼 증가합니다";
							case 404:
								return "치명타 확률이 4% 만큼 증가합니다";
							case 405:
								return "비행을 가능케 합니다";
							case 407:
								return "블럭 배치 사거리가 증가합니다";
							default:
								goto IL_A9EF;
=======
							switch (l)
							{
								case 665:
								case 666:
								case 667:
								case 668:
									goto IL_3341;
								case 669:
									return "Summons a baby penguin";
								default:
									switch (l)
									{
										case 676:
											return "Shoots an icy bolt";
										case 677:
										case 679:
										case 680:
										case 681:
										case 682:
											return Lang.toolTip(l, true);
										case 678:
											return "Only for those who are worthy";
										case 683:
											return "Summons the Devil's trident";
										case 684:
											return "16% increased melee and ranged damage";
										case 685:
											return "11% increased melee and ranged critical strike chance";
										case 686:
											return "8% increased movement speed";
										default:
											return Lang.toolTip(l, true);
									}
									break;
>>>>>>> origin/master
							}
						}
						else
						{
							switch (l)
							{
<<<<<<< HEAD
							case 422:
								return "신성이 전파됩니다";
							case 423:
								return "타락성이 전파됩니다";
							case 424:
								goto IL_A9EF;
							case 425:
								return "마법의 요정을 소환합니다";
							default:
								if (l == 434)
								{
									return "세번 발포";
								}
								switch (l)
								{
								case 485:
									return "착용한 사람은 밤에 늑대인간으로 변화됩니다";
								case 486:
									return "화면상에 블럭 배치를 위한 측량을 표시합니다";
								case 487:
								case 488:
								case 494:
								case 498:
								case 499:
								case 500:
								case 501:
								case 502:
								case 503:
								case 504:
								case 505:
								case 507:
								case 508:
								case 511:
								case 512:
								case 513:
								case 514:
								case 530:
								case 537:
								case 538:
								case 539:
								case 540:
								case 545:
								case 546:
								case 550:
								case 562:
								case 563:
								case 564:
								case 565:
								case 566:
								case 567:
								case 568:
								case 569:
								case 570:
								case 571:
								case 572:
								case 573:
								case 574:
								case 577:
								case 578:
								case 586:
								case 587:
								case 588:
								case 589:
								case 590:
								case 591:
								case 592:
								case 593:
								case 594:
								case 595:
								case 596:
								case 597:
								case 598:
									goto IL_A9EF;
								case 489:
									return "마법 피해량이 15% 만큼 증가합니다";
								case 490:
									return "근접공격의 피해량이 15% 만큼 증가합니다";
								case 491:
									return "원거리공격의 피해량이 15% 만큼 증가합니다";
								case 492:
									return "비행과 낙하 속도 감소를 가능케 합니다";
								case 493:
									return "비행과 낙하 속도 감소를 가능케 합니다l";
								case 495:
									return "제어 가능한 무지개를 소환합니다";
								case 496:
									return "얼음 블럭을 소환합니다";
								case 497:
									return "물 속에 들어갈때 착용한 사람을 머포크로 변화시킵니다";
								case 506:
									return "젤을 탄약으로 사용합니다";
								case 509:
									return "빨간 전선을 설치합니다";
								case 510:
									return "전선을 제거합니다";
								case 515:
									return "충격을 받을 때 크리스탈 조각을 생성합니다"
								case 516:
									return "충돌을 받을 때 별똥별을 소환합니다";
								case 517:
									return "마력으로 돌아오는 칼을 소환합니다";
								case 518:
									return "크리스탈 조각을 빠르게 쏩니다";
								case 519:
									return "불경스러운 불공을 소환합니다";
								case 520:
									return "'빛의 생명의 정수'";
								case 521:
									return "'어둠의 생명의 정수'";
								case 522:
									return "'물도 이 불을 끄지는 못합니다'";
								case 523:
									return "물 속에도 설치할 수 있습니다";
								case 524:
									return "아드만타이트와 티타늄 광물을 제련할 때 쓰입니다";
								case 525:
									return "미스릴, 오리칼쿰, 아다만타이트, 티타늄 괴를 사용하는 조합에 필요합니다";
								case 526:
									return "'마법적이고 날카로운!'";
								case 527:
									return "'타락한 사막의 생명체에서 가끔 발견됩니다'";
								case 528:
									return "'신성한 사막의 생명체에서 가끔 발견됩니다'";
								case 529:
									return "밟으면 작동합니다";
								case 531:
									return "강화될 수 있습니다";
								case 532:
									return "다치면 하늘에서 별이 떨어집니다";
								case 533:
									return "탄약을 50% 확률로 사용하지 않습니다";
								case 534:
									return "분산되는 총알을 발포합니다";
								case 535:
									return "치료 물약의 재사용 시간이 감소합니다";
								case 536:
									return "근접공격 넉백이 증가합니다";
								case 541:
									return "밟으면 작동합니다";
								case 542:
									return "플레이어가 밟을 경우 작동합니다";
								case 543:
									return "플레이어가 밟을 경우 작동합니다";
								case 544:
									return "쌍둥이를 소환합니다";
								case 547:
									return "'순수한 공포의 정수'";
								case 548:
									return "'파괴자의 정수'";
								case 549:
									return "'관찰자의 정수'";
								case 551:
									return "치명타 확률이 7% 만큼 증가합니다";
								case 552:
									return "피해량이 7% 만큼 증가합니다";
								case 553:
									return "원거리공격의 피해량이 15% 만큼 증가합니다";
								case 554:
									return "피해를 받고 난 뒤 무적시간이 소폭 증가합니다";
								case 555:
									return "마나 소모량이 8% 만큼 감소합니다";
								case 556:
									return "파괴자를 소환합니다";
								case 557:
									return "스켈레트론 프라임을 소환합니다";
								case 558:
									return "마나 최대치가 100 만큼 증가합니다";
								case 559:
									return "근접공격의 피해량과 치명타 확률이 10% 만큼 증가합니다";
								case 560:
									return "왕 슬라임을 소환합니다";
								case 561:
									return "다섯개 까지 겹쳐집니다";
								case 575:
									return "'강력한 비행 생물의 정수'";
								case 576:
									return "노래를 녹음할수도 있습니다";
								case 579:
									return "'톱괭이랑 헷갈리지 마세요'";
								case 580:
									return "작동되면 폭발합니다";
								case 581:
									return "출구 펌프로 물을 받아냅니다";
								case 582:
									return "입구 펌프에서 물을 받아옵니다";
								case 583:
									return "매 초마다 작동됩니다";
								case 584:
									return "매 3초마다 작동됩니다";
								case 585:
									return "매 5초마다 작동됩니다";
								case 599:
									return "우클릭으로 열기";
								case 600:
									return "우클릭으로 열기";
								case 601:
									return "우클릭으로 열기";
								case 602:
									return "한기의 군단을 소환합니다";
								case 603:
									return "애완용 토끼을 소환합니다";
=======
								case 707:
									return "Tells the time";
								case 708:
									return "Tells the time";
								case 709:
									return "Tells the time";
>>>>>>> origin/master
								default:
									if (l == 716)
									{
										return "Used to craft items from metal bars";
									}
									switch (l)
									{
										case 723:
											return "Shoots a beam of light";
										case 724:
											return "Shoots an icy bolt";
										case 725:
											return "Shoots frost arrows";
										case 726:
											return "Shoots a stream of frost";
										default:
											return Lang.toolTip(l, true);
									}
									break;
							}
						}
					}
					else if (l <= 823)
					{
						if (l <= 753)
						{
<<<<<<< HEAD
						case 665:
						case 666:
						case 667:
						case 668:
							goto IL_3341;
						case 669:
							return "새끼팽귄을 소환합니다";
						default:
							switch (l)
							{
							case 676:
								return "아이스볼트를 쏘아냅니다";
							case 677:
							case 679:
							case 680:
							case 681:
							case 682:
								goto IL_A9EF;
							case 678:
								return "돈좀 있는 사람들만 사용하세요";
							case 683:
								return "악마의 삼지창을 소환합니다";
							case 684:
								return "근접과 원거리 공격의 피해량이 16% 만큼 증가합니다";
							case 685:
								return "근접과 원거리 공격의 치명타 확률이 11% 만큼 증가합니다";
							case 686:
								return "이동속도가 8% 만큼 증가합니다";
							default:
								goto IL_A9EF;
=======
							switch (l)
							{
								case 748:
									return "Allows flight and slow fall";
								case 749:
									return "Allows flight and slow fall";
								default:
									if (l != 753)
									{
										return Lang.toolTip(l, true);
									}
									return "Summons a pet turtle";
>>>>>>> origin/master
							}
						}
						else
						{
<<<<<<< HEAD
						case 707:
							return "시간을 알려줍니다";
						case 708:
							return "시간을 알려줍니다";
						case 709:
							return "시간을 알려줍니다";
						default:
							if (l == 716)
							{
								return "금속괴를 사용하는 조합에 필요합니다";
							}
							switch (l)
							{
							case 723:
								return "빛줄기를 발사합니다";
							case 724:
								return "아이스볼트를 발사합니다";
							case 725:
								return "얼어붙은 화살을 발사합니다";
							case 726:
								return "숲의 줄기를 발사합니다";
							default:
								goto IL_A9EF;
							}
							break;
						}
					}
				}
				else if (l <= 823)
				{
					if (l <= 753)
					{
						switch (l)
						{
						case 748:
							return "비행과 낙하속도 감소를 가능케 합니다";
						case 749:
							return "비행과 낙하속도 감소를 가능케 합니다";
						default:
							if (l != 753)
=======
							if (l == 761)
							{
								return "Allows flight and slow fall";
							}
							switch (l)
>>>>>>> origin/master
							{
								case 779:
									return "Creates and destroys biomes when sprayed";
								case 780:
									return "Used by the Clentaminator";
								case 781:
									return "Used by the Clentaminator";
								case 782:
									return "Used by the Clentaminator";
								case 783:
									return "Used by the Clentaminator";
								case 784:
									return "Used by the Clentaminator";
								case 785:
									return "Allows flight and slow fall";
								case 786:
									return "Allows flight and slow fall";
								case 787:
									return "Strong enough to destroy Demon Altars";
								case 788:
									return "Summons a thorn spear";
								case 789:
								case 790:
								case 791:
								case 795:
								case 796:
								case 797:
									return Lang.toolTip(l, true);
								case 792:
									return "2% increased damage";
								case 793:
									return "2% increased damage";
								case 794:
									return "2% increased damage";
								case 798:
									return "Able to mine Hellstone";
								default:
									switch (l)
									{
										case 821:
											return "Allows flight and slow fall";
										case 822:
											return "Allows flight and slow fall";
										case 823:
											return "Allows flight and slow fall";
										default:
											return Lang.toolTip(l, true);
									}
									break;
							}
<<<<<<< HEAD
							return "애완용 거북이를 소환합니다";
=======
>>>>>>> origin/master
						}
					}
					else if (l <= 1072)
					{
						if (l == 832)
						{
<<<<<<< HEAD
							return "비행과 낙하속도 감소를 가능케 합니다";
						}
						switch (l)
						{
						case 779:
							return "바이옴을 변화시킵니다";
						case 780:
							return "정화오염장치에 의해 사용가능합니다";
						case 781:
							return "정화오염장치에 의해 사용가능합니다";
						case 782:
							return "정화오염장치에 의해 사용가능합니다";
						case 783:
							return "정화오염장치에 의해 사용가능합니다";
						case 784:
							return "정화오염장치에 의해 사용가능합니다";
						case 785:
							return "비행과 낙하속도 감소를 가능케 합니다";
						case 786:
							return "비행과 낙하속도 감소를 가능케 합니다";
						case 787:
							return "악마의 제단을 부술 수 있을만큼 강력합니다";
						case 788:
							return "가시창을 소환합니다";
						case 789:
						case 790:
						case 791:
						case 795:
						case 796:
						case 797:
							goto IL_A9EF;
						case 792:
							return "피해량이 2% 만큼 증가합니다";
						case 793:
							return "피해량이 2% 만큼 증가합니다";
						case 794:
							return "피해량이 2% 만큼 증가합니다";
						case 798:
							return "지옥돌을 채광할 수 있습니다";
						default:
							switch (l)
							{
							case 821:
								return "비행과 낙하속도 감소를 가능케 합니다";
							case 822:
								return "비행과 낙하속도 감소를 가능케 합니다";
							case 823:
								return "비행과 낙하속도 감소를 가능케 합니다";
=======
							return "Places living wood";
						}
						switch (l)
						{
							case 849:
								return "Enables solid blocks to be toggled on and off";
							case 850:
								return "Places blue wire";
							case 851:
								return "Places green wire";
							case 852:
								return "Activates when a player steps on it";
							case 853:
								return "Activates when anything but a player steps on it";
							case 854:
								return "Shops have lower prices";
							case 855:
								return "Hitting enemies will sometimes drop extra coins";
							case 856:
								return "'Having a wonderful time!'";
							case 857:
								return "Allows the holder to do an improved double jump";
							case 858:
							case 859:
							case 864:
							case 865:
							case 866:
							case 867:
							case 868:
							case 869:
							case 870:
							case 871:
							case 872:
							case 873:
							case 874:
							case 875:
							case 876:
							case 877:
							case 878:
							case 879:
							case 880:
							case 881:
							case 882:
							case 883:
							case 884:
							case 894:
							case 895:
							case 896:
							case 909:
							case 910:
							case 911:
							case 912:
							case 913:
							case 914:
							case 915:
							case 916:
							case 917:
							case 918:
							case 919:
							case 920:
							case 921:
							case 922:
							case 923:
							case 924:
							case 925:
							case 926:
							case 927:
							case 928:
							case 929:
							case 930:
							case 931:
							case 939:
							case 940:
							case 941:
							case 942:
							case 943:
							case 944:
							case 945:
							case 949:
							case 952:
							case 954:
							case 955:
							case 970:
							case 971:
							case 972:
							case 973:
							case 974:
							case 978:
							case 979:
							case 980:
							case 981:
							case 988:
							case 991:
							case 992:
							case 993:
							case 999:
								return Lang.toolTip(l, true);
							case 860:
								return "Provides life regeneration and reduces the cooldown of healing potions";
							case 861:
								return "Turns the holder into a werewolf at night and a merfolk when entering water";
							case 862:
								return "Causes stars to fall and increases length of invincibility after taking damage";
							case 863:
								return "Provides the ability to walk on water";
							case 885:
								return "Immunity to Bleeding";
							case 886:
								return "Immunity to Broken Armor";
							case 887:
								return "Immunity to Poison";
							case 888:
								return "Immunity to Darkness";
							case 889:
								return "Immunity to Slow";
							case 890:
								return "Immunity to Silence";
							case 891:
								return "Immunity to Curse";
							case 892:
								return "Immunity to Weakness";
							case 893:
								return "Immunity to Confusion";
							case 897:
								return "Increases melee knockback";
							case 898:
								return "Allows flight";
							case 899:
								return "Increases all stats if worn during the day";
							case 900:
								return "Increases all stats if worn during the night";
							case 901:
								return "Immunity to Weakness and Broken Armor";
							case 902:
								return "Immunity to Poison and Bleeding";
							case 903:
								return "Immunity to Slow and Confusion";
							case 904:
								return "Immunity to Silence and Curse";
							case 905:
								return "Uses coins for ammo";
							case 906:
								return "Provides 7 seconds of immunity to lava";
							case 907:
								return "Provides the ability to walk on water";
							case 908:
								return "Provides the ability to walk on water and lava";
							case 932:
								return "Places bone";
							case 933:
								return "Places leaves";
							case 934:
								return "Allows the owner to float for a few seconds";
							case 935:
								return "12% increased damage";
							case 936:
								return "Increases melee knockback";
							case 937:
								return "Explodes when stepped on";
							case 938:
								return "Absorbs 25% of damage done to players on your team";
							case 946:
								return "You will fall slower while holding this";
							case 947:
								return "'Reacts to the light'";
							case 948:
								return "Allows flight and slowfall";
							case 950:
								return "Provides extra mobility on ice";
							case 951:
								return "Rapidly launches snowballs";
							case 953:
								return "Allows the ability to slide down walls";
							case 956:
								return "7% increased melee speed";
							case 957:
								return "7% increased melee speed";
							case 958:
								return "7% increased melee speed";
							case 959:
								break;
							case 960:
								return "Increases maximum mana by 40";
							case 961:
								return "Increases maximum mana by 20";
							case 962:
								return "Increases maximum mana by 20";
							case 963:
								return "Gives a chance to dodge attacks";
							case 964:
								return "Fires a spread of bullets";
							case 965:
								return "Can be climbed on";
							case 966:
								return "Life regen is increased when near a campfire";
							case 967:
								return "Put it on a stick and roast over a campfire";
							case 968:
								return "Roast it over a campfire!";
							case 969:
								return "Minor improvements to all stats";
							case 975:
								return "Allows the ability to slide down walls";
							case 976:
								return "Allows the ability to climb walls";
							case 977:
								return "Allows the ability to dash";
							case 982:
								return "Increases maximum mana by 20";
							case 983:
								return "Allows the holder to double jump";
							case 984:
								return "Allows the ability to climb walls and dash";
							case 985:
								return "Throw to create a climbable line of rope";
							case 986:
								return "Allows the collection of seeds for ammo";
							case 987:
								return "Allows the holder to double jump";
							case 989:
								return "Shoots an enchanted sword beam";
							case 990:
								return "'Not to be confused with a hamdrill'";
							case 994:
								return "Summons a Baby Eater of Souls";
							case 995:
								return "Used to craft objects";
							case 996:
								return "Used to craft objects";
							case 997:
								return "Turns silt/slush/fossils into something more useful";
							case 998:
								return "Used to craft objects";
							case 1000:
								return "Shoots confetti everywhere!";
							case 1001:
								return "16% increased melee damage";
							case 1002:
								return "16% increased ranged damage";
							case 1003:
								return "Increases maximum mana by 80 and reduces mana usage by 17%";
							case 1004:
								return "5% increased damage";
							case 1005:
								return "8% increased critical strike chance";
							case 1006:
								return "Reacts to the light";
>>>>>>> origin/master
							default:
								switch (l)
								{
									case 1071:
										return "Used with paint to color blocks";
									case 1072:
										return "Used with paint to color walls";
									default:
										return Lang.toolTip(l, true);
								}
								break;
						}
					}
<<<<<<< HEAD
				}
				else if (l <= 1072)
				{
					if (l == 832)
					{
						return "생나무를 설치합니다";
					}
					switch (l)
					{
					case 849:
						return "고체 블럭을 활성화 하거나 비활성화 할 수 있습니다";
					case 850:
						return "파란 전선을 설치합니다";
					case 851:
						return "녹색 전선을 설치합니다";
					case 852:
						return "플레이어가 밟았을 때 작동합니다";
					case 853:
						return "플레이어를 제외한 다른 것들이 밟았을 때 작동합니다";
					case 854:
						return "상점이 낮은 가격에 물건을 내놓게 됩니다";
					case 855:
						return "적을 공격하면 추가로 동전을 획득할 확률이 증가합니다";
					case 856:
						return "'아주 멋진 시간을 보내고 있어요!'";
					case 857:
						return "착용자가 향상된 더블 점프를 사용할 수 있게 됩니다";
					case 858:
					case 859:
					case 864:
					case 865:
					case 866:
					case 867:
					case 868:
					case 869:
					case 870:
					case 871:
					case 872:
					case 873:
					case 874:
					case 875:
					case 876:
					case 877:
					case 878:
					case 879:
					case 880:
					case 881:
					case 882:
					case 883:
					case 884:
					case 894:
					case 895:
					case 896:
					case 909:
					case 910:
					case 911:
					case 912:
					case 913:
					case 914:
					case 915:
					case 916:
					case 917:
					case 918:
					case 919:
					case 920:
					case 921:
					case 922:
					case 923:
					case 924:
					case 925:
					case 926:
					case 927:
					case 928:
					case 929:
					case 930:
					case 931:
					case 939:
					case 940:
					case 941:
					case 942:
					case 943:
					case 944:
					case 945:
					case 949:
					case 952:
					case 954:
					case 955:
					case 970:
					case 971:
					case 972:
					case 973:
					case 974:
					case 978:
					case 979:
					case 980:
					case 981:
					case 988:
					case 991:
					case 992:
					case 993:
					case 999:
						goto IL_A9EF;
					case 860:
						return "생명 회복력이 향상되고 회복 물약의 재사용 시간이 감소합니다 ";
					case 861:
						return "착용자를 밤에는 늑대인간으로, 물속에 들어가면 머포크로 변화시킵니다";
					case 862:
						return "피해를 입을때 별이 떨어지고 무적시간이 소폭 증가합니다";
					case 863:
						return "물 위를 걸을 수 있는 능력을 줍니다";
					case 885:
						return "출혈에 면역이 생깁니다";
					case 886:
						return "부서진 갑옷에 면역이 생깁니다";
					case 887:
						return "독에 면역이 생깁니다";
					case 888:
						return "암흑에 면역이 생깁니다";
					case 889:
						return "둔화에 면역이 생깁니다";
					case 890:
						return "침묵에 면역이 생깁니다";
					case 891:
						return "저주에 면역이 생깁니다";
					case 892:
						return "약화에 면역이 생깁니다";
					case 893:
						return "혼란에 면역이 생깁니다";
					case 897:
						return "근접공격 넉백이 증가합니다";
					case 898:
						return "비행을 가능케 합니다";
					case 899:
						return "착용자는 낮동안 모든 스탯이 소폭 상승합니다";
					case 900:
						return "착용자는 밤동안 모든 스탯이 소폭 상승합니다";
					case 901:
						return "약화와 부서진 갑옷에 면역이 생깁니다";
					case 902:
						return "독과 출혈에 면역이 생깁니다";
					case 903:
						return "둔화와 혼란에 면역이 생깁니다";
					case 904:
						return "침묵과 저주에 면역이 생깁니다";
					case 905:
						return "돈을 탄약처럼 사용합니다";
					case 906:
						return "7초동안 용암에 면역이 생깁니다";
					case 907:
						return "물 위를 걸을 수 있는 능력이 생깁니다";
					case 908:
						return "물과 용암 위를 걸을 수 있는 능력이 생깁니다";
					case 932:
						return "뼈를 설치합니다";
					case 933:
						return "나뭇잎을 설치합니다";
					case 934:
						return "소지자를 몇초동안 공중에 뜨게 합니다";
					case 935:
						return "피해량이 12% 만큼 증가합니다";
					case 936:
						return "근접공격 넉백을 증가시킵니다";
					case 937:
						return "밟으면 폭발합니다";
					case 938:
						return "팀원에게 주어진 데미지의 25% 의 피해를 흡수합니다";
					case 946:
						return "이것을 들고 있을때 낙하속도가 감소합니다";
					case 947:
						return "'빛과 반응합니다'";
					case 948:
						return "비행과 낙하속도 감소를 가능케 합니다";
					case 950:
						return "얼음 위의 기동성을 증가시킵니다";
					case 951:
						return "빠르게 눈뭉치를 발사합니다";
					case 953:
						return "벽을 타고 내려갈 수 있게 됩니다";
					case 956:
						return "근접공격 속도가 7%만큼 증가합니다";
					case 957:
						return "근접공격 속도가 7%만큼 증가합니다";
					case 958:
						return "근접공격 속도가 7%만큼 증가합니다";
					case 959:
						break;
					case 960:
						return "마나 최대치가 40 만큼 증가합니다";
					case 961:
						return "마나 최대치가 20 만큼 증가합니다";
					case 962:
						return "마나 최대치가 20 만큼 증가합니다";
					case 963:
						return "일정 확률로 공격을 회피할수 있습니다";
					case 964:
						return "분산되는 탄약을 발사합니다";
					case 965:
						return "타고 올라갈 수 있습니다";
					case 966:
						return "캠프파이어 근처에서는 생명력 회복이 향상됩니다";
					case 967:
						return "나뭇가지 위에 올려 캠프파이어에서 구워보세요";
					case 968:
						return "캠프파이어에서 구워보세요!";
					case 969:
						return "모든 스텟이 소폭 향상됩니다";
					case 975:
						return "벽을 타고 내려갈 수 있게 됩니다";
					case 976:
						return "벽을 탈 수 있게 됩니다";
					case 977:
						return "돌진할 수 있게 됩니다";
					case 982:
						return "마나 최대치가 20 만큼 증가합니다";
					case 983:
						return "착용자는 더블점프를 사용할 수 있습니다";
					case 984:
						return "벽타기와 돌진을 할 수 있게 됩니다";
					case 985:
						return "올라 탈 수 있는 밧줄을 던집니다 ";
					case 986:
						return "탄약을 위한 씨앗을 모을 수 있게 됩니다";
					case 987:
						return "착용자는 더블점프를 사용할 수 있습니다";
					case 989:
						return "강화된 검기를 날립니다";
					case 990:
						return "'망드릴과 헷갈리지 마세요'";
					case 994:
						return "새끼 영혼을 먹는 자를 소환합니다";
					case 995:
						return "조합에 필요합니다";
					case 996:
						return "조합에 필요합니다";
					case 997:
						return "모래덩어리/진창 눈/화석을 더 쓸모 있는 것으로 바꿉니다";
					case 998:
						return "조합에 필요합니다";
					case 1000:
						return "꽃가루를 뿌립니다!";
					case 1001:
						return "근접공격의 피해량이 16% 상승합니다";
					case 1002:
						return "원거리공격의 피해량이 16% 상승합니다";
					case 1003:
						return "마나 최대치가 80 만큼 증가하고 마나 소모량이 17%가 감사합니다";
					case 1004:
						return "피해량이 5% 만큼 증가합니다합니다";
					case 1005:
						return "치명타 확률이 8% 만큼 증가합니다합니다";
					case 1006:
						return "빛에 반응합니다";
					default:
						switch (l)
						{
						case 1071:
							return "페인트를 사용하여 블럭을 색칠합니다";
						case 1072:
							return "페인트를 사용하여 벽을 색칠합니다";
						default:
							goto IL_A9EF;
=======
					else
					{
						switch (l)
						{
							case 1100:
								return "Used to remove paint";
							case 1101:
							case 1102:
							case 1103:
							case 1104:
							case 1105:
							case 1106:
							case 1124:
							case 1125:
							case 1126:
							case 1127:
							case 1128:
							case 1134:
							case 1135:
							case 1136:
							case 1137:
							case 1138:
							case 1139:
							case 1140:
							case 1142:
							case 1143:
							case 1144:
							case 1146:
							case 1147:
							case 1148:
							case 1149:
							case 1150:
							case 1152:
							case 1153:
							case 1154:
							case 1155:
							case 1166:
							case 1168:
							case 1173:
							case 1174:
							case 1175:
							case 1176:
							case 1177:
							case 1184:
							case 1185:
							case 1186:
							case 1187:
							case 1190:
							case 1191:
							case 1192:
							case 1193:
							case 1194:
							case 1197:
							case 1198:
							case 1199:
							case 1200:
							case 1201:
							case 1202:
							case 1203:
							case 1204:
							case 1222:
							case 1223:
							case 1224:
							case 1225:
							case 1229:
							case 1230:
							case 1231:
							case 1232:
							case 1233:
							case 1234:
							case 1236:
							case 1237:
							case 1238:
							case 1239:
							case 1240:
							case 1241:
							case 1243:
							case 1245:
							case 1246:
							case 1257:
							case 1262:
							case 1263:
							case 1266:
							case 1267:
							case 1268:
							case 1269:
							case 1270:
							case 1271:
							case 1272:
							case 1273:
							case 1274:
							case 1275:
							case 1276:
							case 1277:
							case 1278:
							case 1279:
							case 1280:
							case 1281:
							case 1288:
							case 1289:
							case 1292:
							case 1298:
							case 1302:
							case 1304:
							case 1305:
							case 1319:
							case 1320:
							case 1324:
							case 1325:
							case 1328:
							case 1329:
							case 1330:
							case 1337:
							case 1338:
							case 1339:
							case 1340:
							case 1341:
							case 1342:
								return Lang.toolTip(l, true);
							case 1107:
								return "Used to make Teal Dye";
							case 1108:
								return "Used to make Green Dye";
							case 1109:
								return "Used to make Sky Blue Dye";
							case 1110:
								return "Used to make Yellow Dye";
							case 1111:
								return "Used to make Blue Dye";
							case 1112:
								return "Used to make Lime Dye";
							case 1113:
								return "Used to make Pink Dye";
							case 1114:
								return "Used to make Orange Dye";
							case 1115:
								return "Used to make Red Dye";
							case 1116:
								return "Used to make Cyan Dye";
							case 1117:
								return "Used to make Violet Dye";
							case 1118:
								return "Used to make Purple Dye";
							case 1119:
								return "Used to make Black Dye";
							case 1120:
								return "Used to Craft Dyes";
							case 1121:
								return "Shoots bees that will chase your enemy";
							case 1122:
								return "Chases after your enemy";
							case 1123:
								return "Summons killer bees after striking your foe";
							case 1129:
								return "Places Hives";
							case 1130:
								return "Explodes into a swarm of bees";
							case 1131:
								return "Allows the holder to reverse gravity";
							case 1132:
								return "Releases bees when damaged";
							case 1133:
								return "Summons the Queen Bee";
							case 1141:
								return "Opens the jungle temple door";
							case 1145:
								return "Used for basic crafting";
							case 1151:
								return "Activates when a player steps on it";
							case 1156:
								return "Latches on to enemies for continuous damage";
							case 1157:
								return "Summons a Pygmy to fight for you";
							case 1158:
								return "Increases your max number of minions";
							case 1159:
								return "Increases your max number of minions";
							case 1160:
								return "Increases your max number of minions";
							case 1161:
								return "Increases your max number of minions";
							case 1162:
								return "Allows flight and slow fall";
							case 1163:
								return "Allows the holder to double jump";
							case 1164:
								return "Allows the holder to quadruple jump";
							case 1165:
								return "Allows flight and slow fall";
							case 1167:
								return "Increases the damage of your minions by 15%";
							case 1169:
								return "Summons a Baby Skeletron Head";
							case 1170:
								return "Summons a Baby Hornet";
							case 1171:
								return "Summons a Tiki Spirit";
							case 1172:
								return "Summons a Pet Lizard";
							case 1178:
								return "Rapidly shoots razor sharp leaves";
							case 1179:
								return "Chases after your enemy";
							case 1180:
								return "Summons a Pet Parrot";
							case 1181:
								return "Summons a Baby Truffle";
							case 1182:
								return "Summons a Pet Sapling";
							case 1183:
								return "Summons a Wisp to provide light";
							case 1188:
								return "Can mine Mythril and Orichalcum";
							case 1189:
								return "Can mine Mythril and Orichalcum";
							case 1195:
								return "Can mine Adamantite and Titanium";
							case 1196:
								return "Can mine Adamantite and Titanium";
							case 1205:
								return "8% increased melee damage";
							case 1206:
								return "9% increased ranged damage";
							case 1207:
								return "7% increased magic damage and critical strike chance";
							case 1208:
								return "3% increased damage";
							case 1209:
								return "2% increased damage";
							case 1210:
								return "7% increased melee damage";
							case 1211:
								return "15% increased ranged critical strike chance";
							case 1212:
								return "18% increased magic critical strike chance";
							case 1213:
								return "6% increased critical strike chance";
							case 1214:
								return "11% increased movement speed";
							case 1215:
								return "8% increased melee damage and critical strike chance";
							case 1216:
								return "16% increased ranged damage";
							case 1217:
								return "16% increased magic damage and 7% increased magic critical strike chance";
							case 1218:
								return "4% increased damage";
							case 1219:
								return "3% increased damage and critical strike chance";
							case 1220:
								return "Used to craft items from mythril, orichalcum, adamantite, and titanium bars";
							case 1221:
								return "Used to smelt adamantite and titanium ore";
							case 1226:
								return "Shoots a powerful orb";
							case 1227:
								return "Shoots a spore cloud";
							case 1228:
								return "Shoots a spore cloud";
							case 1235:
								return "Bounces back after hitting a wall";
							case 1242:
								return "Summons a Baby Dinosaur";
							case 1244:
								return "Summons a cloud to rain down on your foes";
							case 1247:
								return "Causes stars to fall and releases bees when injured";
							case 1248:
								return "10% increased critical strike chance";
							case 1249:
								return "Increases jump height";
							case 1250:
								return "Allows the holder to double jump";
							case 1251:
								return "Allows the holder to double jump";
							case 1252:
								return "Allows the holder to double jump";
							case 1253:
								return "Puts a shell around the owner when below 50% life that reduces damage";
							case 1254:
								return "Shoots a powerful, high velocity bullet";
							case 1255:
								return "Shoots a powerful, high velocity bullet";
							case 1256:
								return "Summons a cloud to rain blood on your foes";
							case 1258:
								return "Shoots an explosive bolt";
							case 1259:
								return "Shoots razor sharp flower petals at nearby enemies";
							case 1260:
								return "Shoots a rainbow that does continuous damage";
							case 1261:
								return "Explodes into deadly shrapnel";
							case 1264:
								return "Shoots a ball of frost";
							case 1265:
								return "Shoots a powerful, high velocity bullet";
							case 1282:
								return "Increases maximum mana by 20";
							case 1283:
								return "Increases maximum mana by 40";
							case 1284:
								return "Increases maximum mana by 40";
							case 1285:
								return "Increases maximum mana by 60";
							case 1286:
								return "Increases maximum mana by 60";
							case 1287:
								return "Increases maximum mana by 80";
							case 1290:
								return "Increases movement speed after being struck";
							case 1291:
								return "Permanently increases maximum life by 5";
							case 1293:
								return "Used at the Lihzahrd Altar";
							case 1294:
								return "Capable of mining Lihzahrd Bricks";
							case 1295:
								return "Shoots a piercing ray of heat";
							case 1296:
								return "Summons a powerful boulder";
							case 1297:
								return "Punches with the force of a golem";
							case 1299:
								return "Increases view range when held";
							case 1300:
								return "Increases view range for guns";
							case 1301:
								return "10% increased damage";
							case 1303:
								return "Provides light under water";
							case 1306:
								return "Shoots an icy sickle";
							case 1307:
								return "'You are a terrible person'";
							case 1308:
								return "Shoots a poison fang that pierces multiple enemies";
							case 1309:
								return "Summons a baby slime to fight for you";
							case 1310:
								return "Inflicts poison on enemies";
							case 1311:
								return "Summons an eyeball spring";
							case 1312:
								return "Summons a baby snowman";
							case 1313:
								return "Shoots a skull";
							case 1314:
								return "Shoots a boxing glove";
							case 1315:
								return "Summons a pirate invasion";
							case 1316:
								return "6% increased melee damage";
							case 1317:
								return "8% increased melee damage and critical strike chance";
							case 1318:
								return "4% increased melee critical strike chance";
							case 1321:
								return "Increases damage by 10% and greatly increases arrow speed";
							case 1322:
								return "Inflicts fire damage on attack";
							case 1323:
								return "Reduces damage from touching lava";
							case 1326:
								return "Teleports you to the position of the mouse";
							case 1327:
								return "Shoots a deathly sickle";
							case 1331:
								return "Summons the Brain of Cthulhu";
							case 1332:
								return "'The blood of gods'";
							case 1333:
								return "Can be placed in water";
							case 1334:
								return "Decreases target's defense";
							case 1335:
								return "Decreases target's defense";
							case 1336:
								return "Sprays a shower of ichor";
							case 1343:
								return "Increases melee knockback and inflicts fire damage on attack";
							default:
								switch (l)
								{
									case 1430:
										return "Used to craft weapon imbuement flasks";
									case 1431:
										return Lang.toolTip(l, true);
									case 1432:
										return "Used to craft various types of ammo";
									default:
										switch (l)
										{
											case 1444:
												return "Creates a shadow beam that bounces off walls";
											case 1445:
												return "Launches a ball of fire that explodes into a raging inferno";
											case 1446:
												return "Summons a lost soul to chase your foes";
											case 1447:
											case 1448:
												return Lang.toolTip(l, true);
											case 1449:
												return "Blows bubbles";
											case 1450:
												return "Blows bubbles";
											default:
												return Lang.toolTip(l, true);
										}
										break;
								}
								break;
>>>>>>> origin/master
						}
					}
					return "5% increased ranged damage.";
				}
				if (l > 2535)
				{
					if (l <= 3124)
					{
<<<<<<< HEAD
					case 1100:
						return "페인트를 지울 때 사용합니다";
					case 1101:
					case 1102:
					case 1103:
					case 1104:
					case 1105:
					case 1106:
					case 1124:
					case 1125:
					case 1126:
					case 1127:
					case 1128:
					case 1134:
					case 1135:
					case 1136:
					case 1137:
					case 1138:
					case 1139:
					case 1140:
					case 1142:
					case 1143:
					case 1144:
					case 1146:
					case 1147:
					case 1148:
					case 1149:
					case 1150:
					case 1152:
					case 1153:
					case 1154:
					case 1155:
					case 1166:
					case 1168:
					case 1173:
					case 1174:
					case 1175:
					case 1176:
					case 1177:
					case 1184:
					case 1185:
					case 1186:
					case 1187:
					case 1190:
					case 1191:
					case 1192:
					case 1193:
					case 1194:
					case 1197:
					case 1198:
					case 1199:
					case 1200:
					case 1201:
					case 1202:
					case 1203:
					case 1204:
					case 1222:
					case 1223:
					case 1224:
					case 1225:
					case 1229:
					case 1230:
					case 1231:
					case 1232:
					case 1233:
					case 1234:
					case 1236:
					case 1237:
					case 1238:
					case 1239:
					case 1240:
					case 1241:
					case 1243:
					case 1245:
					case 1246:
					case 1257:
					case 1262:
					case 1263:
					case 1266:
					case 1267:
					case 1268:
					case 1269:
					case 1270:
					case 1271:
					case 1272:
					case 1273:
					case 1274:
					case 1275:
					case 1276:
					case 1277:
					case 1278:
					case 1279:
					case 1280:
					case 1281:
					case 1288:
					case 1289:
					case 1292:
					case 1298:
					case 1302:
					case 1304:
					case 1305:
					case 1319:
					case 1320:
					case 1324:
					case 1325:
					case 1328:
					case 1329:
					case 1330:
					case 1337:
					case 1338:
					case 1339:
					case 1340:
					case 1341:
					case 1342:
						goto IL_A9EF;
					case 1107:
						return "틸 청록색 염료를 만드는데 쓰입니다";
					case 1108:
						return "초록색 염료를 만드는데 쓰입니다";
					case 1109:
						return "하늘색 염료를 만드는데 쓰입니다";
					case 1110:
						return "노란색 염료를 만드는데 쓰입니다";
					case 1111:
						return "파란색 염료를 만드는데 쓰입니다";
					case 1112:
						return "연두색 염료를 만드는데 쓰입니다";
					case 1113:
						return "핑크색 염료를 만드는데 쓰입니다";
					case 1114:
						return "주황색 염료를 만드는데 쓰입니다";
					case 1115:
						return "빨간색 염료를 만드는데 쓰입니다";
					case 1116:
						return "시안 청록색 염료를 만드는데 쓰입니다";
					case 1117:
						return "제비꽃 색 염료를 만드는데 쓰입니다";
					case 1118:
						return "보라색 염료를 만드는데 쓰입니다";
					case 1119:
						return "검은색 염료를 만드는데 쓰입니다";
					case 1120:
						return "염료를 만들때 쓰입니다";
					case 1121:
						return "적을 쫓아가는 벌들을 쏘아냅니다";
					case 1122:
						return "적들을 쫓아갑니다";
					case 1123:
						return "적을 공격하면 적을 쫓아가는 살인벌을 소환합니다";
					case 1129:
						return "벌집을 설치합니다";
					case 1130:
						return "터질때 벌 때를 소환합니다";
					case 1131:
						return "소유자는 중력을 바꿀 수 있습니다";
					case 1132:
						return "피해를 입으면 벌들을 소환합니다";
					case 1133:
						return "여왕벌을 소환합니다";
					case 1141:
						return "정글 신전의 문을 엽니다";
					case 1145:
						return "기본적인 조합에 필요합니다";
					case 1151:
						return "플레이어가 밟으면 작동합니다";
					case 1156:
						return "적을 물어 지속적인 피해를 입힙니다";
					case 1157:
						return "피그미를 소환하여 싸우게 합니다";
					case 1158:
						return "소환수의 최대수가 증가합니다";
					case 1159:
						return "소환수의 최대수가 증가합니다";
					case 1160:
						return "소환수의 최대수가 증가합니다";
					case 1161:
						return "소환수의 최대수가 증가합니다";
					case 1162:
						return "비행과 낙하속도 감소를 가능케 합니다";
					case 1163:
						return "착용자는 더블점프를 사용할 수 있습니다";
					case 1164:
						return "착용자는 쿼드라점프를 사용할 수 있습니다";
					case 1165:
						return "비행과 낙하속도 감소를 가능케 합니다";
					case 1167:
						return "소환수의 피해를 15% 만큼 증가합니다시킵니다";
					case 1169:
						return "새끼 스켈레트론의 머리를 소환합니다";
					case 1170:
						return "새끼 말벌을 소환합니다";
					case 1171:
						return "티키의 영혼을 소환합니다";
					case 1172:
						return "애완용 도마뱀을 소환합니다";
					case 1178:
						return "날카로운 나뭇잎을 빠르게 쏘아냅니다";
					case 1179:
						return "적을 쫓아갑니다";
					case 1180:
						return "애완용 앵무새를 소환합니다";
					case 1181:
						return "새끼 트러플을 소환합니다";
					case 1182:
						return "애완용 묘목을 소환합니다";
					case 1183:
						return "빛을 발산하는 위습을 소환합니다";
					case 1188:
						return "미스릴과 오리칼쿰을 채광할 수 있습니다";
					case 1189:
						return "미스릴과 오리칼쿰을 채광할 수 있습니다";
					case 1195:
						return "아다만타이트와 티타늄을 채광할 수 있습니다";
					case 1196:
						return "아다만타이트와 티타늄을 채광할 수 있습니다";
					case 1205:
						return "근접공격의 피해량이 8% 만큼 증가합니다";
					case 1206:
						return "원거리공격의 피해량이 9% 만큼 증가합니다";
					case 1207:
						return "마법공격 피해량과 치명타 확률이 7% 만큼 증가합니다";
					case 1208:
						return "피해량이 3% 만큼 증가합니다";
					case 1209:
						return "피해량이 2% 만큼 증가합니다";
					case 1210:
						return "근접공격의 피해량이 7% 만큼 증가합니다";
					case 1211:
						return "원거리공격의 피해량과 치명타 확률이 15% 만큼 증가합니다";
					case 1212:
						return "마법공격 피해량과 치명타 확률이 18% i만큼 증가합니다";
					case 1213:
						return "치명타 확률이 6% 만큼 증가합니다";
					case 1214:
						return "이동속도가 11% 만큼 증가합니다";
					case 1215:
						return "근접공격의 피해량과 치명타 확률이 8% 만큼 증가합니다";
					case 1216:
						return "원거리공격의 피해량이 16% 상승합니다";
					case 1217:
						return "마법피해량이 16% 만큼 증가하고 치명타 확률이 7% 만큼 증가합니다";
					case 1218:
						return "피해량이 4% 만큼 증가합니다";
					case 1219:
						return "피해량과 치명타 확률이 3% 만큼 증가합니다";
					case 1220:
						return "미스릴, 오리칼쿰, 아다만타이트, 티타늄 괴를 사용하는 조합에 필요합니다";
					case 1221:
						return "아다만타이트와 티타늄 광석을 제련할 때 쓰입니다";
					case 1226:
						return "강력한 오브를 쏘아냅니다";
					case 1227:
						return "포자구름을 쏘아냅니다";
					case 1228:
						return "포자구름을 쏘아냅니다";
					case 1235:
						return "벽에 튕깁니다";
					case 1242:
						return "새끼 공룡을 소환합니다";
					case 1244:
						return "적을 공격하는 먹구름을 소환합니다";
					case 1247:
						return "다칠 경우 별이 떨어지고 벌들이 소환됩니다";
					case 1248:
						return "치명타 확률이 10% 만큼 증가합니다합니다";
					case 1249:
						return "뛰는 높이가 증가합니다";
					case 1250:
						return "착용자는 더블점프를 사용할 수 있습니다";
					case 1251:
						return "착용자는 더블점프를 사용할 수 있습니다";
					case 1252:
						return "착용자는 더블점프를 사용할 수 있습니다";
					case 1253:
						return "생명력이 50% 이하로 떨어질 경우 충격을 줄여주는 방어막이 생성됩니다";
					case 1254:
						return "강력하고 속도가 빠른 탄환을 발포합니다";
					case 1255:
						return "강력하고 속도가 빠른 탄환을 발포합니다";
					case 1256:
						return "적을 공격하는 먹구름을 소환합니다";
					case 1258:
						return "폭발하는 탄환을 발포합니다";
					case 1259:
						return "주변 적에게 날카로운 꽃잎을 쏘아냅니다";
					case 1260:
						return "지속적인 피해를 가하는 무지개를 쏩니다";
					case 1261:
						return "폭발하여 치명적인 파편들을 쏘아냅니다";
					case 1264:
						return "한기의 구체를 쏘아냅니다";
					case 1265:
						return "강력하고 속도가 빠른 탄환을 발포합니다";
					case 1282:
						return "마나 최대치가 20 만큼 증가합니다";
					case 1283:
						return "마나 최대치가 40 만큼 증가합니다";
					case 1284:
						return "마나 최대치가 40 만큼 증가합니다";
					case 1285:
						return "마나 최대치가 60 만큼 증가합니다";
					case 1286:
						return "마나 최대치가 60 만큼 증가합니다";
					case 1287:
						return "마나 최대치가 80 만큼 증가합니다";
					case 1290:
						return "피해를 입으면 순간적으로 이동속도가 빨라집니다";
					case 1291:
						return "생명력이 영구적으로 5 증가합니다";
					case 1293:
						return "리자드 제단에 쓰입니다";
					case 1294:
						return "리자드 블럭을 캘 수 있습니다";
					case 1295:
						return "관통하는 열의 광선을 발포합니다";
					case 1296:
						return "강력한 바위를 소환합니다 ";
					case 1297:
						return "골렘의 힘으로 주먹질을 합니다";
					case 1299:
						return "들면 시야가 늘어납니다";
					case 1300:
						return "총을 위한 시야가 늘어납니다";
					case 1301:
						return "피해량이 10% 만큼 늘어납니다";
					case 1303:
						return "수중에서 빛을 발산합니다";
					case 1306:
						return "얼음의 대낫을 쏘아냅니다";
					case 1307:
						return "'당신은 정말 최악이군요'";
					case 1308:
						return "적을 관통하는 독이빨을 소환합니다";
					case 1309:
						return "적을 공격하는 새끼 슬라임을 소환합니다";
					case 1310:
						return "적에게 독을 입힙니다";
					case 1311:
						return "눈알 용수철을 소환합니다";
					case 1312:
						return "새끼 눈사람을 소환합니다";
					case 1313:
						return "해골을 쏘아냅니다";
					case 1314:
						return "권투글러브를 쏩니다";
					case 1315:
						return "해적을 소환합니다";
					case 1316:
						return "근접공격의 피해량이 6% 만큼 늘어납니다";
					case 1317:
						return "근접공격의 피해량과 치명타 확률이 8% 만큼 늘어납니다";
					case 1318:
						return "근접공격의 피해량과 치명타 확률이 4% 만큼 늘어납니다";
					case 1321:
						return "피해량이 10% 만큼 늘어나고 화살의 속도가 대폭 상승합니다";
					case 1322:
						return "공격에 화염 피해를 추가합니다";
					case 1323:
						return "용암의 피해량을 줄입니다";
					case 1326:
						return "마우스커서로 순간이동합니다";
					case 1327:
						return "죽음의 대낫을 쏘아냅니다";
					case 1331:
						return "크툴후의 뇌를 소환합니다";
					case 1332:
						return "'신의 피'";
					case 1333:
						return "물 속에도 설치할 수 있습니다";
					case 1334:
						return "목표의 방어력이 감소합니다";
					case 1335:
						return "목표의 방어력이 감소합니다";
					case 1336:
						return "이코르 줄기를 뿌립니다";
					case 1343:
						return "근접공격 넉백을 증가시키며 공격에 화염피해가 붙습니다";
					default:
						switch (l)
						{
						case 1430:
							return "투척용 플라스크를 만들 때 필요합니다";
						case 1431:
							goto IL_A9EF;
						case 1432:
							return "많은 종류의 탄약을 만드는데 사용됩니다";
						default:
							switch (l)
							{
							case 1444:
								return "벽에 튕기는 그림자광선을 쏩니다";
							case 1445:
								return "불타오르는 지옥으로 변하는 불공을 쏩니다";
							case 1446:
								return "적을 공격하는 길잃은 영혼을 소환합니다 ";
							case 1447:
							case 1448:
								goto IL_A9EF;
							case 1449:
								return "비눗방울을 만듭니다";
							case 1450:
								return "비눗방울을 만듭니다";
							default:
								goto IL_A9EF;
							}
							break;
						}
						break;
					}
				}
				return "원거리공격의 피해량이 5% 만큼 늘어납니다 .";
			}
			if (l > 2535)
			{
				if (l <= 3124)
				{
					if (l <= 2699)
					{
						if (l <= 2590)
						{
							if (l == 2551)
							{
								return "적을 공격하는 거미들을 소환합니다";
=======
						if (l <= 2699)
						{
							if (l <= 2590)
							{
								if (l == 2551)
								{
									return "Summons spiders to fight for you";
								}
								switch (l)
								{
									case 2584:
										return "Summons pirates to fight for you";
									case 2585:
									case 2588:
									case 2589:
										return Lang.toolTip(l, true);
									case 2586:
										break;
									case 2587:
										return "Summons a mini minotaur";
									case 2590:
										return "A small explosion that puts enemies on fire";
									default:
										return Lang.toolTip(l, true);
								}
							}
							else
							{
								switch (l)
								{
									case 2609:
										return "Allows flight and slow fall";
									case 2610:
										return "Squirts a harmless stream of slime";
									case 2611:
										return "Spews homing bubbles";
									default:
										switch (l)
										{
											case 2621:
												return "Summons sharknados to fight for you";
											case 2622:
												return "Casts fast moving razorwheels";
											case 2623:
												return "Rapidly shoots forceful bubbles";
											case 2624:
												return "Shoots 5 arrows at a time";
											default:
												if (l != 2699)
												{
													return Lang.toolTip(l, true);
												}
												return "Right click to place item on weapon rack";
										}
										break;
								}
>>>>>>> origin/master
							}
						}
						else if (l <= 2799)
						{
							switch (l)
							{
<<<<<<< HEAD
							case 2584:
								return "적을 공격하는 해적들을 소환합니다";
							case 2585:
							case 2588:
							case 2589:
								goto IL_A9EF;
							case 2586:
								break;
							case 2587:
								return "미니 미노타우를 소환합니다";
							case 2590:
								return "작은 폭발력을 가지고 있으며 적에게 불을 붙입니다";
							default:
								goto IL_A9EF;
=======
								case 2739:
									return "Hammer to change direction";
								case 2740:
								case 2741:
								case 2742:
								case 2743:
								case 2744:
								case 2745:
								case 2746:
								case 2747:
								case 2748:
								case 2751:
								case 2752:
								case 2753:
								case 2754:
								case 2755:
								case 2756:
								case 2766:
									return Lang.toolTip(l, true);
								case 2749:
									return "Summons a UFO to fight for you";
								case 2750:
									return "Showers meteors";
								case 2757:
									return "16% increased ranged damage";
								case 2758:
									return "12% increased ranged damage and critical strike chance";
								case 2759:
									return "8% increased ranged damage and critical strike chance";
								case 2760:
									return "Increases maximum mana by 60 and reduces mana usage by 15% ";
								case 2761:
									return "9% increased magic damage and critical strike chance";
								case 2762:
									return "10% increased magic damage";
								case 2763:
									return "17% increased melee critical strike chance";
								case 2764:
									return "22% increased melee damage";
								case 2765:
									return "15% increased movement and melee speed";
								case 2767:
									return "Summons the Eclipse";
								case 2768:
									return "Summons a rideable Drill mount";
								case 2769:
									return "Summons a rideable UFO mount";
								case 2770:
									return "Allows flight and slow fall";
								case 2771:
									return "Summons a rideable Scutlix mount";
								default:
									if (l != 2799)
									{
										return Lang.toolTip(l, true);
									}
									return "Creates measurement lines on screen for block placement";
>>>>>>> origin/master
							}
						}
						else
						{
							switch (l)
							{
<<<<<<< HEAD
							case 2609:
								return "비행과 낙하속도 감소를 가능케 합니다";
							case 2610:
								return "피해가 없는 슬라임 줄기를 쏩니다";
							case 2611:
								return "유도성이 있는 방울을 쏩니다";
							default:
								switch (l)
								{
								case 2621:
									return "적을 공격하는 샤크네이도를 소환합니다";
								case 2622:
									return "빠르게 움직이는 날카로운 태풍을 쏘아냅니다";
								case 2623:
									return "강력한 방울들을 빠르게 쏘아냅니다";
								case 2624:
									return "화살 다섯개를 동시에 쏩니다";
=======
								case 2886:
									goto IL_21BF;
								case 2887:
									return Lang.toolTip(l, true);
								case 2888:
									return "Wooden arrows turn into a column of bees";
>>>>>>> origin/master
								default:
									if (l == 2896)
									{
										goto IL_233F;
									}
<<<<<<< HEAD
									return "우클릭으로 무기를 무기 선반에 올립니다";
								}
								break;
=======
									switch (l)
									{
										case 2997:
											return "Teleports you to a party member";
										case 2998:
											return "15% increased summon damage";
										case 2999:
											return "Right click to have more minions";
										case 3000:
											return "33% chance to not consume potion crafting ingredients";
										case 3001:
											return "'It looks and smells terrible'";
										case 3002:
											return "Exposes nearby treasure";
										case 3003:
										case 3007:
										case 3008:
										case 3009:
										case 3010:
										case 3011:
										case 3012:
										case 3013:
										case 3018:
										case 3020:
										case 3021:
										case 3022:
										case 3023:
										case 3025:
										case 3026:
										case 3027:
										case 3028:
										case 3038:
										case 3039:
										case 3040:
										case 3041:
										case 3042:
										case 3044:
										case 3045:
										case 3055:
										case 3056:
										case 3057:
										case 3058:
										case 3059:
										case 3063:
										case 3065:
										case 3066:
										case 3067:
										case 3070:
										case 3071:
										case 3072:
										case 3073:
										case 3074:
										case 3075:
										case 3076:
										case 3077:
										case 3078:
										case 3079:
										case 3080:
										case 3081:
										case 3082:
										case 3083:
										case 3086:
										case 3087:
										case 3088:
										case 3089:
										case 3094:
										case 3100:
										case 3101:
										case 3103:
										case 3104:
										case 3105:
										case 3107:
										case 3108:
										case 3114:
											return Lang.toolTip(l, true);
										case 3004:
											return "'Emits a deathly glow'";
										case 3005:
											return "Throw to create a climbable line of vine rope";
										case 3006:
											return "Drains life from enemies";
										case 3014:
											return "Summons a wall of cursed flames";
										case 3015:
											return "Enemies are less likely to target you";
										case 3016:
											return "Enemies are more likely to target you";
										case 3017:
											return "Flowers grow on the grass you walk on";
										case 3019:
											return "Wooden arrows turn into flaming bats";
										case 3024:
											goto IL_3341;
										case 3029:
											return "Shoots arrows from the sky";
										case 3030:
											return "Throws a controllable flying knife";
										case 3031:
											return "Contains an endless amount of water";
										case 3032:
											return "Capable of soaking up an endless amount of water";
										case 3033:
											return "Increases coin pickup range";
										case 3034:
											return "Increases coin pickup range";
										case 3035:
											return "Increases coin pickup range and shops have lower prices";
										case 3036:
											return "Displays weather, moon phase, and fishing information";
										case 3037:
											return "Displays the weather";
										case 3043:
											return "Summons a magic lantern that exposes nearby treasure";
										case 3046:
											return "Life regen is increased when near a campfire";
										case 3047:
											return "Life regen is increased when near a campfire";
										case 3048:
											return "Life regen is increased when near a campfire";
										case 3049:
											return "Life regen is increased when near a campfire";
										case 3050:
											return "Life regen is increased when near a campfire";
										case 3051:
											return "Summons a massive crystal spike";
										case 3052:
											return "Shoots Shadowflame Arrows";
										case 3053:
											return "Summons Shadowflame tentacles to strike your foe";
										case 3054:
											return "Inflicts Shadowflame on hit";
										case 3060:
											return "Summons a Baby Face Monster";
										case 3061:
											return "Increases tile and wall placement speed and reach";
										case 3062:
											return "Summons a heart to provide light";
										case 3064:
											return "Allows time to fast forward one day per week";
										case 3068:
											return "Allows the collection of Vine Rope from vines";
										case 3069:
											return "Shoots a small spark";
										case 3084:
											return "Detects enemies around you";
										case 3085:
											return "Right click to open";
										case 3090:
											return "Slimes become friendly";
										case 3091:
											return "'Charged with the essence of many souls'";
										case 3092:
											return "'Charged with the essence of many souls'";
										case 3093:
											return "Right click to open";
										case 3095:
											return "Displays how many monsters have been killed";
										case 3096:
											return "Displays the phase of the moon";
										case 3097:
											return "Allows the player to dash into the enemy";
										case 3098:
											return "Sparks emit from struck enemies";
										case 3099:
											return "Displays how fast the player is moving";
										case 3102:
											return "Displays the most valuable ore around you";
										case 3106:
											return "Allows you to go into stealth mode";
										case 3109:
											return "Improves vision";
										case 3110:
											return "Turns the holder into a werewolf at night and a merfolk when entering water";
										case 3111:
											return "'Bouncy and sweet!'";
										case 3112:
											return "Works when wet";
										case 3113:
											return "Very bouncy";
										case 3115:
											return "A small explosion that will destroy some tiles";
										case 3116:
											return "A small explosion that will not destroy tiles";
										case 3117:
											return "Makes surrounding creatures less hostile";
										case 3118:
											return "Displays the name of rare creatures around you";
										case 3119:
											return "Displays your damage per second";
										case 3120:
											return "Displays fishing information";
										case 3121:
											return "Displays movement speed, damage per second, and valuable ore";
										case 3122:
											return "Displays number of monsters, kill count, and rare creatures";
										case 3123:
											return "Displays everything";
										case 3124:
											return "Displays everything";
										default:
											return Lang.toolTip(l, true);
									}
									break;
>>>>>>> origin/master
							}
						}
					}
					else if (l <= 3288)
					{
						if (l <= 3245)
						{
<<<<<<< HEAD
						case 2739:
							return "방향을 바꾸려면 망치질을 하세요";
						case 2740:
						case 2741:
						case 2742:
						case 2743:
						case 2744:
						case 2745:
						case 2746:
						case 2747:
						case 2748:
						case 2751:
						case 2752:
						case 2753:
						case 2754:
						case 2755:
						case 2756:
						case 2766:
							goto IL_A9EF;
						case 2749:
							return "적을 공격하는 UFO를 소환합니다";
						case 2750:
							return "메테오를 시전합니다";
						case 2757:
							return "원거리공격의 피해량이 16% 상승합니다";
						case 2758:
							return "원거리공격의 피해량과 치명타 확률이 12% 만큼 증가합니다";
						case 2759:
							return "원거리공격의 피해량과 치명타 확률이 8% 만큼 증가합니다";
						case 2760:
							return "마나 최대치가 60 만큼 증가하고 마나 소모량이 15% 만큼 감소합니다";
						case 2761:
							return "마법공격의 피해량과 치명타 확률이 9% 만큼 증가합니다";
						case 2762:
							return "마법공격의 피해량이 10% 만큼 증가합니다";
						case 2763:
							return "근접공격의 피해량과 치명타 확률이 17% 만큼 증가합니다";
						case 2764:
							return "근접공격의 피해량이 22% 만큼 증가합니다";
						case 2765:
							return "이동속도와 근접공격 속도가 15% 만큼 증가합니다";
						case 2767:
							return "일식을 소환합니다";
						case 2768:
							return "Summons a rideable Drill mount";
						case 2769:
							return "탈 수 있는 UFO를 소환합니다";
						case 2770:
							return "비행과 낙하속도 감소를 가능케 합니다";
						case 2771:
							return "Summons a rideable Scutlix mount";
						default:
							if (l != 2799)
=======
							switch (l)
>>>>>>> origin/master
							{
								case 3195:
									return "Minor improvements to all stats";
								case 3196:
									return "A small explosion that will destroy some tiles";
								case 3197:
								case 3202:
								case 3214:
								case 3215:
								case 3216:
								case 3217:
								case 3218:
								case 3219:
								case 3220:
								case 3221:
								case 3222:
								case 3229:
								case 3230:
								case 3231:
								case 3232:
								case 3233:
								case 3234:
								case 3235:
								case 3236:
								case 3237:
								case 3238:
								case 3239:
								case 3240:
									return Lang.toolTip(l, true);
								case 3198:
									return "Increases armor penetration for melee weapons";
								case 3199:
									return "Gaze in the mirror to return home";
								case 3200:
									return "The wearer can run super fast";
								case 3201:
									return "Allows the holder to double jump";
								case 3203:
									return "Right click to open";
								case 3204:
									return "Right click to open";
								case 3205:
									return "Right click to open";
								case 3206:
									return "Right click to open";
								case 3207:
									return "Right click to open";
								case 3208:
									return "Right click to open";
								case 3209:
									return "Shoots an explosive crystal charge";
								case 3210:
									return "Spits toxic bubbles";
								case 3211:
									return "Spits an Ichor stream on contact";
								case 3212:
									return "Increases armor penetration by 5";
								case 3213:
									return "Summons a flying piggy bank to store your items";
								case 3223:
									return "May confuse nearby enemies after being struck";
								case 3224:
									return "Reduces damage taken by 17%";
								case 3225:
									return "Increases jump height";
								case 3226:
								case 3227:
								case 3228:
									goto IL_3341;
								case 3241:
									return "Increases jump height";
								default:
									if (l != 3245)
									{
										return Lang.toolTip(l, true);
									}
									return "Throws empowered bones";
							}
<<<<<<< HEAD
							return "화면상에 블럭 배치를 위한 측량을 표시합니다";
=======
>>>>>>> origin/master
						}
						else
						{
<<<<<<< HEAD
						case 2886:
							goto IL_21BF;
						case 2887:
							goto IL_A9EF;
						case 2888:
							return "나무 화살이 벌로 바뀝니다";
						default:
							if (l == 2896)
							{
								goto IL_233F;
							}
							switch (l)
							{
							case 2997:
								return "팀 멤버에게로 순간이동합니다";
							case 2998:
								return "소환수의 피해량이 15% 만큼 증가합니다";
							case 2999:
								return "소환수를 늘리려면 우클릭하세요";
							case 3000:
								return "물약 재료가 33% 의 확률로 소모되지 않습니다";
							case 3001:
								return "'보기도 그렇고 냄새도 엄청나요'";
							case 3002:
								return "주변에 보물을 노출시킵니다";
							case 3003:
							case 3007:
							case 3008:
							case 3009:
							case 3010:
							case 3011:
							case 3012:
							case 3013:
							case 3018:
							case 3020:
							case 3021:
							case 3022:
							case 3023:
							case 3025:
							case 3026:
							case 3027:
							case 3028:
							case 3038:
							case 3039:
							case 3040:
							case 3041:
							case 3042:
							case 3044:
							case 3045:
							case 3055:
							case 3056:
							case 3057:
							case 3058:
							case 3059:
							case 3063:
							case 3065:
							case 3066:
							case 3067:
							case 3070:
							case 3071:
							case 3072:
							case 3073:
							case 3074:
							case 3075:
							case 3076:
							case 3077:
							case 3078:
							case 3079:
							case 3080:
							case 3081:
							case 3082:
							case 3083:
							case 3086:
							case 3087:
							case 3088:
							case 3089:
							case 3094:
							case 3100:
							case 3101:
							case 3103:
							case 3104:
							case 3105:
							case 3107:
							case 3108:
							case 3114:
								goto IL_A9EF;
							case 3004:
								return "'죽음처럼 빛납니다'";
							case 3005:
								return "오를 수 있는 덩굴더미를 던집니다";
							case 3006:
								return "적에게서 피를 흡수합니다";
							case 3014:
								return "저주받은 불꽃의 벽을 세웁니다";
							case 3015:
								return "적들이 목표로 삼을 확률이 적어집니다";
							case 3016:
								return "적들이 목표로 삼을 확률이 늘어납니다";
							case 3017:
								return "풀 위를 지나가면 꽃이 피어납니다";
							case 3019:
								return "나무 화살이 불타는 박쥐로 바뀝니다";
							case 3024:
								goto IL_3341;
							case 3029:
								return "하늘에서 화살이 떨어집니다";
							case 3030:
								return "제어가능한 나는 칼을 던집니다";
							case 3031:
								return "끝이 없는 양의 물을 가지고 있습니다";
							case 3032:
								return "물을 끝없이 빨아드릴 수 있습니다";
							case 3033:
								return "돈을 줍는 사거리가 증가합니다";
							case 3034:
								return "돈을 줍는 사거리가 증가합니다";
							case 3035:
								return "돈을 줍는 사거리가 증가하고 상점이 낮은 가격에 물건을 내놓게 됩니다";
							case 3036:
								return "날씨, 달 형상과 낚시정보를 표시합니다";
							case 3037:
								return "날씨를 표시합니다";
							case 3043:
								return "주변 보물을 보여주는 마법의 랜턴을 소환합니다";
							case 3046:
								return "캠프파이어 근처에서는 생명력 회복이 향상됩니다";
							case 3047:
								return "캠프파이어 근처에서는 생명력 회복이 향상됩니다";
							case 3048:
								return "캠프파이어 근처에서는 생명력 회복이 향상됩니다";
							case 3049:
								return "캠프파이어 근처에서는 생명력 회복이 향상됩니다";
							case 3050:
								return "캠프파이어 근처에서는 생명력 회복이 향상됩니다";
							case 3051:
								return "크리스탈 가시를 소환합니다";
							case 3052:
								return "그림자불꽃 화살을 쏩니다";
							case 3053:
								return "적을 공격하는 그림자불꽃 촉수를 소환합니다";
							case 3054:
								return "공격에 그림자불꽃 피해가 붙습니다";
							case 3060:
								return "새끼 얼굴 괴물을 소환합니다";
							case 3061:
								return "블럭과 벽을 쌓는 속도와 거리가 증가합니다";
							case 3062:
								return "빛을 발산하는 심장을 소환합니다";
							case 3064:
								return "한 주마다 하루를 빨리 돌릴 수 있습니다";
							case 3068:
								return "덩굴을 채집할 수 있습니다";
							case 3069:
								return "작은 불꽃을 쏩니다";
							case 3084:
								return "주변 적들을 감지합니다";
							case 3085:
								return "우클릭으로 열기";
							case 3090:
								return "슬라임이 우호적이게 됩니다";
							case 3091:
								return "'많은 영혼의 정수로 채워져 있습니다'";
							case 3092:
								return "'많은 영혼의 정수로 채워져 있습니다'";
							case 3093:
								return "우클릭으로 열기";
							case 3095:
								return "얼마나 많은 괴물을 죽였는지 표시합니다";
							case 3096:
								return "달의 형상을 표시합니다";
							case 3097:
								return "적에게 돌진할 수 있는 능력을 줍니다";
							case 3098:
								return "불꽃이 부딛힌 적에게 튑니다";
							case 3099:
								return "플레이어가 얼마나 빠른지 표시합니다";
							case 3102:
								return "주변 광물중 가장 가치있는 광물을 표시합니다";
							case 3106:
								return "은신 상태로 진입할 수 있게 해 줍니다";
							case 3109:
								return "시야를 넓혀줍니다";
							case 3110:
								return "착용자를 밤에는 늑대인간으로, 물속에 들어가면 머포크로 변화시킵니다";
							case 3111:
								return "'달콤하고 통통 튀어요!'";
							case 3112:
								return "젖으면 작동합니다";
							case 3113:
								return "아주 잘 튀어요";
							case 3115:
								return "몇몇의 블럭을 부술만한 작은 폭발력을 가지고 있습니다";
							case 3116:
								return "블럭을 부수지 못하지만 작은 폭발력을 가지고 있습니다";
							case 3117:
								return "주변 생명들을 덜 적대적이게 만듭니다";
							case 3118:
								return "주변의 희귀한 생명체를 표시합니다";
							case 3119:
								return "초당 피해량을 표시합니다";
							case 3120:
								return "낚시 정보를 표시합니다";
							case 3121:
								return "이동속도, 초당 피해량과 가장 귀한 광물을 표시합니다";
							case 3122:
								return "적의 숫자, 죽인 횟수와 희귀한 생명체를 표시합니다";
							case 3123:
								return "모든 정보를 표시합니다";
							case 3124:
								return "모든 정보를 표시합니다";
							default:
								goto IL_A9EF;
=======
							switch (l)
							{
								case 3250:
								case 3252:
									return "Allows the holder to double jump";
								case 3251:
									return "Releases bees when damaged";
								default:
									if (l == 3260)
									{
										return "Summons a rideable unicorn mount";
									}
									switch (l)
									{
										case 3287:
										case 3288:
											goto IL_3341;
										default:
											return Lang.toolTip(l, true);
									}
									break;
>>>>>>> origin/master
							}
						}
					}
					else
					{
						if (l > 3388)
						{
<<<<<<< HEAD
						case 3195:
							return "모든 스텟이 소폭 향상됩니다";
						case 3196:
							return "몇몇의 블럭을 부술만한 작은 폭발력을 가지고 있습니다";
						case 3197:
						case 3202:
						case 3214:
						case 3215:
						case 3216:
						case 3217:
						case 3218:
						case 3219:
						case 3220:
						case 3221:
						case 3222:
						case 3229:
						case 3230:
						case 3231:
						case 3232:
						case 3233:
						case 3234:
						case 3235:
						case 3236:
						case 3237:
						case 3238:
						case 3239:
						case 3240:
							goto IL_A9EF;
						case 3198:
							return "근접 무기의 방어구 관통력을 증가시킵니다";
						case 3199:
							return "거울속을 바라보아 집으로 귀한합니다";
						case 3200:
							return "착용자는 정말 빨리 달릴 수 있습니다";
						case 3201:
							return "착용자는 더블점프를 사용할 수 있습니다";
						case 3203:
							return "우클릭으로 열기";
						case 3204:
							return "우클릭으로 열기";
						case 3205:
							return "우클릭으로 열기";
						case 3206:
							return "우클릭으로 열기";
						case 3207:
							return "우클릭으로 열기";
						case 3208:
							return "우클릭으로 열기";
						case 3209:
							return "폭발성의 크리스탈을 발사합니다";
						case 3210:
							return "독성의 방울을 뱉어냅니다";
						case 3211:
							return "피해를 입으면 이코르를 쏘아냅니다";
						case 3212:
							return "방어력 관통을 5만큼 증가시킵니다";
						case 3213:
							return "나는 돼지 저금통을 소환합니다";
						case 3223:
							return "피해를 입으면 적이 혼란 상태에 빠질 수 있습니다";
						case 3224:
							return "입은 피해량이 17% 만큼 감소합니다";
						case 3225:
							return "뛰는 높이가 증가합니다";
						case 3226:
						case 3227:
						case 3228:
							goto IL_3341;
						case 3241:
							return "뛰는 높이가 증가합니다";
						default:
							if (l != 3245)
=======
							switch (l)
>>>>>>> origin/master
							{
								case 3456:
									return "'Swirling energies emanate from this fragment'";
								case 3457:
									return "'The power of a galaxy resides within this fragment'";
								case 3458:
									return "'The fury of the universe lies within this fragment'";
								case 3459:
									return "'Entrancing particles revolve around this fragment'";
								case 3460:
									return "'A pebble of the heavens'";
								case 3461:
								case 3462:
								case 3463:
								case 3464:
								case 3465:
								case 3466:
								case 3472:
								case 3480:
								case 3481:
								case 3482:
								case 3483:
								case 3484:
								case 3486:
								case 3487:
								case 3488:
								case 3489:
								case 3490:
									return Lang.toolTip(l, true);
								case 3467:
									return "'It vibrates with luminous celestial energy'";
								case 3468:
									return "Allows flight and slow fall";
								case 3469:
									return "Allows flight and slow fall";
								case 3470:
									return "Allows flight and slow fall";
								case 3471:
									return "Allows flight and slow fall";
								case 3473:
									return "'Strike with the fury of the sun'";
								case 3474:
									return "Summons a stardust cell to fight for you";
								case 3475:
									return "66% chance to not consume ammo";
								case 3476:
									return "'Conjure masses of astral energy to chase down your foes'";
								case 3477:
									return "Spreads the crimson to some blocks";
								case 3478:
									return "'Wuv... twue wuv...'";
								case 3479:
									return "'Mawwiage...'";
								case 3485:
								case 3491:
									break;
								default:
									switch (l)
									{
										case 3521:
											break;
										case 3522:
										case 3523:
										case 3524:
										case 3525:
										case 3526:
										case 3527:
										case 3528:
										case 3529:
										case 3530:
										case 3533:
										case 3534:
										case 3535:
										case 3544:
										case 3546:
											return Lang.toolTip(l, true);
										case 3531:
											return "Summons a stardust dragon to fight for you";
										case 3532:
											return "Minor improvements to all stats";
										case 3536:
											return "'Wield a small amount of power from the Vortex Tower'";
										case 3537:
											return "'Wield a small amount of power from the Nebula Tower'";
										case 3538:
											return "'Wield a small amount of power from the Stardust Tower'";
										case 3539:
											return "'Wield a small amount of power from the Solar Tower'";
										case 3540:
											return "66% chance to not consume ammo";
										case 3541:
											return "'Fire a lifeform disintegration rainbow'";
										case 3542:
											return "'From Orion's belt to the palm of your hand'";
										case 3543:
											return "'Rend your foes asunder with a spear of light!'";
										case 3545:
											return "'Guts... and Gory!'";
										case 3547:
											return "'This will prove to be terrible idea'";
										case 3548:
											goto IL_30D1;
										case 3549:
											return "Used to craft items from Lunar Fragments and Luminite";
										default:
											switch (l)
											{
												case 3567:
													return "'Line 'em up and knock 'em down...'";
												case 3568:
													return "'Shooting them down at the speed of sound!'";
												case 3569:
													return "Summons a lunar portal to shoot lasers at your enemies";
												case 3570:
													return "Rains down lunar flares";
												case 3571:
													return "Summons a radiant crystal that banishes your enemies";
												case 3572:
													return "'You want the moon? Just grapple it and pull it down!'";
												case 3573:
												case 3574:
												case 3575:
												case 3576:
												case 3584:
												case 3593:
												case 3594:
												case 3595:
												case 3596:
												case 3597:
												case 3598:
												case 3600:
													return Lang.toolTip(l, true);
												case 3577:
													return "Calls upon a suspicious looking eye to provide light";
												case 3578:
												case 3579:
												case 3580:
												case 3581:
												case 3582:
												case 3583:
												case 3585:
												case 3586:
												case 3587:
												case 3588:
												case 3589:
												case 3590:
												case 3591:
												case 3592:
												case 3599:
													goto IL_3341;
												case 3601:
													return "Summons the Impending Doom";
												default:
													return Lang.toolTip(l, true);
											}
											break;
									}
									break;
							}
<<<<<<< HEAD
							return "강력한 뼈를 던집니다";
=======
							return "Can mine Meteorite";
>>>>>>> origin/master
						}
						switch (l)
						{
<<<<<<< HEAD
						case 3250:
						case 3252:
							return "착용자는 더블점프를 사용할 수 있습니다";
						case 3251:
							return "피해를 입었을때 벌을 쏘아냅니다";
						default:
							if (l == 3260)
							{
								return "탈 수 있는 유니콘을 소환합니다";
							}
							switch (l)
							{
							case 3287:
							case 3288:
								goto IL_3341;
=======
							case 3333:
								return "Increases the strength of friendly bees";
							case 3334:
								return "Allows the use of two yoyos at once";
							case 3335:
								return "Permanently increases the number of accessory slots";
							case 3336:
								return "Summons spores over time that will damage enemies";
							case 3337:
								return "Greatly increases life regen when not moving";
>>>>>>> origin/master
							default:
								switch (l)
								{
									case 3360:
										return "Places living rich mahogany";
									case 3361:
										return "Places rich mahogany leaves";
									default:
										switch (l)
										{
											case 3366:
												return "Gives the user master yoyo skills";
											case 3367:
												return "Attracts a legendary creature which flourishes in water & combat";
											case 3368:
											case 3369:
											case 3370:
											case 3371:
											case 3372:
											case 3373:
											case 3377:
											case 3378:
											case 3379:
											case 3380:
											case 3384:
												return Lang.toolTip(l, true);
											case 3374:
												return "20% increased throwing velocity";
											case 3375:
												return "20% increased throwing damage";
											case 3376:
												return "15% increased throwing critical strike chance";
											case 3381:
												return "Increases your max number of minions";
											case 3382:
												return "Increases your max number of minions";
											case 3383:
												return "Increases your max number of minions";
											case 3385:
											case 3386:
											case 3387:
											case 3388:
												return "Can be traded for rare dyes";
											default:
												return Lang.toolTip(l, true);
										}
										break;
								}
								break;
						}
					}
				IL_30D1:
					return "A small explosion that will not destroy tiles";
				}
				if (l <= 1931)
				{
					if (l <= 1810)
					{
						if (l <= 1724)
						{
<<<<<<< HEAD
						case 3456:
							return "'이 조각에서 빙빙 도는 힘이 느껴집니다'";
						case 3457:
							return "'이 조각에는 은하계의 힘이 존재합니다'";
						case 3458:
							return "'이 조각에는 우주의 분노가 있습니다'";
						case 3459:
							return "'이 조각 근처에는 어떤 입자가 돌고 있습니다'";
						case 3460:
							return "'천국의 조약돌'";
						case 3461:
						case 3462:
						case 3463:
						case 3464:
						case 3465:
						case 3466:
						case 3472:
						case 3480:
						case 3481:
						case 3482:
						case 3483:
						case 3484:
						case 3486:
						case 3487:
						case 3488:
						case 3489:
						case 3490:
							goto IL_A9EF;
						case 3467:
							return "'빛을 발하는 천체의 에너지와 고동칩니다'";
						case 3468:
							return "비행과 낙하속도 감소를 가능케 합니다";
						case 3469:
							return "비행과 낙하속도 감소를 가능케 합니다";
						case 3470:
							return "비행과 낙하속도 감소를 가능케 합니다";
						case 3471:
							return "비행과 낙하속도 감소를 가능케 합니다";
						case 3473:
							return "'태양의 분노로 적을 공격합니다'";
						case 3474:
							return "Summons a stardust cell to fight for you";
						case 3475:
							return "탄약을 66% 확률로 사용하지 않습니다";
						case 3476:
							return "'적을 쫓아가는 마술성의 별에너지 덩어리를 소환합니다'";
						case 3477:
							return "몇몇 블럭을 핓빛으로 오염시킵니다";
						case 3478:
							return "'아랑... 진일된 아랑...'"; //사랑 진실된 사랑
						case 3479:
							return "'결온...'"; //결혼
						case 3485:
						case 3491:
							break;
						default:
							switch (l)
							{
							case 3521:
								break;
							case 3522:
							case 3523:
							case 3524:
							case 3525:
							case 3526:
							case 3527:
							case 3528:
							case 3529:
							case 3530:
							case 3533:
							case 3534:
							case 3535:
							case 3544:
							case 3546:
								goto IL_A9EF;
							case 3531:
								return "Summons a stardust dragon to fight for you";
							case 3532:
								return "모든 스텟이 소폭 향상됩니다";
							case 3536:
								return "'Wield a small amount of power from the Vortex Tower'";
							case 3537:
								return "'Wield a small amount of power from the Nebula Tower'";
							case 3538:
								return "'Wield a small amount of power from the Stardust Tower'";
							case 3539:
								return "'Wield a small amount of power from the Solar Tower'";
							case 3540:
								return "탄약을 66% 확률로 사용하지 않습니다";
							case 3541:
								return "'생명분해무지개를 쏩니다'";
							case 3542:
								return "'오리온의 허리띠부터 당신의 손까지'";
							case 3543:
								return "'빛의 창으로 적들을 갈갈이 찢어버리세요!'";
							case 3545:
								return "'용기... 그리고 폭력이 난무하는!'";
							case 3547:
								return "'이건 좀 안좋은 아이디어 같은데요'";
							case 3548:
								goto IL_30D1;
							case 3549:
								return "Used to craft items from Lunar Fragments and Luminite";
							default:
								switch (l)
								{
								case 3567:
									return "'줄세워서 때려부수고...'";
								case 3568:
									return "'음속으로 발포!'";
								case 3569:
									return "Summons a lunar portal to shoot lasers at your enemies";
								case 3570:
									return "Rains down lunar flares";
								case 3571:
									return "Summons a radiant crystal that banishes your enemies";
								case 3572:
									return "'달을 원한다고? 붙잡고 끌어내려!'";
								case 3573:
								case 3574:
								case 3575:
								case 3576:
								case 3584:
								case 3593:
								case 3594:
								case 3595:
								case 3596:
								case 3597:
								case 3598:
								case 3600:
									goto IL_A9EF;
								case 3577:
									return "Calls upon a suspicious looking eye to provide light";
								case 3578:
								case 3579:
								case 3580:
								case 3581:
								case 3582:
								case 3583:
								case 3585:
								case 3586:
								case 3587:
								case 3588:
								case 3589:
								case 3590:
								case 3591:
								case 3592:
								case 3599:
									goto IL_3341;
								case 3601:
									return "곧 임박할 종말을 소환합니다";
=======
							switch (l)
							{
								case 1503:
									return "40% decreased magic damage";
								case 1504:
									return "7% increased magic damage and critical strike chance";
								case 1505:
									return "8% increased magic damage";
								case 1506:
								case 1507:
								case 1508:
								case 1509:
								case 1510:
								case 1511:
								case 1512:
								case 1514:
								case 1516:
								case 1517:
								case 1518:
								case 1519:
								case 1520:
								case 1521:
								case 1528:
								case 1529:
								case 1530:
								case 1531:
								case 1532:
								case 1538:
								case 1539:
								case 1540:
								case 1541:
								case 1542:
								case 1552:
								case 1570:
								case 1573:
								case 1574:
								case 1575:
								case 1576:
								case 1577:
								case 1589:
								case 1590:
								case 1591:
								case 1592:
								case 1593:
								case 1594:
								case 1596:
								case 1597:
								case 1598:
								case 1599:
								case 1600:
								case 1601:
								case 1602:
								case 1603:
								case 1604:
								case 1605:
								case 1606:
								case 1607:
								case 1608:
								case 1609:
								case 1610:
								case 1611:
									return Lang.toolTip(l, true);
								case 1513:
									return "A powerful returning hammer";
								case 1515:
									return "Allows flight and slow fall";
								case 1522:
									return "For Capture the Gem. It drops when you die";
								case 1523:
									return "For Capture the Gem. It drops when you die";
								case 1524:
									return "For Capture the Gem. It drops when you die";
								case 1525:
									return "For Capture the Gem. It drops when you die";
								case 1526:
									return "For Capture the Gem. It drops when you die";
								case 1527:
									return "For Capture the Gem. It drops when you die";
								case 1533:
									return "Unlocks a Jungle Chest in the dungeon";
								case 1534:
									return "Unlocks a Corruption Chest in the dungeon";
								case 1535:
									return "Unlocks a Crimson Chest in the dungeon";
								case 1536:
									return "Unlocks a Hallowed Chest in the dungeon";
								case 1537:
									return "Unlocks a Frozen Chest in the dungeon";
								case 1543:
									return "Used with paint to color blocks";
								case 1544:
									return "Used with paint to color walls";
								case 1545:
									return "Used to remove paint";
								case 1546:
									return "15% increased arrow damage";
								case 1547:
									return "15% increased bullet damage";
								case 1548:
									return "15% increased rocket damage";
								case 1549:
									return "13% increased ranged critical strike chance";
								case 1550:
									return "7% increased ranged critical strike chance";
								case 1551:
									return "Converts Chlorophyte Bars into Shroomite Bars";
								case 1553:
									return "50% chance to not consume ammo";
								case 1554:
								case 1555:
								case 1556:
								case 1557:
								case 1558:
								case 1559:
								case 1560:
								case 1561:
								case 1562:
								case 1563:
								case 1564:
								case 1565:
								case 1566:
								case 1567:
								case 1568:
								case 1580:
								case 1581:
								case 1582:
								case 1583:
								case 1584:
								case 1585:
								case 1586:
								case 1587:
								case 1588:
									goto IL_3341;
								case 1569:
									return "Rapidly throw life stealing daggers";
								case 1571:
									return "A powerful javelin that unleashes tiny eaters";
								case 1572:
									return "Summons a powerful frost hydra to spit ice at your enemies";
								case 1578:
									return "Releases bees and increases movement speed when damaged";
								case 1579:
									return "The wearer can run super fast";
								case 1595:
									return "Increases maximum mana by 20";
								case 1612:
									return "Grants immunity to most debuffs";
								case 1613:
									return "Grants immunity to knockback and fire blocks";
								default:
									if (l != 1724)
									{
										return Lang.toolTip(l, true);
									}
									return "Allows the holder to double jump";
							}
						}
						else
						{
							switch (l)
							{
								case 1767:
									return "To me it look like a leprechaun to me";
								case 1768:
									return "I just wanna know where the gold at!";
								case 1769:
									return "I want the gold. I want the gold. I want the gold. Gimme the gold!";
>>>>>>> origin/master
								default:
									if (l == 1774)
									{
										return "Right click to open";
									}
									switch (l)
									{
										case 1782:
											return "33% chance to not consume ammo";
										case 1783:
										case 1784:
										case 1785:
										case 1788:
										case 1789:
										case 1790:
										case 1791:
										case 1792:
										case 1793:
										case 1794:
										case 1795:
										case 1796:
										case 1800:
										case 1808:
											return Lang.toolTip(l, true);
										case 1786:
											return "Allows the collection of hay from grass";
										case 1787:
											return "Minor improvements to all stats";
										case 1797:
											return "Allows flight and slow fall";
										case 1798:
											return "Summons a pet spider";
										case 1799:
											return "Summons a pet squashling";
										case 1801:
											return "Summons bats to attack your enemies";
										case 1802:
											return "Summons a raven to fight for you";
										case 1803:
											return "Used for crafting a Jungle Key";
										case 1804:
											return "Used for crafting a Corruption Key";
										case 1805:
											return "Used for crafting a Crimson Key";
										case 1806:
											return "Used for crafting a Hallowed Key";
										case 1807:
											return "Used for crafting a Frozen Key";
										case 1809:
											return "Best used for pranking townsfolk";
										case 1810:
											return "Summons a black kitty";
										default:
											return Lang.toolTip(l, true);
									}
									break;
							}
						}
<<<<<<< HEAD
						return "운석을 캘 수 있습니다";
=======
>>>>>>> origin/master
					}
					else if (l <= 1837)
					{
<<<<<<< HEAD
					case 3333:
						return "우호적인 벌들을 강력하게 만듭니다";
					case 3334:
						return "두 요요를 한번에 쓸 수 있게 됩니다";
					case 3335:
						return "엑세서리슬롯을 영구적으로 하나 늘려줍니다 ";
					case 3336:
						return "적에게 데미지를 주는 포자를 소환합니다";
					case 3337:
						return "움직이지 않을때 생명력 회복이 대폭 상승합니다";
					default:
						switch (l)
						{
						case 3360:
							return "생마호가니를 설치합니다";
						case 3361:
							return "생마호가니 나뭇잎을 설치합니다";
						default:
							switch (l)
							{
							case 3366:
								return "착용자는 요요 마스터가 됩니다";
							case 3367:
								return "물속에 산다는 전설의 생명체의 관심을 끌지도 모릅니다";
							case 3368:
							case 3369:
							case 3370:
							case 3371:
							case 3372:
							case 3373:
							case 3377:
							case 3378:
							case 3379:
							case 3380:
							case 3384:
								goto IL_A9EF;
							case 3374:
								return "투척물의 속도가 20% 만큼 증가합니다";
							case 3375:
								return "투척물의 피해량이 20% 만큼 증가합니다";
							case 3376:
								return "투척물의 치명타 확률이 15% 만큼 증가합니다";
							case 3381:
								return "소환수의 최대수가 증가합니다";
							case 3382:
								return "소환수의 최대수가 증가합니다";
							case 3383:
								return "소환수의 최대수가 증가합니다";
							case 3385:
							case 3386:
							case 3387:
							case 3388:
								return "희귀한 염료와 바꿀 수 있습니다";
=======
						switch (l)
						{
							case 1826:
								return "Summons Pumpkin heads to attack your enemies";
							case 1827:
							case 1828:
							case 1829:
							case 1831:
								return Lang.toolTip(l, true);
							case 1830:
								return "Allows flight and slow fall";
							case 1832:
								return "Increases your max number of minions";
							case 1833:
								return "Increases your max number of minions";
							case 1834:
								return "Increases your max number of minions";
>>>>>>> origin/master
							default:
								if (l != 1837)
								{
									return Lang.toolTip(l, true);
								}
								return "Summons a cursed sapling to follow you";
						}
					}
					else
					{
						switch (l)
						{
							case 1844:
								return "Summons the Pumpkin Moon";
							case 1845:
								return "Increases your max number of minions";
							default:
								switch (l)
								{
									case 1858:
										return "Increases view range for guns (right click to zoom out)";
									case 1859:
									case 1867:
									case 1868:
										return Lang.toolTip(l, true);
									case 1860:
										return "Grants the ability to swim and greatly extends underwater breathing";
									case 1861:
										return "Grants the ability to swim and greatly extends underwater breathing";
									case 1862:
										return "Allows flight, super fast running, and extra mobility on ice";
									case 1863:
										return "Allows the holder to double jump";
									case 1864:
										return "Increases your max number of minions";
									case 1865:
										return "Minor increase to damage, melee speed, critical strike chance,";
									case 1866:
										return "Allows flight and slow fall";
									case 1869:
										return "Right click to open";
									case 1870:
										return "'Don't shoot your eye out!'";
									case 1871:
										return "Allows flight and slow fall";
									default:
										switch (l)
										{
											case 1910:
												return "Uses gel for ammo";
											case 1911:
												return "Minor improvements to all stats";
											case 1912:
											case 1913:
											case 1915:
											case 1916:
											case 1918:
											case 1924:
											case 1925:
											case 1926:
												return Lang.toolTip(l, true);
											case 1914:
												return "Summons a rideable reindeer";
											case 1917:
												return "Can mine Meteorite";
											case 1919:
												return "Minor improvements to all stats";
											case 1920:
												return "Minor improvements to all stats";
											case 1921:
												return "Provides immunity to chill and freezing effects";
											case 1922:
												return "'You've been naughty this year'";
											case 1923:
												return "Increases item placement and tool range by 1";
											case 1927:
												return "Summons a Puppy";
											case 1928:
												return "Shoots Christmas ornaments";
											case 1929:
												return "50% chance to not consume ammo";
											case 1930:
												return "Shoots razor sharp pine needles";
											case 1931:
												return "Showers an area with icicles";
											default:
												return Lang.toolTip(l, true);
										}
										break;
								}
								break;
						}
					}
				}
<<<<<<< HEAD
				IL_30D1:
				return "블럭을 부수지 못하지만 작은 폭발력을 가지고 있습니다";
			}
			if (l <= 1931)
			{
				if (l <= 1810)
=======
				else if (l <= 2223)
>>>>>>> origin/master
				{
					if (l <= 1959)
					{
						switch (l)
						{
<<<<<<< HEAD
						case 1503:
							return "마법 피해량이 40% 만큼 증가합니다";
						case 1504:
							return "마법 피해량과 치명타 확률이 7% 만큼 증가합니다";
						case 1505:
							return "마법 피해량이 8% 만큼 증가합니다";
						case 1506:
						case 1507:
						case 1508:
						case 1509:
						case 1510:
						case 1511:
						case 1512:
						case 1514:
						case 1516:
						case 1517:
						case 1518:
						case 1519:
						case 1520:
						case 1521:
						case 1528:
						case 1529:
						case 1530:
						case 1531:
						case 1532:
						case 1538:
						case 1539:
						case 1540:
						case 1541:
						case 1542:
						case 1552:
						case 1570:
						case 1573:
						case 1574:
						case 1575:
						case 1576:
						case 1577:
						case 1589:
						case 1590:
						case 1591:
						case 1592:
						case 1593:
						case 1594:
						case 1596:
						case 1597:
						case 1598:
						case 1599:
						case 1600:
						case 1601:
						case 1602:
						case 1603:
						case 1604:
						case 1605:
						case 1606:
						case 1607:
						case 1608:
						case 1609:
						case 1610:
						case 1611:
							goto IL_A9EF;
						case 1513:
							return "귀소 본능이 있는 망치를 던집니다";
						case 1515:
							return "비행과 낙하속도 감소를 가능케 합니다";
						case 1522:
							return "보석 뺏기 대회를 위한 아이템. 죽으면 드롭됩니다";
						case 1523:
							return "보석 뺏기 대회를 위한 아이템. 죽으면 드롭됩니다";
						case 1524:
							return "보석 뺏기 대회를 위한 아이템. 죽으면 드롭됩니다";
						case 1525:
							return "보석 뺏기 대회를 위한 아이템. 죽으면 드롭됩니다";
						case 1526:
							return "보석 뺏기 대회를 위한 아이템. 죽으면 드롭됩니다";
						case 1527:
							return "보석 뺏기 대회를 위한 아이템. 죽으면 드롭됩니다";
						case 1533:
							return "던전 속 정글 상자를 열 수 있습니다";
						case 1534:
							return "던전 속 타락한 상자를 열 수 있습니다";
						case 1535:
							return "던전 속 진홍색 상자를 열 수 있습니다";
						case 1536:
							return "던전 속 신성한 상자를 열 수 있습니다";
						case 1537:
							return "던전 속 얼어붙은 상자를 열 수 있습니다";
						case 1543:
							return "페인트를 사용하여 블럭을 색칠합니다";
						case 1544:
							return "페인트를 사용하여 벽을 색칠합니다";
						case 1545:
							return "페인트를 지울 때 사용합니다";
						case 1546:
							return "화살공격의 피해량이 15% 만큼 증가합니다";
						case 1547:
							return "탄환공격의 피해량이 15% 만큼 증가합니다";
						case 1548:
							return "로켓공격의 피해량이 15% 만큼 증가합니다";
						case 1549:
							return "원거리공격의 치명타 확률이 13% 만큼 증가합니다";
						case 1550:
							return "원거리공격의 치명타 확률이 7% 만큼 증가합니다";
						case 1551:
							return "녹조류 괴를 슈루마이트괴로 바꿉니다";
						case 1553:
							return "탄약을 50% 확률로 소모하지 않습니다";
						case 1554:
						case 1555:
						case 1556:
						case 1557:
						case 1558:
						case 1559:
						case 1560:
						case 1561:
						case 1562:
						case 1563:
						case 1564:
						case 1565:
						case 1566:
						case 1567:
						case 1568:
						case 1580:
						case 1581:
						case 1582:
						case 1583:
						case 1584:
						case 1585:
						case 1586:
						case 1587:
						case 1588:
							goto IL_3341;
						case 1569:
							return "생명을 흡수하는 단검을 빠르게 던집니다";
						case 1571:
							return "자그마한 먹는자를 소환하는 강력한 자벨린을 던집니다";
						case 1572:
							return "적에게 얼음으로 공격하는 강력한 얼어붙은 히드라를 소환합니다";
						case 1578:
							return "공격받으면 벌을 쏘고 이동속도가 대폭 향상됩니다";
						case 1579:
							return "착용자는 엄청 빨리 달릴 수 있습니다";
						case 1595:
							return "마나 최대치가 20 만큼 증가합니다";
						case 1612:
							return "대부분의 상태이상에 면역을 가집니다";
						case 1613:
							return "넉백과 뜨거운 블럭에 면역이 생깁니다";
						default:
							if (l != 1724)
							{
								goto IL_A9EF;
							}
							return "착용자는 더블점프를 사용할 수 있습니다";
=======
							case 1946:
								return "Launches homing missiles";
							case 1947:
								return "Shoots an icy spear that rains snowflakes";
							default:
								switch (l)
								{
									case 1958:
										return "Summons the Frost Moon";
									case 1959:
										return "Summons a Baby Grinch";
									default:
										return Lang.toolTip(l, true);
								}
								break;
>>>>>>> origin/master
						}
					}
					else
					{
						if (l == 1988)
						{
							return "'Fezzes are cool'";
						}
						switch (l)
						{
<<<<<<< HEAD
						case 1767:
							return "레프라훈 같이 생겼는데?";
						case 1768:
							return "금은 도데체 어디있는거야!";
						case 1769:
							return "금을원해. 금을원해. 금을원해. 금을 내놔!";
						default:
							if (l == 1774)
							{
								return "우클릭으로 열기";
							}
							switch (l)
							{
							case 1782:
								return "탄약을 33% 확률로 소비하지 않습니다";
							case 1783:
							case 1784:
							case 1785:
							case 1788:
							case 1789:
							case 1790:
							case 1791:
							case 1792:
							case 1793:
							case 1794:
							case 1795:
							case 1796:
							case 1800:
							case 1808:
								goto IL_A9EF;
							case 1786: 
								return "";
							case 1787:
								return "모든 스텟이 소폭 향상됩니다";
							case 1797:
								return "비행과 낙하속도 감소를 가능케 합니다";
							case 1798:
								return "애완용 거미를 소환합니다";
							case 1799:
								return "애완용 스쿼실링을 소환합니다";
							case 1801:
								return "적을 공격하는 박쥐들을 소환합니다";
							case 1802:
								return "적을 공격하는 까마귀를 소환합니다";
							case 1803:
								return "정글 열쇠를 만드는데 필요합니다";
							case 1804:
								return "타락한 열쇠를 만드는데 필요합니다";
							case 1805:
								return "진홍색 열쇠를 만드는데 필요합니다";
							case 1806:
								return "신성한 열쇠를 만드는데 필요합니다";
							case 1807:
								return "얼어붙은 열쇠를 만드는데 필요합니다";
							case 1809:
								return "주민들에게 장난을 치는데 이게 딱이죠!";
							case 1810:
								return "애완용 검은 고양이를 소환합니다";
=======
							case 2172:
								return "Used for advanced crafting";
							case 2173:
							case 2174:
							case 2175:
							case 2176:
							case 2178:
							case 2179:
							case 2180:
							case 2181:
							case 2182:
							case 2183:
							case 2184:
							case 2185:
							case 2186:
							case 2187:
							case 2190:
							case 2191:
								return Lang.toolTip(l, true);
							case 2177:
								return "Reduces ammo usage by 20%";
							case 2188:
								return "Shoots a venom fang that pierces multiple enemies";
							case 2189:
								return "Increases maximum mana by 60 and reduces mana usage by 13%";
							case 2192:
								return "Used for special crafting";
							case 2193:
								return "Used for special crafting";
							case 2194:
								return "Used for special crafting";
							case 2195:
								return "Used for special crafting";
							case 2196:
								return "Used for special crafting";
							case 2197:
								return "Used for special crafting";
							case 2198:
								return "Used for special crafting";
							case 2199:
								return "6% increased melee damage";
							case 2200:
								return "8% increased melee damage and critical strike chance";
							case 2201:
								return "5% increased melee damage and critical strike chance";
							case 2202:
								return "6% increased movement and melee speed";
							case 2203:
								return "Used for special crafting";
							case 2204:
								return "Used for special crafting";
>>>>>>> origin/master
							default:
								switch (l)
								{
									case 2214:
										return "Increases tile placement speed";
									case 2215:
										return "Increases tile reach";
									case 2216:
										return "Automatically paints placed objects";
									case 2217:
										return "Increases wall placement speed";
									case 2218:
									case 2222:
										return Lang.toolTip(l, true);
									case 2219:
										return "Increases pickup range for mana stars";
									case 2220:
										return "Increases pickup range for mana stars";
									case 2221:
										return "Increases pickup range for mana stars";
									case 2223:
										return "Shoots a charged arrow";
									default:
										return Lang.toolTip(l, true);
								}
								break;
						}
					}
				}
				else if (l <= 2430)
				{
					switch (l)
					{
<<<<<<< HEAD
					case 1826:
						return "적을 공격하는 호박 머리들을 소환합니다";
					case 1827:
					case 1828:
					case 1829:
					case 1831:
						goto IL_A9EF;
					case 1830:
						return "비행과 낙하속도 감소를 가능케 합니다";
					case 1832:
						return "소환수의 최대수가 증가합니다";
					case 1833:
						return "소환수의 최대수가 증가합니다";
					case 1834:
						return "소환수의 최대수가 증가합니다";
					default:
						if (l != 1837)
						{
							goto IL_A9EF;
						}
						return "당신을 따라다니는 저주받은 묘목을 소환합니다";
=======
						case 2267:
							return "Minor improvements to all stats";
						case 2268:
							return "Minor improvements to all stats";
						case 2269:
						case 2271:
						case 2273:
						case 2274:
						case 2276:
						case 2278:
							return Lang.toolTip(l, true);
						case 2270:
							return "50% chance to not consume ammo";
						case 2272:
							return "Squirts a harmless stream of water";
						case 2275:
							return "7% increased magic damage and critical strike chance";
						case 2277:
							return "5% increased damage and critical strike chance";
						case 2279:
							return "6% increased magic damage and critical strike chance";
						case 2280:
							return "Allows flight and slow fall";
						default:
							switch (l)
							{
								case 2302:
									return "'Its colorful scales could sell well.'";
								case 2303:
								case 2304:
								case 2305:
								case 2306:
								case 2307:
								case 2309:
								case 2310:
								case 2311:
								case 2312:
								case 2313:
								case 2314:
								case 2315:
								case 2316:
								case 2317:
								case 2318:
								case 2319:
								case 2320:
								case 2321:
								case 2330:
								case 2331:
								case 2332:
								case 2333:
								case 2337:
								case 2338:
								case 2339:
								case 2341:
								case 2342:
								case 2357:
								case 2358:
								case 2360:
									return Lang.toolTip(l, true);
								case 2308:
									return "Quite shiny.  This will probably sell well.";
								case 2322:
									return "Increases mining speed by 25%";
								case 2323:
									return "Increases pickup range for life hearts";
								case 2324:
									return "Reduces enemy aggression";
								case 2325:
									return "Increases placement speed and range";
								case 2326:
									return "Increases knockback";
								case 2327:
									return "Lets you move swiftly in liquids";
								case 2328:
									return "Increases your max number of minions";
								case 2329:
									return "Allows you to see nearby danger sources";
								case 2334:
									return "Right click to open";
								case 2335:
									return "Right click to open";
								case 2336:
									return "Right click to open";
								case 2340:
									return "Hammer end piece to change bumper style";
								case 2343:
									return "Let's ride the rails";
								case 2344:
									return "20% chance to not consume ammo";
								case 2345:
									return "Increases max life by 20%";
								case 2346:
									return "Reduces damage taken by 10%";
								case 2347:
									return "Increases critical chance by 10%";
								case 2348:
									return "Ignites nearby enemies";
								case 2349:
									return "Increases damage by 10%";
								case 2350:
									return "Teleports you home";
								case 2351:
									return "Teleports you to a random location";
								case 2352:
									return "Throw this to make someone fall in love";
								case 2353:
									return "Throw this to make someone smell terrible";
								case 2354:
									return "Increases fishing skill";
								case 2355:
									return "Detects hooked fish";
								case 2356:
									return "Increases chance to get a crate";
								case 2359:
									return "Reduces damage from cold sources";
								case 2361:
									return "Increases minion damage by 4%";
								case 2362:
									return "Increases minion damage by 4%";
								case 2363:
									return "Increases minion damage by 5%";
								case 2364:
									return "Summons a hornet to fight for you";
								case 2365:
									return "Summons an imp to fight for you";
								case 2366:
									return "Summons a spider queen to spit eggs at your enemies";
								case 2367:
									return "Increases fishing level";
								case 2368:
									return "Increases fishing level";
								case 2369:
									return "Increases fishing level";
								case 2370:
									return "Increases your max number of minions";
								case 2371:
									return "Increases your max number of minions";
								case 2372:
									return "Increases your max number of minions";
								case 2373:
									return "Fishing line will never break";
								case 2374:
									return "Increases fishing skill";
								case 2375:
									return "Decreases chance of bait consumption";
								default:
									switch (l)
									{
										case 2420:
											return "Summons a pet Zephyr Fish";
										case 2421:
										case 2422:
										case 2424:
											return Lang.toolTip(l, true);
										case 2423:
											return "Increases jump speed and allows auto-jump";
										case 2425:
											return "Minor improvements to all stats";
										case 2426:
											return "Minor improvements to all stats";
										case 2427:
											return "Minor improvements to all stats";
										case 2428:
											return "Summons a rideable Bunny mount";
										case 2429:
											return "Summons a rideable Pigron mount";
										case 2430:
											return "Summons a rideable Slime mount";
										default:
											return Lang.toolTip(l, true);
									}
									break;
							}
							break;
>>>>>>> origin/master
					}
				}
				else
				{
					switch (l)
					{
<<<<<<< HEAD
					case 1844:
						return "호박 달을 소환합니다";
					case 1845:
						return "소환수의 최대수가 증가합니다";
					default:
						switch (l)
						{
						case 1858:
							return "총을 착용할 경우 시야를 늘려줍니다 (우클릭으로 사용)";
						case 1859:
						case 1867:
						case 1868:
							goto IL_A9EF;
						case 1860:
							return "수영을 가능케 하고 잠수 능력이 대폭 상승됩니다";
						case 1861:
							return "수영을 가능케 하고 잠수 능력이 대폭 상승됩니다";
						case 1862:
							return "비행을 가능케하고, 엄청 빨리 달릴 수 있으며, 얼음 위에서 기동성이 증가합니다";
						case 1863:
							return "착용자는 더블점프를 사용할 수 있습니다";
						case 1864:
							return "소환수의 최대수가 증가합니다";
						case 1865:
							return "피해량, 근접 공격속도와 치명타 확률이 소폭 상승합니다,";
						case 1866:
							return "비행과 낙하속도 감소를 가능케 합니다";
						case 1869:
							return "우클릭으로 열기";
						case 1870:
							return "'총구를 똑바로 바라보지 마세요!'";
						case 1871:
							return "비행과 낙하속도 감소를 가능케 합니다";
=======
						case 2491:
							return "Summons a rideable Turtle mount";
						case 2492:
							return "Not for use on slopes";
						case 2493:
							return Lang.toolTip(l, true);
						case 2494:
							return "Allows flight and slow fall";
>>>>>>> origin/master
						default:
							if (l == 2502)
							{
<<<<<<< HEAD
							case 1910:
								return "젤을 탄약으로 사용합니다";
							case 1911:
								return "모든 스텟이 소폭 향상됩니다";
							case 1912:
							case 1913:
							case 1915:
							case 1916:
							case 1918:
							case 1924:
							case 1925:
							case 1926:
								goto IL_A9EF;
							case 1914:
								return "탈 수 있는 사슴을 소환합니다";
							case 1917:
								return "운석을 채광할 수 있습니다";
							case 1919:
								return "모든 스텟이 소폭 향상됩니다";
							case 1920:
								return "모든 스텟이 소폭 향상됩니다";
							case 1921:
								return "얼어붙음과 추움에 면역이 생깁니다";
							case 1922:
								return "'넌 이번 해에는 착하게 굴지 않았어'";
							case 1923:
								return "블럭 배치 사거리와 도구 사용 거리가 1 늘어납니다";
							case 1927:
								return "애완용 강아지를 소환합니다";
							case 1928:
								return "크리스마스 장식을 쏘아냅니다";
							case 1929:
								return "탄약을 50% 확률로 소모하지 않습니다";
							case 1930:
								return "날카로운 솔잎을 쏘아냅니다";
							case 1931:
								return "고드름 비를 쏟아냅니다";
							default:
								goto IL_A9EF;
=======
								return "Summons a rideable Bee mount";
>>>>>>> origin/master
							}
							if (l != 2535)
							{
								return Lang.toolTip(l, true);
							}
							return "Summons twins to fight for you";
					}
				}
			IL_21BF:
				return "Banishes the Hallow";
			IL_233F:
				return "'Tossing may be difficult.'";
			IL_3341:
				return "'Great for impersonating devs!'";
			}
		}

		public static string toolTip2(int l)
		{
			if (l <= 1613)
			{
				if (l <= 953)
				{
					if (l <= 559)
					{
<<<<<<< HEAD
					case 1946:
						return "유도성 미사일을 쏘아냅니다";
					case 1947:
						return "눈꽃이 떨어지는 얼음창을 던집니다";
					default:
						switch (l)
						{
						case 1958:
							return "얼어붙은 달을 소환합니다";
						case 1959:
							return "새끼 그린치를 소환합니다";
						default:
							goto IL_A9EF;
						}
						break;
					}
				}
				else
				{
					if (l == 1988)
					{
						return "'페즈 모자들은 정말 멋져!'";
=======
						if (l <= 230)
						{
							if (l <= 98)
							{
								if (l == 65)
								{
									return "'Forged with the fury of heaven'";
								}
								if (l == 98)
								{
									return "'Half shark, half gun, completely awesome.'";
								}
							}
							else
							{
								if (l == 213)
								{
									return "Increases alchemy plant collection when used to gather";
								}
								switch (l)
								{
									case 228:
										return "4% increased magic critical strike chance";
									case 229:
										return "4% increased magic critical strike chance";
									case 230:
										return "4% increased magic critical strike chance";
								}
							}
						}
						else if (l <= 434)
						{
							switch (l)
							{
								case 371:
									return "9% increased magic critical strike chance";
								case 372:
									return "12% increased melee speed";
								case 373:
									return "6% increased ranged critical strike chance";
								case 374:
									return "3% increased critical strike chance";
								case 375:
									return "10% increased movement speed";
								case 376:
									return "15% increased magic damage";
								case 377:
									return "10% increased melee damage";
								case 378:
									return "7% increased ranged critical strike chance";
								case 379:
									return "5% increased damage";
								case 380:
									return "3% increased critical strike chance";
								case 381:
								case 382:
								case 383:
								case 384:
								case 385:
								case 386:
								case 387:
								case 388:
								case 390:
								case 391:
								case 392:
								case 393:
								case 398:
								case 403:
									break;
								case 389:
									return "'Find your inner pieces'";
								case 394:
									return "Greatly extends underwater breathing";
								case 395:
									return "Tells the time";
								case 396:
									return "Grants immunity to fire blocks";
								case 397:
									return "Grants immunity to fire blocks";
								case 399:
									return "Increases jump height";
								case 400:
									return "11% increased magic damage and critical strike chance";
								case 401:
									return "14% increased melee damage";
								case 402:
									return "8% increased ranged critical strike chance";
								case 404:
									return "5% increased movement speed";
								case 405:
									return "The wearer can run super fast";
								default:
									if (l == 434)
									{
										return "Only the first shot consumes ammo";
									}
									break;
							}
						}
						else
						{
							if (l == 533)
							{
								return "'Minishark's older brother'";
							}
							switch (l)
							{
								case 552:
									return "8% increased movement speed";
								case 553:
									return "8% increased ranged critical strike chance";
								case 555:
									return "Automatically use mana potions when needed";
								case 558:
									return "12% increased magic damage and critical strike chance";
								case 559:
									return "10% increased melee haste";
							}
						}
>>>>>>> origin/master
					}
					else if (l <= 898)
					{
<<<<<<< HEAD
					case 2172:
						return "향상된 조합에 쓰입니다";
					case 2173:
					case 2174:
					case 2175:
					case 2176:
					case 2178:
					case 2179:
					case 2180:
					case 2181:
					case 2182:
					case 2183:
					case 2184:
					case 2185:
					case 2186:
					case 2187:
					case 2190:
					case 2191:
						goto IL_A9EF;
					case 2177:
						return "탄약을 20%만큼 사용하지 않습니다";
					case 2188:
						return "적들을 관통하는 독 송곳니를 쏩니다";
					case 2189:
						return "마나 최대치가 60 만큼 증가하고 마나소모가 13% 만큼 감소합니다";
					case 2192:
						return "특별한 조합에 사용됩니다";
					case 2193:
						return "특별한 조합에 사용됩니다";
					case 2194:
						return "특별한 조합에 사용됩니다";
					case 2195:
						return "특별한 조합에 사용됩니다";
					case 2196:
						return "특별한 조합에 사용됩니다";
					case 2197:
						return "특별한 조합에 사용됩니다";
					case 2198:
						return "특별한 조합에 사용됩니다";
					case 2199:
						return "근접공격 피해량이 6% 만큼 증가합니다";
					case 2200:
						return "근접공격 피해량과 치명타 확률이 8% 만큼 증가합니다";
					case 2201:
						return "근접공격 피해량과 치명타 확률이 5% 만큼 증가합니다";
					case 2202:
						return "이동속도와 근접공격 속도가 6% 만큼 증가합니다";
					case 2203:
						return "특별한 조합에 사용됩니다";
					case 2204:
						return "특별한 조합에 사용됩니다";
					default:
						switch (l)
						{
						case 2214:
							return "블럭 배치속도가 대폭 상승합니다";
						case 2215:
							return "블럭 배치 사거리가 상승합니다";
						case 2216:
							return "자동으로 설치된 물건을 칠합니다";
						case 2217:
							return "벽 배치속도가 대폭 상승합니다";
						case 2218:
						case 2222:
							goto IL_A9EF;
						case 2219:
							return "마나별 획득 사거리가 증가합니다";
						case 2220:
							return "마나별 획득 사거리가 증가합니다";
						case 2221:
							return "마나별 획득 사거리가 증가합니다";
						case 2223:
							return "차지된 화살을 발사합니다";
						default:
							goto IL_A9EF;
=======
						if (l <= 748)
						{
							if (l == 686)
							{
								return "7% increased melee attack speed";
							}
							if (l == 748)
							{
								return "Hold UP to rocket faster";
							}
						}
						else
						{
							switch (l)
							{
								case 771:
									return "Small blast radius. Will not destroy tiles";
								case 772:
									return "Small blast radius. Will destroy tiles";
								case 773:
									return "Large blast radius. Will not destroy tiles";
								case 774:
									return "Large blast radius. Will destroy tiles";
								case 775:
									return "Increases running speed";
								case 776:
									return "Can mine Mythril and Orichalcum";
								case 777:
									return "Can mine Adamantite and Titanium";
								case 778:
									break;
								case 779:
									return "Uses colored solution";
								case 780:
									return "Spreads the Purity";
								case 781:
									return "Spreads the Hallow";
								case 782:
									return "Spreads the Corruption";
								case 783:
									return "Spreads Glowing Mushrooms";
								case 784:
									return "Spreads the Crimson";
								default:
									switch (l)
									{
										case 897:
											return "12% increased melee speed";
										case 898:
											return "The wearer can run incredibly fast";
									}
									break;
							}
>>>>>>> origin/master
						}
					}
<<<<<<< HEAD
				}
			}
			else if (l <= 2430)
			{
				switch (l)
				{
				case 2267:
					return "모든 스텟이 소폭 향상됩니다";
				case 2268:
					return "모든 스텟이 소폭 향상됩니다";
				case 2269:
				case 2271:
				case 2273:
				case 2274:
				case 2276:
				case 2278:
					goto IL_A9EF;
				case 2270:
					return "탄약을 50% 확률로 쏘지 앟ㄴ습니다";
				case 2272:
					return "피해가 없는 물줄기를 찍 발사합니다";
				case 2275:
					return "마법공격 피해량과 치명타 확률이 7% 만큼 증가합니다";
				case 2277:
					return "피해량과 치명타 확률이 5% 만큼 증가합니다";
				case 2279:
					return "마법 공격 피해량과 치명타 확률이 6% 만큼 증가합니다";
				case 2280:
					return "비행과 낙하속도 감소를 가능케 합니다";
				default:
					switch (l)
					{
					case 2302:
						return "'그 화려한 비늘들 말인데 잘 팔리겠네요'";
					case 2303:
					case 2304:
					case 2305:
					case 2306:
					case 2307:
					case 2309:
					case 2310:
					case 2311:
					case 2312:
					case 2313:
					case 2314:
					case 2315:
					case 2316:
					case 2317:
					case 2318:
					case 2319:
					case 2320:
					case 2321:
					case 2330:
					case 2331:
					case 2332:
					case 2333:
					case 2337:
					case 2338:
					case 2339:
					case 2341:
					case 2342:
					case 2357:
					case 2358:
					case 2360:
						goto IL_A9EF;
					case 2308:
						return "꽤 빛나는데.. 잘 팔리겠는데요";
					case 2322:
						return "채굴 속도가 25% 만큼 증가합니다";
					case 2323:
						return "생명의 하트를 획득하는 사거리가 늘어납니다";
					case 2324:
						return "적의 공격성이 감소합니다";
					case 2325:
						return "설치 속도와 거리가 증가합니다";
					case 2326:
						return "넉백이 증가합니다";
					case 2327:
						return "물 속에서 민첩하게 움직일 수 있습니다";
					case 2328:
						return "소환수의 최대수가 증가합니다";
					case 2329:
						return "주변의 위험 요소를 볼 수 있게 합니다";
					case 2334:
						return "우클릭으로 열기";
					case 2335:
						return "우클릭으로 열기";
					case 2336:
						return "우클릭으로 열기";
					case 2340:
						return "끝부분을 망치질하여 스타일을 바꿀 수 있습니다";
					case 2343:
						return "철도를 타자!";
					case 2344:
						return "탄약이 20% 확률로 소모되지 않습니다";
					case 2345:
						return "생명력이 일시적으로 20% 증가합니다";
					case 2346:
						return "받는 피해량이 10% 감소합니다";
					case 2347:
						return "치명타 확률이 10% 증가합니다";
					case 2348:
						return "주변 적들을 점화시킵니다";
					case 2349:
						return "주는 피해량이 10% 증가합니다";
					case 2350:
						return "집으로 순간이동합니다";
					case 2351:
						return "무작위 위치로 순간이동시킵니다";
					case 2352:
						return "누군가를 사랑에 빠지게 하세요";
					case 2353:
						return "누군가를 냄새나게 하세요";
					case 2354:
						return "낚시 기술이 향상됩니다";
					case 2355:
						return "무엇이 낚였는지 표시합니다";
					case 2356:
						return "상자를 낚을 확률이 증가합니다";
					case 2359:
						return "차가운 근원에서 온 피해가 감소합니다";
					case 2361:
						return "소환수 피해량이 4% 만큼 증가합니다";
					case 2362:
						return "소환수 피해량이 4% 만큼 증가합니다";
					case 2363:
						return "소환수 피해량이 5% 만큼 증가합니다";
					case 2364:
						return "적을 공격하는 말벌을 소환합니다";
					case 2365:
						return "적을 공격하는 도깨비를 소환합니다";
					case 2366:
						return "적에게 알을 뱉어 공격하는 여왕거미를 소환합니다";
					case 2367:
						return "낚시 능력이 향상됩니다";
					case 2368:
						return "낚시 능력이 향상됩니다";
					case 2369:
						return "낚시 능력이 향상됩니다";
					case 2370:
						return "소환수의 최대수가 증가합니다";
					case 2371:
						return "소환수의 최대수가 증가합니다";
					case 2372:
						return "소환수의 최대수가 증가합니다";
					case 2373:
						return "낚싯줄이 끊어지지 않습니다";
					case 2374:
						return "낚시 능력이 향상됩니다";
					case 2375:
						return "미끼가 소모될 확률이 감소합니다";
					default:
						switch (l)
						{
						case 2420:
							return "산들바람 물고기를 소환합니다";
						case 2421:
						case 2422:
						case 2424:
							goto IL_A9EF;
						case 2423:
							return "점프 속도를 늘이며 자동점프가 가능케 합니다";
						case 2425:
							return "모든 스텟이 소폭 향상됩니다";
						case 2426:
							return "모든 스텟이 소폭 향상됩니다";
						case 2427:
							return "모든 스텟이 소폭 향상됩니다";
						case 2428:
							return "탈 수 있는 토끼를 소환합니다";
						case 2429:
							return "탈 수 있는 피그론을 소환합니다";
						case 2430:
							return "탈 수 있는 슬라임을 소환합니다";
						default:
							goto IL_A9EF;
						}
						break;
					}
					break;
				}
			}
			else
			{
				switch (l)
				{
				case 2491:
					return "탈 수 있는 거북이를 소환합니다";
				case 2492:
					return "빗면에선 사용하지 못합니다";
				case 2493:
					goto IL_A9EF;
				case 2494:
					return "비행과 낙하속도 감소를 가능케 합니다";
				default:
					if (l == 2502)
					{
						return "탈 수 있는 벌을 소환합니다";
=======
					else if (l <= 929)
					{
						switch (l)
						{
							case 905:
								return "Higher valued coins do more damage";
							case 906:
								break;
							case 907:
								return "Grants immunity to fire blocks";
							case 908:
								return "Grants immunity to fire blocks and 7 seconds of immunity to lava";
							default:
								if (l == 929)
								{
									return "For use with cannon";
								}
								break;
						}
>>>>>>> origin/master
					}
					else
					{
<<<<<<< HEAD
						goto IL_A9EF;
					}
					return "적을 공격하는 쌍둥이를 소환합니다";
				}
			}
			IL_21BF:
			return "신성함을 사라지게 만듭니다";
			IL_233F:
			return "'던지는게 좀 어려울껄요?'";
			IL_3341:
			return "'개발자인 척 하기 딱 좋아요!'";
		}
	}
	
	public static string toolTip2(int l)
	{
		
		if (l <= 1613)
		{
			if (l <= 953)
			{
				if (l <= 559)
=======
						switch (l)
						{
							case 936:
								return "12% increased damage and melee speed";
							case 937:
								break;
							case 938:
								return "Only active above 25% life";
							default:
								if (l == 950)
								{
									return "Ice will not break when you fall on it";
								}
								if (l == 953)
								{
									return "Improved ability if combined with Shoe Spikes";
								}
								break;
						}
					}
				}
				else if (l <= 1254)
>>>>>>> origin/master
				{
					if (l <= 1005)
					{
						if (l <= 977)
						{
<<<<<<< HEAD
							if (l == 65)
							{
								return "'천국의 분노로 제련됬어요'";
							}
							if (l == 98)
							{
								return "'상어 반, 총 반, 완벽하게 엄청나죠.'";
=======
							switch (l)
							{
								case 960:
									return "4% increased magic critical strike chance";
								case 961:
									return "4% increased magic critical strike chance";
								case 962:
									return "4% increased magic critical strike chance";
								default:
									switch (l)
									{
										case 975:
											return "Improved ability if combined with Climbing Claws";
										case 977:
											return "Double tap a direction";
									}
									break;
>>>>>>> origin/master
							}
						}
						else
						{
<<<<<<< HEAD
							if (l == 213)
							{
								return "연금술 약재를 캐는데 쓰면 더 많이 캘 수 있어요";
							}
							switch (l)
							{
							case 228:
								return "마법 피해량과 치명타 확률이 4% 만큼 증가합니다";
							case 229:
								return "마법 피해량과 치명타 확률이 4% 만큼 증가합니다";
							case 230:
								return "마법 피해량과 치명타 확률이 4% 만큼 증가합니다";
=======
							switch (l)
							{
								case 982:
									return "Increases mana regeneration rate";
								case 983:
									return "Increases jump height";
								case 984:
									return "Gives a chance to dodge attacks";
								default:
									switch (l)
									{
										case 997:
											return "'To use: Place silt/slush/fossils in the extractinator'";
										case 1001:
											return "6% increased melee critical strike chance";
										case 1002:
											return "20% chance to not consume ammo";
										case 1003:
											return "16% increased magic damage";
										case 1004:
											return "7% increased critical strike chance";
										case 1005:
											return "5% increased movement speed";
									}
									break;
>>>>>>> origin/master
							}
						}
					}
					else if (l <= 1131)
					{
						if (l == 1123)
						{
<<<<<<< HEAD
						case 371:
							return "마법 피해량과 치명타 확률이 9% 만큼 증가합니다";
						case 372:
							return "근접공격 속도가 12% 만큼 증가합니다";
						case 373:
							return "원거리 피해량과 치명타 확률이 6% 증가합니다";
						case 374:
							return "치명타 확률이 3% 만큼 증가합니다";
						case 375:
							return "이동속도가 10% 만큼 증가합니다";
						case 376:
							return "마법 공격 피해량이 15% 만큼 증가합니다";
						case 377:
							return "근접 공격 피해량이 10% 만큼 증가합니다";
						case 378:
							return "원거리 피해량과 치명타 확률이 7% 증가합니다";
						case 379:
							return "피해량이 5% 만큼 증가합니다";
						case 380:
							return "치명타 확률이 3% 만큼 증가합니다";
						case 381:
						case 382:
						case 383:
						case 384:
						case 385:
						case 386:
						case 387:
						case 388:
						case 390:
						case 391:
						case 392:
						case 393:
						case 398:
						case 403:
							break;
						case 389:
							return "'내면의 평화...는 무슨'"; //원래 peace (평화) 와 piece(조각)을 이용한 말장난
						case 394:
							return "잠수 시간을 대폭 늘려줍니다";
						case 395:
							return "시간을 알려줍니다";
						case 396:
							return "뜨거운 블럭에 면역이 생깁니다";
						case 397:
							return "뜨거운 블럭에 면역이 생깁니다";
						case 399:
							return "점프 높이가 증가합니다";
						case 400:
							return "마법공격의 피해량과 치명타 확률이 11% 만큼 증가합니다";
						case 401:
							return "근접공격의 피해량이 14% 만큼 증가합니다";
						case 402:
							return "원거리공격의 피해량과 치명타 확류이 8% 만큼 증가합니다";
						case 404:
							return "이동속도가 5% 만큼 증가합니다";
						case 405:
							return "착용자는 빨리 달릴 수 있습니다";
						default:
							if (l == 434)
							{
								return "첫발만 탄약을 소비합니다";
							}
							break;
=======
							return "Small chance to cause confusion";
						}
						if (l == 1131)
						{
							return "Press UP to change gravity";
>>>>>>> origin/master
						}
					}
					else
					{
<<<<<<< HEAD
						if (l == 533)
						{
							return "'미니샤크의 형'";
						}
						switch (l)
						{
						case 552:
							return "이동속도가 8% 만큼 증가합니다";
						case 553:
							return "원거리 공격과 치명타 확률이 8% 만큼 증가합니다";
						case 555:
							return "마나물약이 필요할때마다 자동으로 사용됩니다";
						case 558:
							return "마법 공격 피해량과 치명타 확률이 12% 만큼 증가합니다";
						case 559:
							return "근접공격 속도가 10% 만큼 증가합니다";
=======
						switch (l)
						{
							case 1159:
								return "Increases minion damage by 10%";
							case 1160:
								return "Increases minion damage by 10%";
							case 1161:
								return "Increases minion damage by 10%";
							case 1162:
							case 1165:
							case 1166:
								break;
							case 1163:
								return "Increases jump height";
							case 1164:
								return "Increases jump height";
							case 1167:
								return "Increases the knockback of your minions";
							default:
								switch (l)
								{
									case 1205:
										return "12% increased melee speed";
									case 1206:
										return "9% increased ranged critical strike chance";
									case 1207:
										return "Increases maximum mana by 60";
									case 1208:
										return "2% increased critical strike chance";
									case 1209:
										return "1% increased critical strike chance";
									case 1210:
										return "7% increased movement and melee speed";
									case 1211:
										return "8% increased movement speed";
									case 1212:
										return "Increases maximum mana by 80";
									case 1213:
									case 1214:
										break;
									case 1215:
										return "8% increased melee speed";
									case 1216:
										return "7% increased ranged critical strike chance";
									case 1217:
										return "Increases maximum mana by 100";
									case 1218:
										return "3% increased critical strike chance";
									case 1219:
										return "6% increased movement speed";
									default:
										switch (l)
										{
											case 1249:
												return "Releases bees when damaged";
											case 1250:
												return "Increases jump height and negates fall damage";
											case 1251:
												return "Increases jump height and negates fall damage";
											case 1252:
												return "Increases jump height and negates fall damage";
											case 1254:
												return "Right click to zoom out";
										}
										break;
								}
								break;
>>>>>>> origin/master
						}
					}
				}
				else if (l <= 1321)
				{
					if (l <= 1295)
					{
<<<<<<< HEAD
						if (l == 686)
						{
							return "근접공격 속도가 7% 증가합니다";
						}
						if (l == 748)
						{
							return "'위'키를 눌러 재빨리 올라가세요";
=======
						switch (l)
						{
							case 1282:
								return "Reduces mana usage by 5%";
							case 1283:
								return "Reduces mana usage by 7%";
							case 1284:
								return "Reduces mana usage by 9%";
							case 1285:
								return "Reduces mana usage by 11%";
							case 1286:
								return "Reduces mana usage by 13%";
							case 1287:
								return "Reduces mana usage by 15%";
							default:
								if (l == 1295)
								{
									return "'Oolaa!!'";
								}
								break;
>>>>>>> origin/master
						}
					}
					else
					{
						switch (l)
						{
<<<<<<< HEAD
						case 771:
							return "작은 폭발력을 가지고 있습니다. 블럭은 부술 수 없습니다";
						case 772:
							return "작은 폭발력을 가지고 있습니다. 블럭을 부술 수 있습니다";
						case 773:
							return "큰 폭발력을 가지고 있습니다. 블럭은 부술 수 없습니다";
						case 774:
							return "큰 폭발력을 가지고 있습니다. 블럭을 부술 수 있습니다";
						case 775:
							return "달리는 속도가 증가합니다 ";
						case 776:
							return "미스릴과 오리칼쿰을 채광할 수 있습니다";
						case 777:
							return "아다만타이트와 티타늄을 채광할 수 있습니다";
						case 778:
							break;
						case 779:
							return "색 용액을 사용합니다";
						case 780:
							return "정화를 퍼뜨립니다";
						case 781:
							return "신성함으로 물들입니다";
						case 782:
							return "타락함을 퍼뜨립니다";
						case 783:
							return "발광버섯으로 물들입니다";
						case 784:
							return "핓빛으로 물들입니다";
						default:
							switch (l)
							{
							case 897:
								return "근접공격 속도가 12% 증가합니다";
							case 898:
								return "착용자는 믿을수 없을 정도로 빠르게 달릴 수 있습니다";
							}
							break;
=======
							case 1300:
								return "Right click to zoom out";
							case 1301:
								return "8% increased critical strike chance";
							default:
								switch (l)
								{
									case 1316:
										return "Enemies are more likely to target you";
									case 1317:
										return "Enemies are more likely to target you";
									case 1318:
										return "Enemies are more likely to target you";
									case 1321:
										return "20% chance to not consume arrows";
								}
								break;
>>>>>>> origin/master
						}
					}
				}
				else if (l <= 1505)
				{
					switch (l)
					{
<<<<<<< HEAD
					case 905:
						return "높은 가치의 돈은 피해량이 더 높습니다";
					case 906:
						break;
					case 907:
						return "뜨거운 블럭에 면역이 생깁니다";
					case 908:
						return "뜨거운 블럭에 면역이 생기고 용암에 7초 면역이 생깁니다";
					default:
						if (l == 929)
						{
							return "대포에 사용합니다 ";
						}
						break;
=======
						case 1336:
							return "Decreases target's defense";
						case 1337:
						case 1344:
						case 1345:
						case 1346:
						case 1347:
						case 1348:
							break;
						case 1338:
							return "For use with bunny cannon";
						case 1339:
							return "'Extremely toxic'";
						case 1340:
							return "Melee attacks inflict Venom on enemies";
						case 1341:
							return "Inflicts target with Venom";
						case 1342:
							return "Inflicts target with Venom";
						case 1343:
							return "10% increased melee damage and speed";
						case 1349:
							return "Explodes into confetti on impact";
						case 1350:
							return "Causes confusion";
						case 1351:
							return "Explodes on impact";
						case 1352:
							return "Enemies killed will drop more money";
						case 1353:
							return "Melee attacks inflict enemies with cursed flames";
						case 1354:
							return "Melee attacks set enemies on fire";
						case 1355:
							return "Melee attacks make enemies drop more gold";
						case 1356:
							return "Melee attacks decrease enemies defense";
						case 1357:
							return "Melee attacks confuse enemies";
						case 1358:
							return "Melee attacks cause confetti to appear";
						case 1359:
							return "Melee attacks poison enemies";
						default:
							if (l == 1505)
							{
								return "8% increased movement speed";
							}
							break;
>>>>>>> origin/master
					}
				}
				else
				{
					switch (l)
					{
<<<<<<< HEAD
					case 936:
						return "근접공격의 피해량과 공격속도가 12% 만큼 증가합니다";
					case 937:
						break;
					case 938:
						return "생명력이  25% 이상일 때만 작동합니다";
					default:
						if (l == 950)
						{
							return "얼음 위에 떨어져도 부서지지 않습니다";
						}
						if (l == 953)
						{
							return "못박힌 신발과 함께 사용하면 효과가 상승합니다";
						}
						break;
=======
						case 1546:
							return "5% increased ranged critical strike chance";
						case 1547:
							return "5% increased ranged critical strike chance";
						case 1548:
							return "5% increased ranged critical strike chance";
						case 1549:
							return "20% chance to not consume ammo";
						case 1550:
							return "12% increased movement speed";
						case 1551:
						case 1552:
							break;
						case 1553:
							return "'It came from the edge of space'";
						default:
							if (l == 1595)
							{
								return "Restores mana when damaged";
							}
							if (l == 1613)
							{
								return "Grants immunity to most debuffs";
							}
							break;
>>>>>>> origin/master
					}
				}
			}
			else if (l <= 3015)
			{
				if (l <= 2340)
				{
					if (l <= 2189)
					{
						if (l <= 1845)
						{
<<<<<<< HEAD
						case 960:
							return "마법 피해량과 치명타 확률이 4% 만큼 증가합니다";
						case 961:
							return "마법 피해량과 치명타 확률이 4% 만큼 증가합니다";
						case 962:
							return "마법 피해량과 치명타 확률이 4% 만큼 증가합니다";
						default:
							switch (l)
							{
							case 975:
								return "등산용 발톱과 함께 사용하면 효과과 상승됩니다";
							case 977:
								return "방향키를 두번 누르세요";
=======
							switch (l)
							{
								case 1832:
									return "Increases minion damage by 11%";
								case 1833:
									return "Increases minion damage by 11%";
								case 1834:
									return "Increases minion damage by 11%";
								default:
									if (l == 1845)
									{
										return "Increases minion damage by 10%";
									}
									break;
>>>>>>> origin/master
							}
						}
						else
						{
<<<<<<< HEAD
						case 982:
							return "마나 회복력을 증가시킵니다";
						case 983:
							return "점프 높이가 증가합니다";
						case 984:
							return "일정 확률로 공격을 회피할수 있습니다";
						default:
							switch (l)
							{
							case 997:
								return "'사용법: 모래덩어리/진창/화석을 추출기에 설치하십시오'";
							case 1001:
								return "근접 공격 치명타 확률이 6% 만큼 증가합니다";
							case 1002:
								return "탄약을 20% 확률로 사용하지 않습니다";
							case 1003:
								return "마법공격 피해량이 16% 만큼 증가합니다";
							case 1004:
								return "치명타 확률이 7% 만큼 증가합니다";
							case 1005:
								return "이동속도가 5% 만큼 증가합니다";
=======
							switch (l)
							{
								case 1858:
									return "10% increased ranged damage and critical strike chance";
								case 1859:
									break;
								case 1860:
									return "Provides light under water";
								case 1861:
									return "Provides light under water and extra mobility on ice";
								case 1862:
									return "7% increased movement speed";
								case 1863:
									return "Increases jump height";
								case 1864:
									return "Increases the damage and knockback of your minions";
								case 1865:
									return "life regeneration, defense, pick speed, and minion knockback";
								case 1866:
									return "Hold DOWN and JUMP to hover";
								default:
									if (l == 2189)
									{
										return "5% increased magic damage and critical strike chance";
									}
									break;
>>>>>>> origin/master
							}
						}
					}
<<<<<<< HEAD
				}
				else if (l <= 1131)
				{
					if (l == 1123)
					{
						return "혼란을 일으킬 확률이 조금 있습니다";
					}
					if (l == 1131)
					{
						return "'위'키를 눌러 중력을 바꾸세요";
=======
					else if (l <= 2221)
					{
						switch (l)
						{
							case 2199:
								return "Enemies are more likely to target you";
							case 2200:
								return "6% increased movement and melee speed";
							case 2201:
								return "Enemies are more likely to target you";
							case 2202:
								return "Enemies are more likely to target you";
							default:
								switch (l)
								{
									case 2220:
										return "15% increased magic damage";
									case 2221:
										return "Restores mana when damaged";
								}
								break;
						}
>>>>>>> origin/master
					}
					else
					{
<<<<<<< HEAD
					case 1159:
						return "소환수 피해량이 10% 만큼 증가합니다";
					case 1160:
						return "소환수 피해량이 10% 만큼 증가합니다";
					case 1161:
						return "소환수 피해량이 10% 만큼 증가합니다";
					case 1162:
					case 1165:
					case 1166:
						break;
					case 1163:
						return "점프 높이가 증가합니다";
					case 1164:
						return "점프 높이가 증가합니다";
					case 1167:
						return "소환수의 넉백을 증가시킵니다";
					default:
						switch (l)
						{
						case 1205:
							return "근접공격 속도가 12% 만큼 증가합니다";
						case 1206:
							return "치명타 확률이 9% 만큼 증가합니다";
						case 1207:
							return "마나 최대치가 60 만큼 증가합니다";
						case 1208:
							return "치명타 확률이 2% 만큼 증가합니다";
						case 1209:
							return "치명타 확률이 1% 만큼 증가합니다";
						case 1210:
							return "이동속도와 근접공격 속도가 7% 만큼 증가합니다";
						case 1211:
							return "이동속도가 8% 만큼 증가합니다";
						case 1212:
							return "마나 최대치가 80 만큼 증가합니다";
						case 1213:
						case 1214:
							break;
						case 1215:
							return "이동속도가 8% 만큼 증가합니다";
						case 1216:
							return "원거리 피해량과 치명타 확률이 7% 증가합니다";
						case 1217:
							return "마나 최대량이 100 만큼 증가합니다";
						case 1218:
							return "치명타 확률이 3% 만큼 증가합니다";
						case 1219:
							return "이동속도가 6% 만큼 증가합니다";
						default:
							switch (l)
							{
							case 1249:
								return "피해를 받으면 벌들을 쏩니다";
							case 1250:
								return "점프 높이가 증가하고 낙하 피해가 무효화됩니다";
							case 1251:
								return "점프 높이가 증가하고 낙하 피해가 무효화됩니다";
							case 1252:
								return "점프 높이가 증가하고 낙하 피해가 무효화됩니다";
							case 1254:
								return "우클릭으로 축소하세요";
							}
							break;
=======
						if (l == 2270)
						{
							return "Highly inaccurate";
						}
						switch (l)
						{
							case 2277:
								return "10% increased melee and movement speed";
							case 2278:
								break;
							case 2279:
								return "Reduces mana usage by 10%";
							default:
								if (l == 2340)
								{
									return "Hammer intersections to change direction";
								}
								break;
>>>>>>> origin/master
						}
					}
				}
				else if (l <= 2586)
				{
					if (l <= 2372)
					{
<<<<<<< HEAD
					case 1282:
						return "마나 소모가 5% 만큼 감소합니다";
					case 1283:
						return "마나 소모가 7% 만큼 감소합니다";
					case 1284:
						return "마나 소모가 9% 만큼 감소합니다";
					case 1285:
						return "마나 소모가 11% 만큼 감소합니다";
					case 1286:
						return "마나 소모가 13% 만큼 감소합니다";
					case 1287:
						return "마나 소모가 15% 만큼 감소합니다";
					default:
						if (l == 1295)
						{
							return "'올라!!'";
=======
						switch (l)
						{
							case 2361:
								return "Increases your max number of minions";
							case 2362:
								return "Increases your max number of minions";
							default:
								switch (l)
								{
									case 2370:
										return "Increases minion damage by 6%";
									case 2371:
										return "Increases minion damage by 6%";
									case 2372:
										return "Increases minion damage by 6%";
								}
								break;
>>>>>>> origin/master
						}
					}
					else
					{
<<<<<<< HEAD
					case 1300:
						return "우클릭으로 축소하세요";
					case 1301:
						return "치명타 확률이 8% 만큼 증가합니다";
					default:
						switch (l)
						{
						case 1316:
							return "적들이 목표로 삼을 확률이 늘어납니다";
						case 1317:
							return "적들이 목표로 삼을 확률이 늘어납니다";
						case 1318:
							return "적들이 목표로 삼을 확률이 늘어납니다";
						case 1321:
							return "화살을 20% 확률로 소비하지 않습니다";
=======
						if (l == 2423)
						{
							return "Increases fall resistance";
						}
						if (l == 2586)
						{
							return "'Tossing may be difficult.'";
>>>>>>> origin/master
						}
					}
				}
				else if (l <= 2609)
				{
<<<<<<< HEAD
				case 1336:
					return "목표의 방어력을 떨어뜨립니다";
				case 1337:
				case 1344:
				case 1345:
				case 1346:
				case 1347:
				case 1348:
					break;
				case 1338:
					return "토끼 대포에 쓰입니다";
				case 1339:
					return "'매우 독함'";
				case 1340:
					return "근접 공격이 적을 맹독으로 중독시킵니다";
				case 1341:
					return "적을 맹독으로 중독시킵니다";
				case 1342:
					return "적을 맹독으로 중독시킵니다";
				case 1343:
					return "근접공격 속도와 이동속도가 10% 만큼 증가합니다";
				case 1349:
					return "충격에 터지며 꽃가루를 뿌립니다";
				case 1350:
					return "혼란을 일으킵니다";
				case 1351:
					return "충격에 터집니다";
				case 1352:
					return "적들이 죽으면 돈을 더 떨어뜨릴것입니다";
				case 1353:
					return "근접공격이 저주받은 불꽃을 일으킵니다";
				case 1354:
					return "근접공격이 적에 불을 붙입니다";
				case 1355:
					return "근접공격이 적의 돈을 더 떨어뜨립니다";
				case 1356:
					return "근접공격이 적의 방어력을 낮춥니다";
				case 1357:
					return "근접공격이 적을 혼란시킵니다";
				case 1358:
					return "근접공격이 꽃가루를 뿌립니다";
				case 1359:
					return "근접공격이 적을 중독시킵니다";
				default:
					if (l == 1505)
					{
						return "이동속도가 8% 증가합니다";
					}
					break;
				}
			}
			else
			{
				switch (l)
				{
				case 1546:
					return "원거리 피해량과 치명타 확률이 5% 만큼 증가합니다";
				case 1547:
					return "원거리 피해량과 치명타 확률이 5% 만큼 증가합니다";
				case 1548:
					return "원거리 피해량과 치명타 확률이 5% 만큼 증가합니다";
				case 1549:
					return "탄약을 20% 확률로 소모하지 않습니다";
				case 1550:
					return "이동속도가 12% 만큼 증가합니다";
				case 1551:
				case 1552:
					break;
				case 1553:
					return "'우주의 끝에서 왔습니다'";
				default:
					if (l == 1595)
					{
						return "피해를 입으면 마나가 회복됩니다";
=======
					if (l == 2590)
					{
						return "Lights nearby area on fire for a while";
					}
					if (l == 2609)
					{
						return "Allows quick travel in water";
>>>>>>> origin/master
					}
				}
				else
				{
					switch (l)
					{
<<<<<<< HEAD
						return "많은 상태이상에 면역이 생깁니다";
=======
						case 2757:
							return "7% increased ranged critical strike chance";
						case 2758:
							return "25% chance not to consume ammo";
						case 2759:
							return "10% increased movement speed";
						case 2760:
							return "7% increased magic damage and critical strike chance";
						case 2761:
							break;
						case 2762:
							return "10% increased movement speed";
						case 2763:
							return "Enemies are more likely to target you";
						case 2764:
							return "Enemies are more likely to target you";
						case 2765:
							return "Enemies are more likely to target you";
						default:
							switch (l)
							{
								case 2995:
									return "'In loving memory'";
								case 2996:
									break;
								case 2997:
									return "Click their head on the fullscreen map";
								default:
									if (l == 3015)
									{
										return "5% increased damage and critical strike chance";
									}
									break;
							}
							break;
>>>>>>> origin/master
					}
				}
			}
			else if (l <= 3241)
			{
				if (l <= 3097)
				{
					if (l <= 3061)
					{
						switch (l)
						{
<<<<<<< HEAD
						case 1832:
							return "소환수 피해량이 11% 만큼 증가합니다";
						case 1833:
							return "소환수 피해량이 11% 만큼 증가합니다";
						case 1834:
							return "소환수 피해량이 11% 만큼 증가합니다";
						default:
							if (l == 1845)
							{
								return "소환수 피해량이 10% 만큼 증가합니다";
							}
							break;
=======
							case 3034:
								return "Hitting enemies will sometimes drop extra coins";
							case 3035:
								return "Hitting enemies will sometimes drop extra coins";
							default:
								if (l == 3061)
								{
									return "Automatically paints placed objects";
								}
								break;
>>>>>>> origin/master
						}
					}
					else
					{
						if (l == 3085)
						{
<<<<<<< HEAD
						case 1858:
							return "원거리공격의 피해량과 치명타 확률이 10% 만큼 늘어납니다";
						case 1859:
							break;
						case 1860:
							return "수중에서 빛을 발합니다";
						case 1861:
							return "수중에서 빛을 발하고 얼음 위에서 기동성이 증가합니다";
						case 1862:
							return "이동속도가 7% 증가합니다";
						case 1863:
							return "점프 높이가 증가합니다";
						case 1864:
							return "소환수의 피해량과 넉백을 늘려줍니다";
						case 1865:
							return "생명 회복력, 방어력, 줍는 속도, 그리고 소환수 넉백까지";
						case 1866:
							return "아래키를 누르고 점프를 하면 허공을 날 수 있습니다";
						default:
							if (l == 2189)
							{
								return "마법공격 피해량과 치명타 확률이 5% 만큼 증가합니다 ";
							}
							break;
						}
					}
				}
				else if (l <= 2221)
				{
					switch (l)
					{
					case 2199:
						return "적들이 목표로 삼을 확률이 늘어납니다";
					case 2200:
						return "이동속도와 물리공격속도가 6% 만큼 증가합니다";
					case 2201:
						return "적들이 목표로 삼을 확률이 늘어납니다";
					case 2202:
						return "적들이 목표로 삼을 확률이 늘어납니다";
					default:
						switch (l)
						{
						case 2220:
							return "마법공격 피해량이 15% 만큼 증가합니다";
						case 2221:
							return "공격을 받으면 마나가 회복됩니다";
=======
							return "Requires a Golden Key";
						}
						if (l == 3097)
						{
							return "Double tap a direction";
>>>>>>> origin/master
						}
					}
				}
				else if (l <= 3116)
				{
<<<<<<< HEAD
					if (l == 2270)
					{
						return "정말 부정확해요";
					}
					switch (l)
					{
					case 2277:
						return "근접공격 속도와 이동속도가 10% 만큼 증가합니다";
					case 2278:
						break;
					case 2279:
						return "마나 소모량이 10% 만큼 감소합니다 ";
					default:
						if (l == 2340)
						{
							return "교차지점을 망치질하여 방향을 바꾸세요";
						}
						break;
=======
					if (l == 3110)
					{
						return "Minor increases to all stats";
>>>>>>> origin/master
					}
					switch (l)
					{
<<<<<<< HEAD
					case 2361:
						return "소환수의 최대수가 증가합니다";
					case 2362:
						return "소환수의 최대수가 증가합니다";
					default:
						switch (l)
						{
						case 2370:
							return "소환수 피해량이 6% 만큼 증가합니다";
						case 2371:
							return "소환수 피해량이 6% 만큼 증가합니다";
						case 2372:
							return "소환수 피해량이 6% 만큼 증가합니다";
						}
						break;
=======
						case 3115:
							return "Very bouncy";
						case 3116:
							return "Very bouncy";
>>>>>>> origin/master
					}
				}
				else
				{
					if (l == 3124)
					{
<<<<<<< HEAD
						return "낙하 피해의 저항을 높입니다";
=======
						return "Allows you to return home at will";
>>>>>>> origin/master
					}
					switch (l)
					{
<<<<<<< HEAD
						return "'던지는게 꽤 까다로울껄요?'";
					}
				}
			}
			else if (l <= 2609)
			{
				if (l == 2590)
				{
					return "어느정도 시간이 흐를동안 주변 지역에 불을 붙입니다 ";
				}
				if (l == 2609)
				{
					return "수중에서 빨리 탐험할 수 있게 합니다";
				}
			}
			else
=======
						case 3226:
							return "Become the wind, ride the lightning.";
						case 3227:
							return "Bejeweled and elegant for soaring through the thundering skies";
						case 3228:
							return "The Valkyrie Satellite Barrier Platform is totally safe. Most of the time.";
						default:
							if (l == 3241)
							{
								return "Allows the holder to double jump";
							}
							break;
					}
				}
			}
			else if (l <= 3383)
>>>>>>> origin/master
			{
				if (l <= 3252)
				{
<<<<<<< HEAD
				case 2757:
					return "원거리 피해량과 치명타 확률이 7% 증가합니다";
				case 2758:
					return "탄약을 25% 확률로 소모하지 않습니다";
				case 2759:
					return "이동속도가 10% 만큼 증가납니다";
				case 2760:
					return "마법공격의 피해량과 치명타 확률이 7% 만큼 증가납니다";
				case 2761:
					break;
				case 2762:
					return "이동속도가 10% 만큼 증가납니다";
				case 2763:
					return "적들이 목표로 삼을 확률이 늘어납니다";
				case 2764:
					return "적들이 목표로 삼을 확률이 늘어납니다";
				case 2765:
					return "적들이 목표로 삼을 확률이 늘어납니다";
				default:
					switch (l)
					{
					case 2995:
						return "'사랑하는 기억으로'";
					case 2996:
						break;
					case 2997:
						return "전체화면 지도에서 다른사람의 머리를 눌러보세요";
					default:
						if (l == 3015)
						{
							return "피해량과 치명타 확률이 5% 만큼 증가합니다";
						}
						break;
=======
					if (l == 3245)
					{
						return "33% chance to not consume bone";
>>>>>>> origin/master
					}
					switch (l)
					{
<<<<<<< HEAD
					case 3034:
						return "적을 공격하면 추가로 동전을 획득할 확률이 증가합니다";
					case 3035:
						return "적을 공격하면 추가로 동전을 획득할 확률이 증가합니다";
					default:
						if (l == 3061)
						{
							return "자동으로 설치된 물건들을 색칠합니다";
						}
						break;
=======
						case 3250:
						case 3251:
						case 3252:
							return "Increases jump height and negates fall damage";
>>>>>>> origin/master
					}
				}
				else
				{
<<<<<<< HEAD
					if (l == 3085)
					{
						return "금 열쇠가 필요합니다";
					}
					if (l == 3097)
					{
						return "방향키를 두번 누르세요";
					}
				}
			}
			else if (l <= 3116)
			{
				if (l == 3110)
				{
					return "모든 스탯이 소폭 상승합니다";
				}
				switch (l)
				{
				case 3115:
					return "매우 잘 튀어요";
				case 3116:
					return "매우 잘 튀어요";
				}
			}
			else
			{
				if (l == 3124)
				{
					return "원할때 집으로 보내줍니다";
				}
				switch (l)
				{
				case 3226:
					return "바람이 되어 번개를 타거라.";
				case 3227:
					return "보석으로 장식되어 천둥치는 번개 속에서 나아오기에 매우 우아하죠";
				case 3228:
					return "발키리위성방어막플랫폼은 매우 안전해요. 주로 말이에요.";
				default:
					if (l == 3241)
					{
						return "착용자는 더블점프를 사용할 수 있습니다";
=======
					if (l == 3368)
					{
						return "'I didn't get this off of a Schmoo'";
					}
					switch (l)
					{
						case 3381:
							return "Increases minion damage by 22%";
						case 3382:
							return "Increases minion damage by 22%";
						case 3383:
							return "Increases minion damage by 22%";
>>>>>>> origin/master
					}
				}
			}
			else if (l <= 3532)
			{
<<<<<<< HEAD
				if (l == 3245)
				{
					return "뼈가 33% 확률로 소모되지 않습니다";
				}
				switch (l)
				{
				case 3250:
				case 3251:
				case 3252:
					return "점프 높이가 증가하고 낙하 피해가 무효화됩니다";
=======
				switch (l)
				{
					case 3474:
						return "'Cultivate the most beautiful cellular infection'";
					case 3475:
						return "'The catastrophic mixture of pew pew and boom boom.'";
					default:
						switch (l)
						{
							case 3531:
								return "'Who needs a horde of minions when you have a giant dragon?'";
							case 3532:
								return "'Bacon? Bacon.'";
						}
						break;
>>>>>>> origin/master
				}
			}
			else
			{
<<<<<<< HEAD
				if (l == 3368)
				{
					return "'정체모를 물질로 만든거 아냐!'";
				}
				switch (l)
				{
				case 3381:
					return "소환수 피해량이 22%만큼 증가합니다";
				case 3382:
					return "소환수 피해량이 22%만큼 증가합니다";
				case 3383:
					return "소환수 피해량이 22%만큼 증가합니다";
				}
			}
		}
		else if (l <= 3532)
		{
			switch (l)
			{
			case 3474:
				return "'가장 아름다운 세포 감염을 구축하라'";
			case 3475:
				return "''피웅 피웅'과 '붐붐' 의 비극적인 혼합물'";
			default:
				switch (l)
				{
				case 3531:
					return "'드래곤이 있다면 소환수 무리가 무슨 소용이지?'";
				case 3532:
					return "'베이컨? 베이컨.'";
				}
				break;
			}
		}
		else
		{
			if (l == 3571)
			{
				return "'색좀 보세요, 장군님! 색이요!'";
			}
			switch (l)
			{
			case 3577:
				return "'난 네가 무슨생각 하는지 알아...'";
			case 3578:
			case 3579:
				break;
			case 3580:
				return "이 엑세서리가 뭘 하든간에 버그는 아니에요!";
			case 3581:
				return "이걸 보고 있다면 도망쳐야 할껄...";
			default:
				switch (l)
				{
				case 3589:
					return "무질서는 질서에서 왔고, 두려움은 용기에서 왔으며, 나약함은 강함에서 나왔노라";
				case 3590:
					return "지피지기면 백전백승";
				case 3591:
					return "정의의 바퀴는 천천히 돈다.";
				case 3592:
					return "네 전략을 밤처럼 어둡고 눈 앞이 안보이게 하되 움직일 땐 번개처럼 빨라야 한다.";
=======
				if (l == 3571)
				{
					return "'The colors, Duke, the colors!'";
				}
				switch (l)
				{
					case 3577:
						return "'I know what you're thinking....'";
					case 3578:
					case 3579:
						break;
					case 3580:
						return "Whatever this accessory does to you is not a bug!";
					case 3581:
						return "If you see this you should probably run away...";
					default:
						switch (l)
						{
							case 3589:
								return "Disorder came from order, fear came from courage, weakness came from strength";
							case 3590:
								return "Know thy self, know thy enemy. A thousand battles, a thousand victories…";
							case 3591:
								return "Wheels of justice grind slow but grind fine.";
							case 3592:
								return "Let your plans be dark and impenetrable as night, and when you move, fall like a thunderbolt.";
						}
						break;
>>>>>>> origin/master
				}
			}
		}

		public static string evilGood()
		{
			int tGood = (int)WorldGen.tGood;
			int tEvil = (int)WorldGen.tEvil;
			int tBlood = (int)WorldGen.tBlood;
			string text;
			if (tGood > 0 && tEvil > 0 && tBlood > 0)
			{
				text = string.Concat(new object[]
			{
				Main.worldName,
				" 은(는) ",
				tGood,
				"% 만큼 신성하구요, ",
				tEvil,
				"% 만큼 타락했고 ",
				tBlood,
				"% 만큼 피투성이로 물들었어요."
			});
			}
			else if (tGood > 0 && tEvil > 0)
			{
				text = string.Concat(new object[]
			{
				Main.worldName,
				" 은(는) ",
				tGood,
				"% 만큼 신성하구 ",
				tEvil,
				"% 만큼 타락했어요."
			});
			}
			else if (tGood > 0 && tBlood > 0)
			{
				text = string.Concat(new object[]
			{
				Main.worldName,
				" 은(는) ",
				tGood,
				"% 만큼 신성하구 ",
				tBlood,
				"% 만큼 피투성이에요."
			});
			}
			else if (tEvil > 0 && tBlood > 0)
			{
				text = string.Concat(new object[]
			{
				Main.worldName,
				" 은(는) ",
				tEvil,
				"% 만큼 타락했고 ",
				tBlood,
				"% 만큼 피투성이에요."
			});
			}
			else if (tEvil > 0)
			{
				text = string.Concat(new object[]
			{
				Main.worldName,
				" 은(는) ",
				tEvil,
				"% 만큼 타락했어요."
			});
			}
			else if (tBlood > 0)
			{
				text = string.Concat(new object[]
			{
				Main.worldName,
				" 은(는) ",
				tBlood,
				"% 만큼 피투성이에요."
			});
<<<<<<< HEAD
		}
		else
		{
			if (tGood <= 0)
			{
				return Main.worldName + " 은(는) 완벽하게 순수해요! 정말 엄청난 일을 해내셨군요!";
=======
>>>>>>> origin/master
			}
			else
			{
				if (tGood <= 0)
				{
					return Main.worldName + " is completely pure. You have done an amazing job!";
				}
				text = string.Concat(new object[]
			{
				Main.worldName,
				" 은(는) ",
				tGood,
				"% 만큼 신성으로 뒤덮여 있어요."
			});
			}
			if ((double)tGood * 1.2 >= (double)(tEvil + tBlood) && (double)tGood * 0.8 <= (double)(tEvil + tBlood))
			{
				text += " The world is in balance.";
			}
			else if (tGood >= tEvil + tBlood)
			{
				text += " We are living in a fairy tale.";
			}
			else if (tEvil + tBlood > tGood + 20)
			{
				text += " Things are grim indeed...";
			}
			else if (tEvil + tBlood > 10)
			{
				text += " You have a lot of work to do.";
			}
			else
			{
				text += " You are so close!";
			}
			return text;
		}
<<<<<<< HEAD
		if ((double)tGood * 1.2 >= (double)(tEvil + tBlood) && (double)tGood * 0.8 <= (double)(tEvil + tBlood))
		{
			text += " 이 세계는 균형잡혀 있어요.";
		}
		else if (tGood >= tEvil + tBlood)
		{
			text += "우린 지금 동화의 세계에서 살고 있어요.";
		}
		else if (tEvil + tBlood > tGood + 20)
		{
			text += " 많은게 음침해요...";
		}
		else if (tEvil + tBlood > 10)
		{
			text += " 당신 할일이 많군요.";
		}
		else
		{
			text += " 조금만 더 힘내요!";
=======

		public static string DyeTraderQuestChat(bool gotDye = false)
		{
			string str = NPC.firstNPCName(207);
			string result = "";
			if (gotDye)
			{
				switch (Main.rand.Next(3))
				{
					case 0:
						result = "Brilliant, my dear! You have brought me an exquisite sample of the world's beautiful colors and aroma. In exchange, you may take this special bottle of dye.";
						break;
					case 1:
						result = "You bring me a beautiful, rare flower... yes, yes? Take this bottle of special dye for your troubles, friend!";
						break;
					case 2:
						result = "Fantabulous, wonderful friend! With this delicate specimen, I may mix the most amazing dyes " + Main.worldName + " has ever seen! You may take this one right away!";
						break;
				}
			}
			else
			{
				switch (Main.rand.Next(3))
				{
					case 0:
						result = "Oh no no, this will not do.  For these money is no good, you must return to me with a rare specimen of a plant!";
						break;
					case 1:
						result = "You think you can pull a fast one on " + str + ", I don't think so! I only take the rarest of flowers for these special bottles!";
						break;
					case 2:
						result = "These dye bottles? Sorry dear friend, these don't take coin. I only take the most precious and rare of flora in exchange for one of this!";
						break;
				}
			}
			return result;
>>>>>>> origin/master
		}
	}

	public static class krEnd
	{
		public static string End(string target, int flag)
		{
<<<<<<< HEAD
			switch (Main.rand.Next(3))
			{
			case 0:
				result = "멋지군, 친구! 이 세계의 아로마와 아름다운 색들의 정교한 표본을 가져와서 고마워. 그 답례로 이 특별한 염색약을 줄게.";
				break;
			case 1:
				result = "아름답고, 희귀한 꽃들을 더 가져올꺼지... 그치, 그치? 그래서 말인데 이 특별한 염색약을 가져가 , 친구!";
				break;
			case 2:
				result = "이 믿을 수 없을 만큼 훌룡하고 멋진 친구야! 이 표본이라면, 이 세상," + Main.worldName + "에서 본적도 없는 염색약을 만들 수 있겠어! 예전에 만들어 둿던걸 줄게!";
				break;
			}
=======
			string str = "";

			return str;
>>>>>>> origin/master
		}

		public static string End(string target, string flag)
		{
<<<<<<< HEAD
			switch (Main.rand.Next(3))
			{
			case 0:
				result = "아니아니, 그건 안돼. 이 염색약들은 돈으로 가치를 매길 수 없어, 희귀한 식물 표본이라면 모를까!";
				break;
			case 1:
				result = "넌 네가 " + str + " 을(를)속일 수 있을거 같아? 물론 못하지! 이 특별한 병들은 희귀한 식물이랑만 바꾼다고!";
				break;
			case 2:
				result = "이 염색약들? 미안해 친구, 돈은 안받아. 귀중하고 희귀한 식물들만 받는다고!";
				break;
			}
=======
			string str = "";

			return str;
>>>>>>> origin/master
		}
	}
}
