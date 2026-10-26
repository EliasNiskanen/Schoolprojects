import React, {useState, useEffect} from 'react';
import Datatable from './datatable'
import './App.css'



export default function App(){
  const [data, setData] = useState([])
  const [q, setQ] = useState("")

  useEffect(() => {
    fetch("http://localhost:4000/Asiakkaat") //npx json-server db.json --watch --port 4000 --delay 2000 "Käyttäkää tätä kun avaatte tietokannan."
      .then(response => response.json())
      .then((json) => setData(json));
  }, [])

  function search(rows) {
    return rows.filter(
      (row) =>
       row.nimi.toLowerCase().indexOf(q)>-1 ||
       row.osoite.toLowerCase().indexOf(q)>-1)
  }
  if(data == null)
  return(
      <div>
      <p> loading...</p>        
      </div>
  )
    else if (data.length == 0){
    return(
      <div>                    
          <p>hakukenttä</p>
          <input type="text" value={this.state.value} onChange={this.searchData} />
          <p>Annetuilla hakuehdoilla ei löytynyt dataa</p>
      </div>
  )
  }
  else{
    return (
    <div>
      <div>
        <p>hakukenttä hae nimellä tai osoitteella.</p>
        <input type="text" value={q} onChange={(e) => setQ(e.target.value)}/>
      </div>
      <div>
        <Datatable data={search(data)}/>
      </div>
    </div>
    )}
}

