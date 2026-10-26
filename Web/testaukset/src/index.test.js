import {getByText, render, screen} from '@testing-library/react'
import DataTable from './DataTable'

beforeEach(() => {
    jest.spyOn(global, 'fetch').mockResolvedValue({
        json: jest.fn().mockResolvedValue([{id: 1, nimi: "Elias", puhelinnumero: "0700123123", osoite: "PL 347", postinumero: "33101", postitoimipaikka: "Tampere"}])
    })
})
afterEach(()=> {
    jest.resetAllMocks();
})

describe("testit tehtävä 15 taululle.", () => {
    test("Haetaan REST.apista tiedot ja tarkistetaan. ", async ()=> {
        render(<DataTable/>);
        const asiakas = await screen.findAllByTestId('pUser')
        expect(asiakas).toHaveLength(90)
        expect(asiakas[0].innerHTML).toBe("<td>1</td><td>Elias</td><td>0700123123</td><td>PL 347</td><td>33101</td><td>Tampere</td>");
    })
})