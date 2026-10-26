import {getByText, render, screen} from '@testing-library/react'
import userEvent from '@testing-library/user-event'
import Elainlista from './Elainlista'

describe("Testi 1 tehtävälle", ()=> {
    test("Luodaan komponentti ja testataan ulkoasu.", () => {
        render(<Elainlista/>);
        expect(screen.getByText("Mauri , Pertti Sotarumpu , 1992")).toBeInTheDocument();
        expect(screen.getByText("Antti , Pasi Perspäristys , 1980")).toBeInTheDocument();
        expect(screen.getByText("Selma , Antti Äyskäri , 1934")).toBeInTheDocument();
        expect(screen.getByText("Katri , Kari Kalannussija , 1993")).toBeInTheDocument();

    })
});