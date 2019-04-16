$(document).ready(function(){
	// $("#btnAni").click(function(){
	// 	$(".panel").animate({left:'250px',opacity:'0.5'});	//要记得首先把元素的 CSS position 属性设置为 relative、fixed 或 absolute！
	// });

	
	$("#btnAniRelative").click(function(){
		var pnl = $("#panelRelative");
		pnl.css("color","red").animate({
			height:'+=100px',
			width:'+=100px',
			left:'250px'
		}).slideUp(2000);	//要记得首先把元素的 CSS position 属性设置为 relative、fixed 或 absolute！


	});

});
