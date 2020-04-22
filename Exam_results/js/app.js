const examResults = new ExamResults();
const ui = new UI(examResults);

window.addEventListener('load', windowLoadHandler);

function windowLoadHandler(){
    console.log(examResults.getResults());

    ui.appendRows();
}

