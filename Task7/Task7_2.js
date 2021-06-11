function mathCalculator(expression){
	expression = expression.replaceAll(' ','');
	regexpNumbers = /[\+\-*/=]/
	regexpSigns = /[\+\-*/]/g
	let numbers = expression.split(regexpNumbers).map(string => parseFloat(string));
	numbers.pop()
	let answer = numbers[0];
	let signs = expression.match(regexpSigns);
	for (var i = 0; i < signs.length; i++) {
		switch(signs[i]){
			case "+":
				answer+=numbers[i+1]
				break;
			case "-":
				answer-=numbers[i+1]
				break;
			case "/":
				answer/=numbers[i+1]
				break;	
			case "*":
				answer*=numbers[i+1]
				break;

		}
	}
	return answer.toFixed(2);
}