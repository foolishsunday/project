$(document).ready(function(){
	// $("#btnAni").click(function(){
	// 	$(".panel").animate({left:'250px',opacity:'0.5'});	//要记得首先把元素的 CSS position 属性设置为 relative、fixed 或 absolute！
	// });

	var txt;
	$("#btnText").click(function(){
		txt = $("#panel1").text();
		alert(txt);
	});

	$("#btnHtml").click(function(){
		txt = $("#panel1").html();
		alert(txt);
	});

	$("#btnHref").click(function(){
		txt = $("#sina").attr("href");
		alert(txt);
	});
});
