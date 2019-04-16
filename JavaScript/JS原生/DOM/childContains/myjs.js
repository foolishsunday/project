window.onload=function(){
	var box=document.getElementById("odiv");
	var p=box.firstChild;
	// alert(p.nodeValue);

	// alert(box.contains(p));
	alert(contains(box,box.firstChild));


};

function contains(refNode,otherNode){
	if(typeof refNode.contains!='undefined' && false)
	{
		return 'defined';
		// return refNode.contains(otherNode);
	}
	else if(typeof compareDocumentPosition=='function')
	{
		return '>16';
		// return refNode.compareDocumentPosition(otherNode)>16;
	}		
	else
	{
		var node=otherNode.parentNode;
		do{
			if(node===refNode){
				return 'do';
				// return true;
			}else{
				node=otherNode.parentNode;
			}
		}while(node!=null);
		return 'end';
		// return false;
	}
};
// function contains_haha(refNode,otherNode){
// 	var node=otherNode.parentNode;
// 		do{
// 			if(node===refNode){
// 				return true;
// 			}else{
// 				node=otherNode.parentNode;
// 			}
// 	}while(node!=null)
// 	return false;

// };