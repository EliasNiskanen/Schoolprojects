import React, {Component} from 'react'
import Elainlista from './Elainlista'
import TableClass from './TableClass'
import './App.css'
import Nappi from './Nappi'




function App() {

    return (
      <>
        <div>
            <Elainlista />
            <TableClass headers={["nimi", "osoite", "aloitusvuosi"]}
            items={[ {nimi: "Pera", osoite:"Hämeenkatu", aloitusvuosi:"2022" }]}/>
            <TableClass headers={["nimi", "osoite", "aloitusvuosi", "lopettanut"]}
            items={[ {nimi: "Kake", osoite:"Kauppakatu",  lopettanut: "2010"},
            {nimi: "Keijo", osoite:"Haukkaakatu", aloitusvuosi:"2009" }
            ]}/>
            <Nappi />

        </div>
      
      </>
    )
}

export default App
