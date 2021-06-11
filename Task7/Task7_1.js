function countLettersInWordMap(word){
	let map = new Map();
	for (var i = 0; i < word.length; i++) {
		if (!map.has(word[i])){
			map.set(word[i],1)
		}else{
			map.set(word[i],map.get(word[i])+1)
		}
	}
	return map;
}

function charRemover(text){
	let words = [""];
    for(var i = 0; i < text.length; i++)
  		if(text[i] !== " " && text[i] !== "?" && text[i] !== "!" && text[i] !== ":"
  			&& text[i] !== ";" && text[i] !== "," && text[i] !== ".")
    		words[words.length - 1] += text[i];
  		else if(words[words.length - 1])
    		words.push("");
   let textToReturn = text;
   for (var i = 0; i < words.length; i++) {
   		let dataCnt = countLettersInWordMap(words[i]);
   		dataCnt.forEach((value,key,map)=>{
   			if (value > 1){
   				console.log(value)
   				console.log(key)
   				textToReturn = textToReturn.replaceAll(key,'');
   			}
   			console.log(textToReturn)
   		})
   }
	return textToReturn;
}
