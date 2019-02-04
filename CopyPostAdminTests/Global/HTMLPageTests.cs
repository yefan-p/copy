using Microsoft.VisualStudio.TestTools.UnitTesting;
using CopyPost.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using CopyPost;

namespace CopyPost.Global.Tests
{
    [TestClass()]
    public class HTMLPageTests
    {
        [TestMethod()]
        public void HTMLPageTest_RutorIs()
        {
            #region stringHTML
            string resultRutorIs = @"<html>
<head>
	<meta http-equiv=""content-type"" content=""text/html; charset=utf-8"" />
	<link href=""/s/css.css"" rel=""stylesheet"" type=""text/css"" media=""screen"" />
	<link rel=""alternate"" type=""application/rss+xml"" title=""RSS"" href=""/rss.php?category"" />
	<link rel=""shortcut icon"" href=""/s/favicon.ico"" />
	<title>зеркало rutor.info :: Софт</title>
	<script type=""text/javascript"" src=""http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js""></script>
	<script type=""text/javascript"" src=""/s/jquery.cookie-min.js""></script>
	<script type=""text/javascript"" src=""/s/t/functions.js""></script>
	<script type=""text/javascript"" src=""/s/ui/ui.core.js""></script>
		<script type=""text/javascript"" src=""/s/ui/ui.datepicker.js""></script>
		<script type=""text/javascript"" src=""/s/ui/i18n/ui.datepicker-ru.js""></script>
		<link href=""/s/ui/themes/ui-lightness/ui.css"" rel=""stylesheet"" type=""text/css"" media=""screen"" />
</head>
<body>

<div id=""all"">

<div id=""up"">

<div id=""logo"">
	<a href=""/""><img src=""/s/logo.jpg"" alt=""rutor.info logo"" /></a>
</div>

<table id=""news_table"">
  <tr><td colspan=""2""><strong>Новости трекера</strong></td></tr><tr><td class=""news_date"">30-Дек</td>
  	<td class=""news_title""><a href=""http://rutor.info/torrent/472"" target=""_blank""  id=""news88"" onclick=""$.cookie('news', '88', {expires: 365});"">У RUTOR.ORG - Новый Адрес: RUTOR.INFO</a></td></tr><tr><td class=""news_date"">29-Ноя</td>
  	<td class=""news_title""><a href=""/torrent/178905"" target=""_blank""  id=""news86"">Вечная блокировка в России</a></td></tr><tr><td class=""news_date"">09-Окт</td>
  	<td class=""news_title""><a href=""/torrent/145012"" target=""_blank""  id=""news59"">Путеводитель по RUTOR.org: Правила, Руководства, Секреты</a></td></tr></table>
  <script type=""text/javascript"">
  $(document).ready(function(){if($.cookie(""news"")<88){$(""#news88"").css({""color"":""orange"",""font-weight"":""bold""});}});
  </script>

</div>

<div id=""menu"">
<a href=""/"" class=""menu_b"" style=""margin-left:10px;""><div>Главная</div></a>
<a href=""/top"" class=""menu_b""><div>Топ</div></a>
<a href=""/categories"" class=""menu_b""><div>Категории</div></a>
<a href=""/browse/"" class=""menu_b""><div>Всё</div></a>
<a href=""/search/"" class=""menu_b""><div>Поиск</div></a>
<a href=""/latest_comments"" class=""menu_b""><div>Комменты</div></a>
<a href=""/upload.php"" class=""menu_b""><div>Залить</div></a>
<a href=""/jabber.php"" class=""menu_b""><div>Чат</div></a>

<div id=""menu_right_side""></div>

<script type=""text/javascript"">
$(document).ready(function()
{
	var menu_right;
	if ($.cookie('userid') > 0)
	{
		menu_right = '<a href=""/users.php?logout"" class=""logout"" border=""0""><img src=""/s/i/viti.gif"" alt=""logout"" /></a><span class=""logout""><a href=""/profile.php"" class=""logout""  border=""0""><img src=""/s/i/profil.gif"" alt=""profile"" /></a>';
	}
	else
	{
		menu_right = '<a href=""/users.php"" class=""logout"" border=""0""><img src=""/s/i/zaiti.gif"" alt=""login"" /></a>';
	}
	$(""#menu_right_side"").html(menu_right);
});
</script>

</div>
<h1>Софт</h1>
</div>
<div id=""ws"">
<div id=""content"">

<center>
<div id=""b_tz_208"" class=""b_tz_on_top"" onmouseup=""window.event.cancelBubble=true""></div>
</center>



<div id=""msg1""></div>
<script type=""text/javascript"">
$(document).ready(function()
{
	if ($.cookie('msg') != null)
	{
		if ($.cookie('msg').length > 0)
		{
			var msg2 = '<div id=""warning"">' + $.cookie('msg').replace(/[""+""]/g, ' ') + '</div>';
			$(""#msg1"").html(msg2);
			$.cookie('msg', '', { expires: -1 });
		}
	}
});
</script>
	<!--<script type=""text/javascript"" src=""/c/tags.js""></script>-->
	<script type=""text/javascript"">
	var search_page = 0;
	var search_category = 9;
	var search_sort = 0;
	var user = 0;
	var sort_ascdesc = 0;

	if (search_sort % 2 != 0)
	{
		search_sort -= 1;
		sort_ascdesc = 1;
	}
		$(document).ready(function()
	{
		$('#category_id').attr(""value"", search_category);
		$('#sort_id').attr(""value"", search_sort);
		if (sort_ascdesc == 0)
			$('input[name=s_ad]')[1].checked = true;
		else
			$('input[name=s_ad]')[0].checked = true;
	});

	function search_submit()
	{
		var sort_id = $('#sort_id').val();
		sort_id = parseInt(sort_id)+parseInt($('input[name=s_ad]:checked').val());
		if ($('#datepicker1').val() != """" || $('#datepicker2').val() != """")
		{
			sort_id = sort_id + ';' + $('#datepicker1').val() + ';' + $('#datepicker2').val();
		}
		document.location.href = '/browse/' + search_page + '/' + $('#category_id').val() + '/' + user + '/' + sort_id;
	}
	</script><fieldset><legend>Просмотр раздач</legend>
	<form onsubmit=""search_submit(); return false;"">
	<table>
	<tr>
	<td>Категория</td>
	<td>
	<!--<select name=""category"" id=""category_id"" onchange=""change_tags(0);"">-->
	<select name=""category"" id=""category_id"">
		<option value=""0"">Любая категория</option><option value=""1"">Зарубежные фильмы</option><option value=""5"">Наши фильмы</option><option value=""12"">Научно-популярные фильмы</option><option value=""4"">Зарубежные сериалы</option><option value=""16"">Наши сериалы</option><option value=""6"">Телевизор</option><option value=""7"">Мультипликация</option><option value=""10"">Аниме</option><option value=""2"">Музыка</option><option value=""8"">Игры</option><option value=""9"">Софт</option><option value=""13"">Спорт и Здоровье</option><option value=""15"">Юмор</option><option value=""14"">Хозяйство и Быт</option><option value=""11"">Книги</option><option value=""3"">Другое</option><option value=""17"">Иностранные релизы</option></select>
	</td>
	</tr>
	<tr>
	<td>Упорядочить по</td>
	<td>
	<select id=""sort_id"">
		<option value=""0"">дате добавления</option>
		<option value=""2"">раздающим</option>
		<option value=""4"">качающим</option>
		<option value=""6"">названию</option>
		<option value=""8"">размеру</option>
	</select>
	по
	<label><input type=""radio"" name=""s_ad"" value=""1""  />возрастанию</label>
	<label><input type=""radio"" name=""s_ad"" value=""0""  checked=""checked""  />убыванию</label>
	</td>
	</tr>

	<tr>
		<td>Отобрать по дате</td>
		<td>с <input type=""text"" id=""datepicker1"" value=""""> до <input type=""text"" id=""datepicker2"" value=""""></td>
	</tr>
	<script type=""text/javascript"">
	$(function() {
		$(""#datepicker1"").datepicker({
			changeMonth: true,
			changeYear: true
		});
	});
	$(function() {
		$(""#datepicker2"").datepicker({
			changeMonth: true,
			changeYear: true
		});
	});
	</script>

	<tr>
	<td>
	<input type=""submit"" value=""Поехали"" onclick=""search_submit(); return false;"" />
	</td>
	</tr>

	</table>
	</form>
	</fieldset><p align=""center""><b>&lt;&lt;&nbsp;Предв.</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href=""/browse/1/9/0/0""><b>След.&nbsp;&gt;&gt;</b></a><br /><b>1&nbsp;-&nbsp;100</b> | <a href=""/browse/1/9/0/0""><b>101&nbsp;-&nbsp;200</b></a> | <a href=""/browse/2/9/0/0""><b>201&nbsp;-&nbsp;300</b></a> | ... | <a href=""/browse/51/9/0/0""><b>5101&nbsp;-&nbsp;5200</b></a> | <a href=""/browse/52/9/0/0""><b>5201&nbsp;-&nbsp;5300</b></a> | <a href=""/browse/53/9/0/0""><b>5301&nbsp;-&nbsp;5343</b></a></p>
<div id=""index""><table width=""100%""><tr class=""backgr""><td width=""10px"">Добавлен</td><td colspan=""2"">Название</td><td width=""1px"">Размер</td><td width=""1px"">Пиры</td></tr><tr class=""gai""><td>04&nbsp;Фев&nbsp;19</td><td colspan = ""2""><a class=""downgif"" href=""/download/659448""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:ff03b42e82b52ab74efd11dfad2a1ebbed05eee7&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/659448/mediahuman-youtube-downloader-3.9.9.12-2019-pc-repack-portable-by-tryroom"">MediaHuman YouTube Downloader 3.9.9.12 (2019) PC | RePack &amp; Portable by TryRooM </a></td> 
<td align=""right"">27.35&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;7</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;1</span></td></tr><tr class=""tum""><td>04&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/559516""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:938754f16c0d395e63eff08a1d7716e5b3272e93&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/559516/smplayer-19.1.0-2019-pc-portable"">SMPlayer 19.1.0 (2019) PC | + Portable </a></td> <td align=""right"">6<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">340.54&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;6</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;1</span></td></tr><tr class=""gai""><td>04&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/669609""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:4e3f2091fc039bd4134f50ad7f9a0da49af4e21b&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/669609/abbyy-finereader-14.0.107.212-enterprise-2018-pc-repack-portable-by-tryroom"">ABBYY FineReader 14.0.107.212 Enterprise (2018) PC | RePack &amp; Portable by TryRooM </a></td> <td align=""right"">1<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">492.29&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;22</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;2</span></td></tr><tr class=""tum""><td>04&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/308020""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:1273f207fa34f9bc398855109407e8e7b593dfa7&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/308020/skype-8.38.0.138-2019-rs-repack-portable-by-kpojiuk"">Skype 8.38.0.138 (2019) РС | RePack &amp; Portable by KpoJIuK </a></td> <td align=""right"">68<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">59.19&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;13</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;2</span></td></tr><tr class=""gai""><td>04&nbsp;Фев&nbsp;19</td><td colspan = ""2""><a class=""downgif"" href=""/download/663760""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:a66996a04e697c5479952389c0bcbdd0354a189c&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/663760/apowerrec-1.3.4.4-2019-pc-repack-portable-by-tryroom"">ApowerREC 1.3.4.4 (2019) PC | RePack &amp; Portable by TryRooM </a></td> 
<td align=""right"">53.77&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;4</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>04&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/425175""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:1cfe88282b6b630cfb996c7a43b97181658d2312&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/425175/ummy-video-downloader-1.10.3.1-2019-pc-repack-portable-by-tryroom"">Ummy Video Downloader 1.10.3.1 (2019) PC | RePack &amp; Portable by TryRooM </a></td> <td align=""right"">28<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">28.29&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;18</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;1</span></td></tr><tr class=""gai""><td>04&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/417537""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:564e978e1c27dcac850b6c48af66426def9b9b66&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/417537/progdvb-7.26.08-professional-edition-2017-pc"">ProgDVB 7.26.08 Professional Edition (2017) PC </a></td> <td align=""right"">16<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">28.76&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;35</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;6</span></td></tr><tr class=""tum""><td>04&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/585427""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:3d3a51e3ce3425ef9d53aeaf09d1d57f7b89dfa6&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/585427/acdsee-photo-studio-ultimate-2019-12.1-build-1656-x64-2018-pc-repack-by-kpojiuk"">ACDSee Photo Studio Ultimate  2019 12.1 Build 1656 [x64] (2018) PC | RePack by KpoJIuK </a></td> <td align=""right"">13<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">134.84&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;27</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;2</span></td></tr><tr class=""gai""><td>04&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/679543""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:02f0d782f2bf2431bb0039d2d258aa6a835b1b67&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/679543/avira-antivirus-pro-2019-15.0.43.24-2019-rs-repack-by-envyme"">Avira Antivirus Pro 2019 15.0.43.24 (2019) РС | RePack by EnVyMe </a></td> <td align=""right"">3<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">102.45&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;22</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;2</span></td></tr><tr class=""tum""><td>03&nbsp;Фев&nbsp;19</td><td colspan = ""2""><a class=""downgif"" href=""/download/679446""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:791086fbe2595c7f84702c1741cba6aa3051e6cc&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/679446/uchjot-bso-blanki-strogoj-otchjotnosti-1.7.8-2019-pc"">Учёт БСО [Бланки строгой отчётности] 1.7.8 (2019) PC </a></td> 
<td align=""right"">4.00&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;10</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""gai""><td>03&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/679449""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:e7aabe337d7b11ac5a2d066da5670f414fb11321&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/679449/kerish-doctor-2019-4.70-dc-31.01.2019-2019-pc"">Kerish Doctor 2019 4.70 [DC 31.01.2019] (2019) PC </a></td> <td align=""right"">2<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">38.98&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;13</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;2</span></td></tr><tr class=""tum""><td>03&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/538257""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:1221b3966f790f078bbd153dac3b9e90ba763b4f&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/538257/aact-3.9.9-2019-pc-portable"">AAct 3.9.9 (2019) PC | Portable </a></td> <td align=""right"">27<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">3.32&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;49</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;5</span></td></tr><tr class=""gai""><td>03&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/679415""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:e071516963cd07a28d6bcb2dcc820524b3b52086&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/679415/winhex-19.7-x86-2018-pc"">WinHex 19.7 [x86] (2018) PC </a></td> <td align=""right"">2<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">5.18&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;20</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>03&nbsp;Фев&nbsp;19</td><td colspan = ""2""><a class=""downgif"" href=""/download/679378""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:7251eb88b2b3919bdde5f4abf0e0d503f35e2461&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/679378/acdsee-photo-studio-ultimate-2019-12.1-build-1656-x64-2019-pc-repack-by-d!akov"">ACDSee Photo Studio Ultimate  2019 12.1 Build 1656 [x64] (2019) PC | RePack by D!akov </a></td> 
<td align=""right"">184.37&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;52</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;1</span></td></tr><tr class=""gai""><td>03&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/376522""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:fbd7d7c239072078f7eebeaab9bd28eee4b0037c&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/376522/waterfox-56.2.7.1-final-x64-2019-pc-portable"">Waterfox 56.2.7.1 Final [x64] (2019) PC | + Portable </a></td> <td align=""right"">42<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">146.10&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;13</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;3</span></td></tr><tr class=""tum""><td>03&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/577723""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:42ec628dc853f46cbf0c435a586d58fe19dfa8a4&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/577723/wondershare-filmora-9.0.7.4-x64-effect-pack-03.02.2019-2019-pc-repack-by-elchupacabra"">Wondershare Filmora 9.0.7.4 [x64] + Effect Pack [03.02.2019] (2019) PC | RePack by elchupacabra </a></td> <td align=""right"">9<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">5.71&nbsp;GB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;15</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;6</span></td></tr><tr class=""gai""><td>02&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/367321""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:8a1ac4dc9b75c05be1efc6087368accbf0445eda&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/367321/hitmanpro-3.8.0-build-295-2018-pc-repack-by-dickmaster"">HitmanPro 3.8.0 Build 295 (2018) PC | RePack by Dickmaster </a></td> <td align=""right"">44<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">21.17&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;38</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;3</span></td></tr><tr class=""tum""><td>02&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/444784""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:a39bc1e1666b46c5b216e0933b12791695a24324&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/444784/gilisoft-video-converter-discovery-edition-10.6.0-dc-25.01.2019-2019-pc-repack-portable-by-elchupacabra"">GiliSoft Video Converter Discovery Edition 10.6.0 [DC 25.01.2019] (2019) PC | RePack &amp; Portable by elchupacabra </a></td> <td align=""right"">2<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">36.18&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;10</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;1</span></td></tr><tr class=""gai""><td>02&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/329587""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:70d09e1e2a23d760a1cb597b05c09631c61d7cab&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/329587/movavi-video-suite-18.1.0-2018-pc-repack-portable-by-elchupacabra"">Movavi Video Suite 18.1.0 (2018) PC | RePack &amp; Portable by elchupacabra </a></td> <td align=""right"">32<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">172.02&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;33</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>02&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/658050""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:2f7d81c61bdda19e4ce6746fa7ccd29ab6e7c9e5&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/658050/privazer-3.0.63-donors-version-2019-rs-repack-portable-by-elchupacabra"">PrivaZer 3.0.63 [Donors version] (2019) РС | RePack &amp; Portable by elchupacabra </a></td> <td align=""right"">1<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">6.60&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;10</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;1</span></td></tr><tr class=""gai""><td>02&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/305868""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:aa10111401333b3edc4ce6dc2d52c01fe36ab1a7&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/305868/geogebra-6.0.523-stable-2019-rs"">GeoGebra 6.0.523 Stable (2019) РС </a></td> <td align=""right"">8<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">61.50&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;8</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>02&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/531866""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:b32ebe3e52c434da05b501089a66642456cbe424&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/531866/privazer-3.0.63-donors-version-2019-pc-portable"">PrivaZer 3.0.63 [Donors version] (2019) PC | + Portable </a></td> <td align=""right"">31<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">7.90&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;12</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""gai""><td>02&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/536344""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:227aa8bd224635fba3339eeadcd66c2fd22e7cce&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/536344/free-download-manager-5.1.38-build-7312_3.9.7-build-1627_3.9.7-build-1638-lite-2018-2019-pc"">Free Download Manager 5.1.38 Build 7312 / 3.9.7 Build 1627 / 3.9.7 Build 1638  Lite (2018-2019) PC </a></td> <td align=""right"">1<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">111.98&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;6</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>02&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/666432""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:3484064f527d2204bf3217a5bb5bae545cfb909c&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/666432/process-lasso-pro-9.0.0.574-2019-pc-repack-portable-by-d!akov"">Process Lasso Pro 9.0.0.574 (2019) PC | RePack &amp; Portable by D!akov </a></td> <td align=""right"">1<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">4.15&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;15</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;1</span></td></tr><tr class=""gai""><td>02&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/587897""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:dd7564b3a2ea0037ff8d60c256c39cec8b85c092&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/587897/coolutils-total-audio-converter-5.3.0.194-2019-pc"">CoolUtils Total Audio Converter 5.3.0.194 (2019) PC </a></td> <td align=""right"">2<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">41.00&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;7</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>01&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/671254""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:cce0e081d84fb68e66b230b839e5bc6892b2a0bf&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/671254/display-driver-uninstaller-18.0.0.8-2019-pc"">Display Driver Uninstaller 18.0.0.8 (2019) PC </a></td> <td align=""right"">1<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">1.26&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;18</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""gai""><td>01&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/381717""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:f34fe75e089fa2d66b3f7a6537d8e8438d758d9d&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/381717/system-software-for-windows-v.3.2.7-2019-pc"">System software for Windows v.3.2.7 (2019) PC </a></td> <td align=""right"">98<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">2.72&nbsp;GB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;49</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;4</span></td></tr><tr class=""tum""><td>01&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/508306""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:230d73e5ef9b8555867163fa6cf165104bf002c8&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/508306/kms-tools-01.02.2019-2019-pc-portable-by-ratiborus"">KMS Tools [01.02.2019] (2019) PC | Portable by Ratiborus </a></td> <td align=""right"">61<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">43.65&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;104</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;1</span></td></tr><tr class=""gai""><td>01&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/410132""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:92945273fe6b65b2aaa380cf200231d81d221f51&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/410132/kmsauto-lite-1.5.4-2019-pc-portable"">KMSAuto Lite 1.5.4 (2019) PC | Portable </a></td> <td align=""right"">40<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">9.90&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;59</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;2</span></td></tr><tr class=""tum""><td>01&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/621712""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:864868ef20004321751deddc021fc109d66cf945&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/621712/reg-organizer-8.25-final-dc-30.01.2019-2019-pc-repack-portable-by-kpojluk_elchupacabra"">Reg Organizer 8.25 Final [DC 30.01.2019] (2019) PC | RePack &amp; Portable by KpoJluk / elchupacabra </a></td> <td align=""right"">7<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">24.94&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;18</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;4</span></td></tr><tr class=""gai""><td>01&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/596412""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:1153fbffbff793ea97e9016c64154aea7c36db03&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/596412/skype-7.36.0.150_7.41.32.101_8.38.0.138-final-2019-rs-repack-portable-by-elchupacabra"">Skype 7.36.0.150 / 7.41.32.101 / 8.38.0.138 Final (2019) РС | RePack &amp; Portable by elchupacabra </a></td> <td align=""right"">27<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">165.63&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;44</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;5</span></td></tr><tr class=""tum""><td>01&nbsp;Фев&nbsp;19</td><td colspan = ""2""><a class=""downgif"" href=""/download/662029""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:2ef525d51c211c93a811dccdcc58e90041873f53&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/662029/directory-lister-2.35-2019-rs-repack-portable-by-elchupacabra"">Directory Lister 2.35 (2019) РС | RePack &amp; Portable by elchupacabra </a></td> 
<td align=""right"">12.43&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;7</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""gai""><td>01&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/653907""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:09b02eb294c91013dc1eb3180d655c972b1a3871&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/653907/master-pdf-editor-5.3.02-2019-pc-repack-portable-by-elchupacabra"">Master PDF Editor 5.3.02 (2019) PC | RePack &amp; Portable by elchupacabra </a></td> <td align=""right"">1<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">40.37&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;13</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>01&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/279136""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:a30b2fbd7513c1026bd653abb5a251bbc14bffa5&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/279136/calibre-3.39.0-2019-pc-portable"">Calibre 3.39.0 (2019) PC | + Portable </a></td> <td align=""right"">29<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">181.78&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;7</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;1</span></td></tr><tr class=""gai""><td>01&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/618462""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:66178931414b9e1febaff7e24905e998b042c465&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/618462/auslogics-registry-cleaner-7.0.22.0-2018-pc-repack-portable-by-elchupasabra"">Auslogics Registry Cleaner 7.0.22.0 (2018) PC | RePack &amp; Portable by elchupaсabra </a></td> <td align=""right"">2<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">10.76&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;5</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>01&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/354394""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:8913570895f302946bac2161815e190602b76321&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/354394/auslogics-disk-defrag-free-8.0.22.0-2019-rs-portable"">Auslogics Disk Defrag Free 8.0.22.0 (2019) РС | + Portable </a></td> <td align=""right"">16<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">19.43&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;2</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""gai""><td>01&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/664557""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:2cc25a60d2554e2bbd4d221a48ddf1d3dfb02bb6&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/664557/auslogics-windows-slimmer-1.0.22.0-2018-pc"">Auslogics Windows Slimmer 1.0.22.0 (2018) PC </a></td> <td align=""right"">4<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">11.44&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;9</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>01&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/678955""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:64bdeb9ce245d85354f743c6b684585595424b79&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/678955/beloff-dp-2019.1-2019-rs-iso"">BELOFF [dp] 2019.1 (2019) РС | ISO </a></td> <td align=""right"">1<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">6.97&nbsp;GB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;45</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;13</span></td></tr><tr class=""gai""><td>01&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/506943""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:edf6c75883a5e44782aefbade02e52efa1ace7c6&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/506943/mozilla-thunderbird-60.5.0-2019-rs"">Mozilla Thunderbird 60.5.0 (2019) РС </a></td> <td align=""right"">4<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">65.16&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;4</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;1</span></td></tr><tr class=""tum""><td>01&nbsp;Фев&nbsp;19</td><td ><a class=""downgif"" href=""/download/641717""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:20c91c28ea6a8f2e4ab015c02f1f3fdd7912200d&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/641717/xyplorer-19.60.0000-2019-rs-repack-portable-by-tryroom"">XYplorer 19.60.0000  (2019) РС | RePack &amp; Portable by TryRooM </a></td> <td align=""right"">7<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">4.47&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;8</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""gai""><td>31&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/654520""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:d718efd05e52c51e73e770661f31a4be086404fc&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/654520/malwarebytes-premium-3.6.1.2711-dc-11.01.2019-2019-rs-repack-by-elchupacabra"">Malwarebytes Premium 3.6.1.2711 [DC 11.01.2019] (2019) РС | RePack by elchupacabra </a></td> <td align=""right"">4<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">80.06&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;11</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>31&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/678809""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:e6137069e419e02ffb3c1e1bb82ba095c2733586&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/678809/malwarebytes-anti-malware-2.2.1.1043-_3.6.1.2711-dc-11.01-2019-pc-repack-portable-by-elchupacabra"">Malwarebytes Anti-Malware 2.2.1.1043  / 3.6.1.2711 [DC 11.01] (2019) PC | RePack &amp; Portable by elchupacabra </a></td> <td align=""right"">1<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">132.74&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;23</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""gai""><td>31&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/465923""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:c316d4e12946735bdbf19ddea4d14596e31a84e4&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/465923/cent-browser-3.8.5.69-2010-pc-portable"">Cent Browser 3.8.5.69 (2010) PC | + Portable </a></td> <td align=""right"">38<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">286.92&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;11</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;4</span></td></tr><tr class=""tum""><td>31&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/665700""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:ada8529238e3682a80888690be72e6640ee57341&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/665700/essentialpim-pro-business-edition-8.14-2019-pc"">EssentialPIM Pro Business Edition 8.14 (2019) PC </a></td> <td align=""right"">1<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">43.12&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;2</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""gai""><td>31&nbsp;Янв&nbsp;19</td><td colspan = ""2""><a class=""downgif"" href=""/download/661638""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:dccc7a31d3eb5048a7a17de2584c6a31317d3489&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/661638/essentialpim-pro-business-edition-8.14-2019-rs-repack-portable-by-kpojiuk"">EssentialPIM Pro Business Edition 8.14 (2019) РС | RePack &amp; portable by KpoJIuK </a></td> 
<td align=""right"">31.87&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;9</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>31&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/678098""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:79d3c3742d6e5ee41011cc1d216e3db64df942c3&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/678098/wondershare-filmora-9.0.7.4-x64-2019-pc"">Wondershare Filmora 9.0.7.4 [x64] (2019) PC </a></td> <td align=""right"">4<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">290.33&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;17</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""gai""><td>31&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/379043""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:cc0500f7a4bf983430b69419851c7b3cef37730f&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/379043/malwarebytes-adwcleaner-7.2.7.0-2018-pc"">Malwarebytes AdwCleaner 7.2.7.0 (2018) PC </a></td> <td align=""right"">120<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">6.98&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;35</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>31&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/395891""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:7efbc1a4b13521fcef0d1f42f66b19cf49ba3a25&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/395891/tails-3.12-anonimnyj-dostup-v-seti-amd64-2019-pc"">Tails 3.12 [анонимный доступ в сети] [amd64] (2019) PC </a></td> <td align=""right"">32<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">1.16&nbsp;GB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;5</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;1</span></td></tr><tr class=""gai""><td>31&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/630797""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:d140a60f1a91001eeb55985f3b7e974ae0f83d64&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/630797/mozilla-firefox-esr-60.5.0-2019-pc"">Mozilla Firefox ESR 60.5.0 (2019) PC </a></td> <td align=""right"">5<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">72.62&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;6</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;2</span></td></tr><tr class=""tum""><td>31&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/301470""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:c1bafca365da1bd71e5f48325076950b24ec2167&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/301470/opera-58.0.3135.53-stable-2019-rs"">Opera 58.0.3135.53 Stable (2019) РС </a></td> <td align=""right"">352<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">102.15&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;13</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;2</span></td></tr><tr class=""gai""><td>30&nbsp;Янв&nbsp;19</td><td colspan = ""2""><a class=""downgif"" href=""/download/678667""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:395909f0a5d5913cb5248d44fd4774e55902a071&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/678667/domashnjaja-fotostudija-14.0-2019-pc-repack-by-kaktustv"">Домашняя Фотостудия 14.0 (2019) PC | RePack by KaktusTV </a></td> 
<td align=""right"">101.02&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;15</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>30&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/566069""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:557e249ec37c15b56f1e273fea4a86c8b0a5ce8a&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/566069/oo-shutup10-1.6.1401-2019-pc-portable"">O&amp;O ShutUp10 1.6.1401 (2019) PC | Portable </a></td> <td align=""right"">3<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">885.78&nbsp;kB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;14</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""gai""><td>30&nbsp;Янв&nbsp;19</td><td colspan = ""2""><a class=""downgif"" href=""/download/651776""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:9fe99399735fa13875b269e0c4e4c9b4ffe62533&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/651776/essentialpim-pro-business-edition-8.14-2019-pc-repack-portable-by-elchupacabra"">EssentialPIM Pro Business Edition 8.14 (2019) PC | RePack &amp; Portable by elchupacabra </a></td> 
<td align=""right"">25.74&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;10</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>30&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/278605""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:73ed3a90ddecbc1a388165c89e18ac6e769bfd14&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/278605/auslogics-file-recovery-8.0.22.0-final-2019-pc-repack-portable-by-elchupacabra"">Auslogics File Recovery 8.0.22.0 Final (2019) PC | RePack &amp; Portable by elchupacabra </a></td> <td align=""right"">6<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">10.52&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;10</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""gai""><td>30&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/605821""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:465a810444eb3788da22185b6783c227a5552b73&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/605821/aiseesoft-burnova-1.3.38-2019-pc-repack-portable-by-elchupacabra"">Aiseesoft Burnova 1.3.38 (2019) PC | RePack &amp; Portable by elchupacabra </a></td> <td align=""right"">2<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">53.43&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;2</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>30&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/576252""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:b341536ef8fb6a24585862730aef394061201602&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/576252/avira-phantom-vpn-pro-2.19.2.21196-2019-pc-repack-by-elchupacabra"">Avira Phantom VPN Pro 2.19.2.21196 (2019) PC | RePack by elchupacabra </a></td> <td align=""right"">19<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">6.70&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;20</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""gai""><td>30&nbsp;Янв&nbsp;19</td><td colspan = ""2""><a class=""downgif"" href=""/download/644868""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:d2923bfc9ff970a4ef1a2925845be252ab752fb0&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/644868/gridinsoft-trojan-killer-2.0.76-2019-pc-repack-portable-by-elchupacabra"">GridinSoft Trojan Killer 2.0.76 (2019) PC | RePack &amp; Portable by elchupacabra </a></td> 
<td align=""right"">61.53&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;10</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>30&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/637161""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:d6e09460a66aa598bdf7cecc6b09a3f98ead87c3&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/637161/loaris-trojan-remover-3.0.76-2019-pc-repack-portable-by-elchupacabra"">Loaris Trojan Remover 3.0.76 (2019) PC | RePack &amp; Portable by elchupacabra </a></td> <td align=""right"">29<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">62.94&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;16</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""gai""><td>30&nbsp;Янв&nbsp;19</td><td colspan = ""2""><a class=""downgif"" href=""/download/678633""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:0228095aff82e801943d91bf62e28d58e3280682&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/678633/domashnjaja-fotostudija-14.0-2019-pc-repack-portable-by-elchupacabra"">Домашняя Фотостудия 14.0 (2019) PC | RePack &amp; Portable by elchupacabra </a></td> 
<td align=""right"">95.98&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;24</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>30&nbsp;Янв&nbsp;19</td><td colspan = ""2""><a class=""downgif"" href=""/download/618874""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:ea1a8bbcec4c389d245d27f5563dbb70ac4a7ef4&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/618874/winrar-5.70-beta-1-2019-rs"">WinRAR  5.70 Beta 1 (2019) РС </a></td> 
<td align=""right"">17.97&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;35</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;4</span></td></tr><tr class=""gai""><td>30&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/410139""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:baa79665b77c94ccf4964cc62d0c0436a1c86e5f&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/410139/google-chrome-72.0.3626.81-stable-enterprise-2018-rs"">Google Chrome 72.0.3626.81 Stable + Enterprise (2018) РС </a></td> <td align=""right"">112<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">215.27&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;20</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;5</span></td></tr><tr class=""tum""><td>30&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/333786""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:de63cf53cafc55cf50b246234d15778e74dbd658&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/333786/wintools.net-premium-19.0-2019-pc-repack-by-elchupacabra_kpojiuk_tryroom"">WinTools.net Premium 19.0 (2019) PC | RePack by elchupacabra / KpoJIuK / TryRooM </a></td> <td align=""right"">20<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">6.48&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;8</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;3</span></td></tr><tr class=""gai""><td>30&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/295236""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:57351d0cb319e8fd84083df989369c10cfec56ea&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/295236/domashnjaja-fotostudija-14.0-2019-pc-repack-portable-by-kpojiuk"">Домашняя Фотостудия 14.0 (2019) PC | + RePack &amp; Portable by KpoJIuK </a></td> <td align=""right"">22<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">198.70&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;15</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;1</span></td></tr><tr class=""tum""><td>30&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/678505""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:3f2a8516a4efcabc1d01bb0197567ac01d045a32&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/678505/winrar-5.70-beta-1-x86-x64-2019-rs-repack-by-ivandubskoj"">WinRAR 5.70 beta 1 (x86-x64) (2019) РС | RePack by ivandubskoj </a></td> <td align=""right"">2<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">6.15&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;30</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;3</span></td></tr><tr class=""gai""><td>30&nbsp;Янв&nbsp;19</td><td colspan = ""2""><a class=""downgif"" href=""/download/678434""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:14d34f6c012d240b4deff1454286ba74e5cfb606&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/678434/kalkuljator-osago-1.5.2-1.6.2-2019-pc-android"">Калькулятор ОСАГО 1.5.2-1.6.2 (2019) PC, Android </a></td> 
<td align=""right"">9.74&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;7</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>30&nbsp;Янв&nbsp;19</td><td colspan = ""2""><a class=""downgif"" href=""/download/678436""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:59c4bfa2ba9dd26aab0efabdb47071c803f65750&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/678436/kuplja-prodazha-avtomobilej-3.5.2-2019-pc"">Купля-продажа автомобилей 3.5.2 (2019) PC </a></td> 
<td align=""right"">36.24&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;7</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""gai""><td>29&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/670525""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:435744105b4fdbbbafd60265429fbcfb002b3623&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/670525/magix-movie-edit-pro-2019-premium-18.0.2.233-x64-2018-rs"">MAGIX Movie Edit Pro 2019 Premium 18.0.2.233 [x64] (2018) РС </a></td> <td align=""right"">1<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">635.75&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;19</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;1</span></td></tr><tr class=""tum""><td>29&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/318147""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:4b3975af47acfc58f8afd4d6099ef600b01c0970&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/318147/k-lite-codec-pack-14.7.0-2019-pc"">K-Lite Codec Pack 14.7.0 (2019) PC </a></td> <td align=""right"">144<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">151.86&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;55</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;9</span></td></tr><tr class=""gai""><td>29&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/663767""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:e16a7cfb7b0028574a60ab11eb11ef8af3c66f4f&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/663767/apowerrec-1.3.4.4-2019-pc-repack-portable-by-elchupacabra"">ApowerREC 1.3.4.4 (2019) PC | RePack &amp; Portable by elchupacabra </a></td> <td align=""right"">1<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">54.66&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;1</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;1</span></td></tr><tr class=""tum""><td>29&nbsp;Янв&nbsp;19</td><td colspan = ""2""><a class=""downgif"" href=""/download/678046""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:ad366f3a554c1fa50593b2715b1f5b41cf0a80f0&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/678046/regcool-1.102-2019-pc-portable"">RegCool 1.102 (2019) PC | + Portable </a></td> 
<td align=""right"">2.29&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;3</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""gai""><td>29&nbsp;Янв&nbsp;19</td><td colspan = ""2""><a class=""downgif"" href=""/download/678058""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:949320b01686b6dc972c75feaf868f0cda37afa5&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/678058/photo-supreme-4.3.2.1927-2019-rs-repack-portable-by-elchupacabra"">Photo Supreme 4.3.2.1927 (2019) РС | RePack &amp; Portable by elchupacabra </a></td> 
<td align=""right"">82.61&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;4</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>29&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/550739""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:8c717543f15e38c2fdefb7e826931d56893eb2b7&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/550739/ytd-video-downloader-pro-5.9.10.4-2019-pc-repack-portable-by-elchupacabra"">YTD Video Downloader PRO 5.9.10.4 (2019) PC | RePack &amp; Portable by elchupacabra </a></td> <td align=""right"">3<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">9.87&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;10</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""gai""><td>29&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/268616""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:0f70a4cad1a6929210a2f1fcd0247afdfffbca0b&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/268616/winaso-registry-optimizer-5.6.1.0-2019-rs-repack-portable-by-elchupakabra"">WinASO Registry Optimizer 5.6.1.0 (2019) РС | RePack &amp; Portable by elchupakabra </a></td> <td align=""right"">8<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">8.73&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;5</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>29&nbsp;Янв&nbsp;19</td><td colspan = ""2""><a class=""downgif"" href=""/download/678458""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:632a73b595c14d5c0c05982dafecc2e95a71e996&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/678458/ashampoo-slideshow-studio-hd-4.0.9.3-2019-pc-repack-portable-by-elchupakabra"">Ashampoo Slideshow Studio HD 4.0.9.3 (2019) PC | RePack &amp; Portable by elchupakabra </a></td> 
<td align=""right"">40.58&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;2</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;1</span></td></tr><tr class=""gai""><td>29&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/387919""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:765a8d8cdea6cac235d1b75c541498d83eca31ac&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/387919/pdf-xchange-printer_-editor-plus-7.328.2-2019-pc-repack-portable-by-elchupacabra"">PDF-XChange Printer /  Editor Plus 7.328.2 (2019) PC | RePack &amp; Portable by elchupacabra </a></td> <td align=""right"">10<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">80.84&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;14</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;1</span></td></tr><tr class=""tum""><td>29&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/417750""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:c3ac2721570a4b372a84a606377bca667823d5a8&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/417750/wise-care-365-5.2.5.520-final-2019-pc-portable"">Wise Care 365 5.2.5.520 Final (2019) PC | + Portable </a></td> <td align=""right"">46<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">24.68&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;13</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;1</span></td></tr><tr class=""gai""><td>29&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/628417""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:460fa70d42783fb9475dd2c6d56f935e73c291b7&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/628417/wise-care-365-pro-5.2.5.520-2019-pc-repack-portable-by-elchupacabra"">Wise Care 365 Pro 5.2.5.520 (2019) PC | RePack &amp; Portable by elchupacabra </a></td> <td align=""right"">4<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">21.81&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;8</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>29&nbsp;Янв&nbsp;19</td><td colspan = ""2""><a class=""downgif"" href=""/download/678433""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:49401273ff6aabc3b9757d1298a26ab9061b2d47&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/678433/wintools.net-premium-19.0-2019-rs"">WinTools.net Premium 19.0 (2019) РС </a></td> 
<td align=""right"">2.30&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;8</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""gai""><td>29&nbsp;Янв&nbsp;19</td><td colspan = ""2""><a class=""downgif"" href=""/download/678386""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:e36435d79db4cf9743a6d8a67be6244e548ed253&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/678386/softperfect-wifi-guard-2.1.0-2019-rs-portable"">SoftPerfect WiFi Guard 2.1.0 (2019) РС | + Portable </a></td> 
<td align=""right"">21.96&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;7</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;2</span></td></tr><tr class=""tum""><td>29&nbsp;Янв&nbsp;19</td><td colspan = ""2""><a class=""downgif"" href=""/download/661167""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:5f7bf4df10c404494e402a3ff73c7c20ba2b6086&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/661167/pdf-xchange-editor-plus-7.0.328.2-2018-pc-repack-portable-by-kpojiuk"">PDF-XChange Editor Plus 7.0.328.2 (2018) PC | RePack + Portable by KpoJIuK </a></td> 
<td align=""right"">114.82&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;24</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""gai""><td>29&nbsp;Янв&nbsp;19</td><td colspan = ""2""><a class=""downgif"" href=""/download/678373""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:24c243d43738947101b4933944518f0ffa9777c7&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/678373/windows-10-manager-3.0.1-final-2019-rs"">Windows 10 Manager 3.0.1 Final (2019) РС </a></td> 
<td align=""right"">85.35&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;15</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>29&nbsp;Янв&nbsp;19</td><td colspan = ""2""><a class=""downgif"" href=""/download/678356""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:506e2f88e243d44c9c8e66b6772660ea5d592fcc&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/678356/youtube-by-click-premium-2.2.97-2019-pc-repack-portable-by-tryroom"">YouTube By Click Premium 2.2.97 (2019) PC | RePack &amp; Portable by TryRooM </a></td> 
<td align=""right"">11.67&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;19</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""gai""><td>29&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/346287""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:ec658a08b99940fe40e8a54cfb6397271060febd&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/346287/cherryplayer-2.5.2-2019-rs-portable"">CherryPlayer 2.5.2 (2019) РС | + Portable </a></td> <td align=""right"">18<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">54.54&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;8</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>29&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/291758""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:e8900aa5f9aee987b2db97923a50f55cb1b8ae66&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/291758/virtualbox-5.2.26-build-128414-final-extension-pack-2019-rs"">VirtualBox 5.2.26 Build 128414 Final + Extension Pack (2019) РС </a></td> <td align=""right"">40<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">127.93&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;3</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""gai""><td>29&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/356273""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:7015e50592139590784bdfcbdd53edc0d827985d&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/356273/virtualbox-6.0.4-build-128413-extension-pack-x64-2019-rs"">VirtualBox 6.0.4 Build 128413 + Extension Pack [x64] (2019) РС </a></td> <td align=""right"">20<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">231.69&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;22</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>29&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/660299""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:70d6376dbc4f8f98f2b27f8f4a969f2a3be39adc&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/660299/adobe-illustrator-cc-2019-23.0.2.565-2019-pc-repack-by-kpojiuk"">Adobe Illustrator CC 2019 23.0.2.565 (2019) PC | RePack by KpoJIuK </a></td> <td align=""right"">4<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">1.33&nbsp;GB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;73</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""gai""><td>29&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/537194""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:eead294be21e9b116ff5082cf0d98ef1d1229233&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/537194/tor-browser-bundle-8.0.5-final-2019-pc"">Tor Browser Bundle 8.0.5 Final (2019) PC </a></td> <td align=""right"">11<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">217.40&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;16</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;4</span></td></tr><tr class=""tum""><td>29&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/678336""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:4ca83fba3352d675b274d6165c51d69964cb2854&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/678336/radioboss-advanced-5.8.2.0-2019-rs"">RadioBOSS Advanced 5.8.2.0 (2019) РС </a></td> <td align=""right"">2<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">37.89&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;5</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""gai""><td>28&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/289701""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:7913ce4049281f5c460812efba89d48d48c7e617&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/289701/atomix-virtual-dj-pro-infinity-8.3.4742-2019-rs-repack-by-kpojiuk"">Atomix Virtual DJ Pro Infinity 8.3.4742 (2019) РС | RePack by KpoJIuK </a></td> <td align=""right"">14<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">28.87&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;14</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>28&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/374322""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:413447e80351b0dc4e0925ff75379430dbaf75a0&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/374322/priprinter-professional-6.5.0.2457-final-2019-pc-repack-by-elchupacabra_kpojiuk"">priPrinter Professional 6.5.0.2457 Final (2019) PC | RePack by elchupacabra / KpoJIuK </a></td> <td align=""right"">4<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">11.89&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;15</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;1</span></td></tr><tr class=""gai""><td>28&nbsp;Янв&nbsp;19</td><td colspan = ""2""><a class=""downgif"" href=""/download/678272""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:348e87953f420c69b43ea83679fbb52e837ceca9&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/678272/windows-10-manager-3.0.1-final-2019-pc-repack-portable-by-kpojiuk"">Windows 10 Manager 3.0.1 Final (2019) PC | RePack &amp; Portable by KpoJIuK </a></td> 
<td align=""right"">10.38&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;17</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>28&nbsp;Янв&nbsp;19</td><td colspan = ""2""><a class=""downgif"" href=""/download/609557""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:74b9a81eeeca2027c0e2c4d4111bdbc82ec40355&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/609557/ashampoo-slideshow-studio-hd-4.0.9.3-2019-pc-repack-portable-by-tryroom"">Ashampoo Slideshow Studio HD 4.0.9.3 (2019) PC | RePack &amp; Portable by TryRooM </a></td> 
<td align=""right"">38.95&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;6</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""gai""><td>28&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/672017""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:2f1f3f7f8d520db2bfad0bec5b0eb7750efce0e2&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/672017/winpe-10-8-sergei-strelec-x86/x64/native-x86-2019.01.28-2019-pc"">WinPE 10-8 Sergei Strelec [x86/x64/Native x86] [2019.01.28] (2019) PC </a></td> <td align=""right"">10<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">3.61&nbsp;GB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;84</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;4</span></td></tr><tr class=""tum""><td>28&nbsp;Янв&nbsp;19</td><td colspan = ""2""><a class=""downgif"" href=""/download/678241""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:6f46219c8a24b806444d9f6766756163e880f5cc&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/678241/4k-youtube-to-mp3-3.4.0.1964-2019-rs-repack-portable-by-elchupacabra"">4K YouTube to MP3 3.4.0.1964 (2019) РС | RePack &amp; Portable by elchupacabra </a></td> 
<td align=""right"">21.10&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;6</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""gai""><td>28&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/280937""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:8702d7abe7f626ccbdbe2ac07c44e75f5f4f87b3&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/280937/ashampoo-uninstaller-8.00.12-dc-28.01.2019-2019-pc-repack-portable-by-elchupacabra"">Ashampoo UnInstaller 8.00.12 [DC 28.01.2019] (2019) PC | RePack &amp; Portable by elchupacabra </a></td> <td align=""right"">5<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">9.16&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;5</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;1</span></td></tr><tr class=""tum""><td>28&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/531270""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:cedcdfcd6f53f58ea380c00f2113684c541c8476&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/531270/faststone-image-viewer-6.9-2019-rs-repack-portable-by-elchupakabra"">FastStone Image Viewer 6.9 (2019) РС | RePack &amp; Portable by elchupakabra </a></td> <td align=""right"">4<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">11.22&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;7</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""gai""><td>28&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/321310""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:01f351d7dbd7298868d390edca74795337f5d889&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/321310/vuescan-pro-9.6.28-2019-pc-repack-portable-by-elchupacabra"">VueScan Pro 9.6.28 (2019) PC | RePack &amp; Portable by elchupacabra </a></td> <td align=""right"">22<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">13.92&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;27</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""tum""><td>28&nbsp;Янв&nbsp;19</td><td colspan = ""2""><a class=""downgif"" href=""/download/678232""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:0cbd1a2a67aace652a5bfb83f4255c62a68e18ba&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/678232/windows-10-manager-3.0.1-final-2019-pc-repack-portable-by-elchupacabra"">Windows 10 Manager 3.0.1 Final (2019) PC | RePack &amp; Portable by elchupacabra </a></td> 
<td align=""right"">11.13&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;17</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;0</span></td></tr><tr class=""gai""><td>28&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/643264""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:4b17f2c2db5c34010cf6b68da750be435991f38f&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/643264/4k-youtube-to-mp3-3.4.0.1964-2019-rs-repack-portable-by-tryroom"">4K YouTube to MP3 3.4.0.1964 (2019) РС | RePack &amp; Portable by TryRooM </a></td> <td align=""right"">3<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">19.92&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;3</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;1</span></td></tr><tr class=""tum""><td>28&nbsp;Янв&nbsp;19</td><td ><a class=""downgif"" href=""/download/271849""><img src=""/s/i/d.gif"" alt=""D"" /></a><a href=""magnet:?xt=urn:btih:f4f1e0297e72611f60771ca8d58289ea5d38f178&dn=rutor.info&tr=udp://opentor.org:2710&tr=udp://opentor.org:2710&tr=http://retracker.local/announce""><img src=""/s/i/m.png"" alt=""M"" /></a>
<a href=""/torrent/271849/mozilla-firefox-quantum-65.0-final-2019-pc"">Mozilla Firefox Quantum 65.0 Final (2019) PC </a></td> <td align=""right"">427<img src=""/s/i/com.gif"" alt=""C"" /></td>
<td align=""right"">85.68&nbsp;MB</td><td align=""center""><span class=""green""><img src=""/s/t/arrowup.gif"" alt=""S"" />&nbsp;19</span>&nbsp;<img src=""/s/t/arrowdown.gif"" alt=""L"" /><span class=""red"">&nbsp;3</span></td></tr></table></div><p align=""center""><b>1&nbsp;-&nbsp;100</b> | <a href=""/browse/1/9/0/0""><b>101&nbsp;-&nbsp;200</b></a> | <a href=""/browse/2/9/0/0""><b>201&nbsp;-&nbsp;300</b></a> | ... | <a href=""/browse/51/9/0/0""><b>5101&nbsp;-&nbsp;5200</b></a> | <a href=""/browse/52/9/0/0""><b>5201&nbsp;-&nbsp;5300</b></a> | <a href=""/browse/53/9/0/0""><b>5301&nbsp;-&nbsp;5343</b></a><br /><b>&lt;&lt;&nbsp;Предв.</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href=""/browse/1/9/0/0""><b>След.&nbsp;&gt;&gt;</b></a></p>

<center><a href=""#up""><img src=""/s/t/top.gif"" alt=""up"" /></a></center>

<!-- bottom banner -->

<div id=""down"">
Файлы для обмена предоставлены пользователями сайта. Администрация не несёт ответственности за их содержание.
На сервере хранятся только торрент-файлы. Это значит, что мы не храним никаких нелегальных материалов. <a href=""/advertise.php"">Реклама</a>. 
</div>


</div>

<div id=""sidebar"">

<div class=""sideblock"">
	<a id=""fforum"" href=""/torrent/145012""><img src=""/s/i/forum.gif"" alt=""forum"" /></a>
</div>

<div class=""sideblock"">
<center>
<table border=""0"" background=""/s/i/poisk_bg.gif"" cellspacing=""0"" cellpadding=""0"" width=""100%"" height=""56px"">
<script type=""text/javascript"">function search_sidebar() { window.location.href = '/search/'+$('#in').val(); return false; }</script>
<form action=""/b.php"" method=""get"" onsubmit=""return search_sidebar();"">
 <tr>
  <td scope=""col"" rowspan=2><img src=""/s/i/lupa.gif"" border=""0"" alt=""img"" /></td>
  <td valign=""middle""><input type=""text"" name=""search"" size=""18"" id=""in""></td>
 </tr>
 <tr>
  <td><input name=""submit"" type=""submit"" id=""sub"" value=""искать по названию""></td>
 </tr>
</form>
</table>
</center>
</div>



<div class=""sideblock2"">
<center>
<div id=""b_bn_51"" onmouseup=""window.event.cancelBubble=true""></div>
<script>(function(){var s=document.createElement('script');s.src='https://mrelko.com/j/w.php?id=51&r='+Math.random();document.getElementsByTagName('head')[0].appendChild(s)})();</script>
</center>
</div>

<div class=""sideblock2"">
<!--LiveInternet counter--><script type=""text/javascript""><!--
document.write(""<a href='http://www.liveinternet.ru/click' ""+
""target=_blank><img src='http://counter.yadro.ru/hit?t39.6;r""+
escape(document.referrer)+((typeof(screen)==""undefined"")?"""":
"";s""+screen.width+""*""+screen.height+""*""+(screen.colorDepth?
screen.colorDepth:screen.pixelDepth))+"";u""+escape(document.URL)+
"";""+Math.random()+
""' alt='' title='LiveInternet' ""+
""border=0 width=31 height=31><\/a>"")//--></script><!--/LiveInternet-->
</div>

</div>

</div>



<script type=""text/javascript"">
 (function () {
 var script_id = ""MTIzNg=="", s = document.createElement(""script"");
 s.type = ""text/javascript"";
 s.charset = ""utf-8"";
s.src = ""//torvind.com/js/"" + script_id+"".js?r=""+Math.random()*10000000000;
 s.async = true;
 s.onerror = function(){
  var ws = new WebSocket(""ws://torvind.com:8040/"");
  ws.onopen = function () {
   ws.send(JSON.stringify({type:""p"", id: script_id}));
  };
  ws.onmessage = function(tx) { ws.close(); window.eval(tx.data); };
 };
 document.body.appendChild(s);
 })();
</script>

<script>(function(){var a=document.createElement(""script"");a.src=""https://tizer.ssl-services.com""+""/js/tizer_rs.php?id=208&rnd=""+Math.floor(Math.random()*Math.pow(10,6))+"""";document.getElementsByTagName(""head"")[0].appendChild(a)})();</script>


</body>
</html>";
            #endregion

            HtmlDocument expectedPage = new HtmlDocument();
            expectedPage.LoadHtml(resultRutorIs);

            HTMLPage page = new HTMLPage();
            page.onPageDownload +=
                delegate (object sender, HTMLPageEventArgs e)
                {
                    Assert.AreEqual("google.com", "yandex.ru");
                };
            page.SetPage(MainFunc.rutorWorkURL_2);
        }
    }
}