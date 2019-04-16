
// for (var i = 0; i <navigator.plugins.length;i++) {
// 	document.write(navigator.plugins[i].name+'</br>');
// }

/*检测IE浏览器是否有flash控件*/
// function hasIEPlugin(name){
// 	try{
// 		new ActiveXObject(name)
// 		return true;
// 	}
// 	catch (e){
// 		return false;
// 	}
// }
// document.write(hasIEPlugin('ShockwaveFlash.ShockwaveFlash'));


function hasPlugin(name) {
	var name=name.toLowerCase();
	for(var i=0;i<navigator.plugins.length;i++)
	{
		if(navigator.plugins[i].name.toLowCase().indexOf(name)>-1){
			return true;
		}
	}
	return false;
}
function hasIEPlugin(name){
	try{
		new ActiveXObject(name)
		return true;
	}
	catch (e){
		return false;
	}
}
function hasFlash(){
	var result=hasPlugin('Flash');
	if(!result){
		return hasIEPlugin('ShockwaveFlash.ShockwaveFlash');	
	}
	return result;
}
document.write(hasIEPlugin(hasFlash()));