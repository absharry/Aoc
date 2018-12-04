import * as React from 'react';

type DayProps = {
    match: any
}

class Day extends React.Component<DayProps, {}> {
    public render() {
        return (
            <div className="day-container">
                <h2>{this.props.match.params.year} - Day {this.props.match.params.day}</h2>
            </div>
        );
    }
}

export default Day;