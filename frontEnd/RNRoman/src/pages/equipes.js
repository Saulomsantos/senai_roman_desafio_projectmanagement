import React, { Component } from 'react';
import { Text, View, StyleSheet } from 'react-native';

class Equipes extends Component {
    render() {
        return (
            <View style={styles.container}>
                <Text>Equipes</Text>
            </View>
        )
    }
}

export default Equipes;

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#fff',
        alignItems: 'center',
        justifyContent: 'center',
    },
});