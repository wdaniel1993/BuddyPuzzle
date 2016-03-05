module Question

type Question = Question of string
type Answer = {question: Question; points: int}

type Person = Person of string

type SelectedList<'t> = {active: 't; rest: 't list} 

type Round = 
    |ActiveRound of SelectedList<Person> * Question
    |FinishedRound of Person * Question * Answer list

let q = Question("Ich bin mutig!")
let a = {question=q; points=5}
