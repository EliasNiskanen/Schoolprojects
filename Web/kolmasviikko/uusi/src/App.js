import React from 'react';
import './App.css';
import DataTable from './DataTable'

// laittakaa viive suoraan servulle. Kiitos!
// npx json-server db.json --watch --port 4000 --delay 2000

function App() {
  return (
    <div className="App">
      <DataTable/>
    </div>
  );
}

export default App;
