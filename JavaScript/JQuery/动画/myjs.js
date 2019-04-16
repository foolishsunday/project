$(document).ready(function(){
	// $("#btnAni").click(function(){
	// 	$(".panel").animate({left:'250px',opacity:'0.5'});	//要记得首先把元素的 CSS position 属性设置为 relative、fixed 或 absolute！
	// });

	
	$("#btnAniRelative").click(function(){
		var pnl = $("#panelRelative");
		pnl.animate({
			height:'+=100px',
			width:'+=100px',
			left:'250px'
		});	//要记得首先把元素的 CSS position 属性设置为 relative、fixed 或 absolute！
		pnl.stop(true,true);
		pnl.animate({
			height:'-=100px',
			width:'-=100px',
			right:'150px'
		});

	});

});
