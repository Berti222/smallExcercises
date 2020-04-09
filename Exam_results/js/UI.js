class UI {
    constructor(examResults){
        this.examResults = examResults;
    }

    createOneRow(result){
        const resultParagraph = document.createElement('p');
        
        const nameDiv = document.createElement('div');
        const examDiv = document.createElement('div');
        const ratingDiv = document.createElement('div');

        const firstTwoColumnWidth = '120px';
        const inlineBlock = 'inline-block';
        const fontSize = '20pt';

        nameDiv.style.width = firstTwoColumnWidth;
        nameDiv.style.display = inlineBlock;
        ratingDiv.style.fontSize = fontSize;
        nameDiv.innerText = result.name;

        examDiv.style.width = firstTwoColumnWidth;
        examDiv.style.display = inlineBlock;
        ratingDiv.style.fontSize = fontSize;
        examDiv.innerText = result.exam;

        ratingDiv.style.width = this.ratingDivWidthCalculator(result.rating);
        ratingDiv.style.display = inlineBlock;
        ratingDiv.style.textAlign = 'center';
        ratingDiv.style.fontWeight = '400';
        ratingDiv.style.fontSize = '14pt';
        ratingDiv.style.color = '#DDD';
        ratingDiv.style.backgroundColor = this.ratingDivColor(result.rating);
        ratingDiv.innerText = result.rating;

        resultParagraph.appendChild(nameDiv);
        resultParagraph.appendChild(examDiv);
        resultParagraph.appendChild(ratingDiv);

        return resultParagraph;
    }

    ratingDivWidthCalculator(rating){
        const width = rating * 10;

        return width + 'px';
    }

    ratingDivColor(rating){
        let color;
        if(rating < 50){
            color = 'red';
        } else {
            color = 'green';
        }

        return color;
    }

    appendRows(){
        const results = this.examResults.getResults();

        const examResultsDiv = document.querySelector('#examResults');

        for(let result of results){
            const oneRow = this.createOneRow(result);
            examResultsDiv.appendChild(oneRow);
        }
    }

}