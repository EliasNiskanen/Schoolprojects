import React from 'react'

function Elain({elain}) {
  return (
    <div>
        <li>
            {elain.Nimi} , {elain.Omistajannimi} , {elain.Syntymävuosi}
        </li>
    </div>
  )
}

export default Elain