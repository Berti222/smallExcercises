const data = new Data();
const examResults = new ExamResults(data);
const ui = new UI(examResults);

window.addEventListener('load', windowLoadHandler);

function windowLoadHandler(){
    console.log(examResults.getResults());

    ui.appendRows();
}

