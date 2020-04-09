class Data{

    names = ["Béla", "Károly", "Róbert", "Mária", "Lajos", "Izabella", "Anett", "Zsófia", "Tünde", "Dénes"];
    exams = [];

    constructor(){
        this.createExams();
    }
    
    getNames(){
        return this.names;
    }

    getExams(){
        return this.exams;
    }

    createExams(){
        for(let i= 0; i <60; i++){
            this.exams.push("exam " + (i+1));
        }
    }

}

class ExamResults{

    results = [];

    constructor(data){
        this.data = data;
        this.createResults();
    }

    getResults(){
        return this.results;
    }

    createResults(){
        const names = this.data.getNames();
        const exams = this.data.getExams();

        for (let i = 0; i < exams.length; i++) {
            for(let j = 0; j < names.length; j++){
                
                const result = 
                {
                    name : names[j],
                    exam : exams[i],
                    rating : this.creatRating()
                }

                this.results.push(result);
            }            
        }
    }

    creatRating(){
        return Math.ceil(Math.random()*100);
    }

    orderResultByName(){
        this.results.sort(results.name);
        return this.results;
    }
}