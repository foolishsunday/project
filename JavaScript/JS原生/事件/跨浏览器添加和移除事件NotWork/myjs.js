


function toBlue(){
	this.className = 'blue';
	this.removeEventListener('click',toBlue,false);
	this.addEventListener('click',toRed,false);
}

function toRed(){
	this.className = 'red';
	this.removeEventListener('click',toRed,false);
	this.addEventListener('click',toBlue,false);

}

window.addEventListener('load',function(){
	var box = document.getElementById('box');
	box.addEventListener('click',toBlue,false);
},false);


function addEvent(obj,type,fn){
	if(obj.addEventListener){
		obj.addEventListener(type,fn,false);
	}else if(obj.attachEvent){
		obj.attachEvent('on'+type,fn);
	}
}

function removeEvent(obj,type,fn){
	if(obj.removeEventListener){
		obj.removeEventListener(type,fn,false);
	}else if(obj.detachEvent){
		obj.detachEvent('on'+type,fn);
	}
}