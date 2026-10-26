import React from 'react'
import Elain from './Elain'


function Elainlista() {
  const elaimet = [
      {
        Nimi: 'Mauri',
        Omistajannimi: 'Pertti Sotarumpu',
        Syntymävuosi: 1992
      },
      {
        Nimi: 'Antti',
        Omistajannimi: 'Pasi Perspäristys',
        Syntymävuosi: 1980
      },
      {
        Nimi: 'Selma',
        Omistajannimi: 'Antti Äyskäri',
        Syntymävuosi: 1934
      },
      {
        Nimi: 'Katri',
        Omistajannimi: 'Kari Kalannussija',
        Syntymävuosi: 1993 
      }
    ]
    const elainlista = elaimet.map(elain =>  (
      <Elain elain={elain}></Elain>
    ))

  return <ul>{elainlista}</ul>
  
  
}

export default Elainlista