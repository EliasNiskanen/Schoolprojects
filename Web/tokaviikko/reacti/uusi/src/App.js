import React, {useState, useEffect} from 'react';
import './App.css';
import Search, {asiakas} from './Search';

//avaa db.json tiedosto valmiiksi 2sekunnin viiveellä: npx json-server db.json --watch --port 4000 --delay 2000

export default function App() {

  return (
    <div className="App">
      <Search/>
    </div>
  );
}

