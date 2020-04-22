const examResults = new ExamResults();
const ui = new UI(examResults);

window.addEventListener('load', windowLoadHandler);

function windowLoadHandler(){
    console.log(examResults.getResults());

    const examResultsDiv = document.querySelector('#examResults');

    ui.appendRows(examResultsDiv);
}

